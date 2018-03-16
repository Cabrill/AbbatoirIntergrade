using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Accord.IO;
using Accord.Math;
using Accord.Neuro;
using Accord.Neuro.Learning;
using Accord.Neuro.Networks;
using FlatRedBall.Instructions;
using FlatRedBall.IO;

namespace AbbatoirIntergrade.MachineLearning.Models
{
    public class DeepBeliefNetworkModel : IModel
    {
        public long LastLearnTime { get; private set; }
        public long LastPredictTime { get; private set; }

        private DeepBeliefNetwork network;
        private DeepBeliefNetwork updatingNetwork;
        private DeepBeliefNetworkLearning unsupervisedTeacher;
        private BackPropagationLearning supervisedTeacher;
        private int Epochs = 100;
        private int HiddenLayerNodes = 150;
        private bool hasTrained;
        private bool declineEpochs = true;
        private float declineRate = 200;

        public double LastPrediction { get; private set; }
        public double LastMSE { get; private set; }
        public int LastSampleSize { get; private set; }
        public bool IsReady { get; private set; }

        public void Initialize()
        {
            const int inputCount = 460;
            IsReady = false;

            network = new DeepBeliefNetwork((int)inputCount, HiddenLayerNodes, 1);
            new GaussianWeights(network, 0.1).Randomize();
            network.UpdateVisibleWeights();

            unsupervisedTeacher = new DeepBeliefNetworkLearning(network)
            {
                Algorithm = (h, v, i) => new ContrastiveDivergenceLearning(h, v)
                {
                    LearningRate = 0.1,
                    Momentum = 0.9,
                    Decay = 0.01,
                }
            };

            supervisedTeacher = new BackPropagationLearning(network)
            {
                LearningRate = 0.1,
                Momentum = 0.5
            };
        }

        private void CreateTeachers()
        {
            unsupervisedTeacher = new DeepBeliefNetworkLearning(network)
            {
                Algorithm = (h, v, i) => new ContrastiveDivergenceLearning(h, v)
                {
                    LearningRate = 0.1,
                    Momentum = 0.9,
                    Decay = 0.01,
                }
            };

            supervisedTeacher = new BackPropagationLearning(network)
            {
                LearningRate = 0.1,
                Momentum = 0.5
            };
        }

        public string GetName()
        {
            var baseName = GetType().ToString().Replace("AITesting.Models.", "").Replace("Model", "");

            return baseName + Epochs.ToString() + "Epochs" + HiddenLayerNodes.ToString() + "Nodes";
        }

        public void LearnAll(WaveData waveData)
        {
            void LearnThenUpdateNetworkAction()
            {
                var updatedNetwork = LearnOnBackgroundThread(waveData.WaveInputs.ToArray(), waveData.WaveScores.ToArray());
                MeanSquaredError(waveData);
                Action UpdateAction = () => ReplaceModelWithUpdate(updatedNetwork);
                InstructionManager.AddSafe(UpdateAction);
            }

            Task.Run((Action) LearnThenUpdateNetworkAction);
        }

        private void ReplaceModelWithUpdate(DeepBeliefNetwork updatedNetwork)
        {
            network = updatedNetwork;
            IsReady = true;
        }

        private DeepBeliefNetwork LearnOnBackgroundThread(double[][] inputs, double[] outputDouble)
        {
            updatingNetwork = network.DeepClone();

            var sampleSize = outputDouble.Length;
            var inputToUse = inputs;
            var outputToUse = outputDouble;

            var outputData = new double[outputToUse.Length][];
            for (var i = 0; i < outputToUse.Length; i++)
            {
                outputData[i] = new[] { outputToUse[i] };
            }

            var sw = Stopwatch.StartNew();

            // Setup batches of input for learning.
            var batchCount = Math.Max(1, inputToUse.Length / 100);
            // Create mini-batches to speed learning.
            var groups = Accord.Statistics.Tools.RandomGroups(inputToUse.Length, batchCount);
            var batches = inputToUse.Subgroups(groups);

            var epochsToUse = (declineEpochs ? Math.Max(5, Epochs * (1 - sampleSize / declineRate)) : Epochs);

            // Unsupervised learning on each hidden layer, except for the output layer.
            for (var layerIndex = 0; layerIndex < updatingNetwork.Machines.Count - 1; layerIndex++)
            {
                unsupervisedTeacher.LayerIndex = layerIndex;
                var layerData = unsupervisedTeacher.GetLayerInput(batches);
                for (var i = 0; i < epochsToUse / 2.5; i++)
                {
                    unsupervisedTeacher.RunEpoch(layerData);
                }
            }

            // Run supervised learning.
            for (var i = 0; i < epochsToUse; i++)
            {
                supervisedTeacher.RunEpoch(inputToUse, outputData);
            }
            updatingNetwork.UpdateVisibleWeights();

            sw.Stop();
            LastLearnTime = sw.ElapsedMilliseconds;

            return updatingNetwork;
        }

        public double MeanSquaredError(WaveData waveData)
        {
            var input = waveData.WaveInputs.ToArray();
            var outputData = waveData.WaveScores.ToArray();
            var error = 0.0;
            for (var i = 0; i < outputData.Length; i++)
            {
                var prediction = network.Compute(input[i])[0];
                var actual = outputData[i];
                error += Math.Pow(prediction - actual, 2);
            }

            error /= outputData.Length;

            LastSampleSize = outputData.Length;
            LastMSE = error;

            return error;
        }


        public double Predict(double[] input)
        {
            var sw = Stopwatch.StartNew();

            var prediction = network.Compute(input)[0];

            sw.Stop();

            if (double.IsInfinity(prediction) || double.IsNaN(prediction))
            {
#if DEBUG
                //throw new Exception("Prediction was NaN");
#endif
                prediction = 0;
            }

            LastPredictTime = sw.ElapsedMilliseconds;
            LastPrediction = prediction;

            return prediction;
        }

        public bool Load(string fileName)
        {
            var fileExists = FileManager.FileExists(fileName);
            if (!fileExists) return false;

            try
            {
                Serializer.Load(fileName, out network);
                CreateTeachers();
            }
            catch (Exception ex)
            {
                return false;
            }
            hasTrained = true;
            IsReady = true;
            return true;
        }

        public bool Save(string fileName)
        {
            try
            {
                Serializer.Save(network, fileName);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
