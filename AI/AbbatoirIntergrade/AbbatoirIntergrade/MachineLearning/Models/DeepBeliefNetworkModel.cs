using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AbbatoirIntergrade.StaticManagers;
using Accord.IO;
using Accord.Math;
using Accord.Neuro;
using Accord.Neuro.Learning;
using Accord.Neuro.Networks;
using Accord.Statistics;
using FlatRedBall;
using FlatRedBall.Instructions;
using FlatRedBall.IO;

namespace AbbatoirIntergrade.MachineLearning.Models
{
    public class DeepBeliefNetworkModel 
    {
        public long LastLearnTime { get; private set; }
        public long LastPredictTime { get; private set; }
        public double AVMMSE { get; private set; } = 0;

        private DeepBeliefNetwork network;
        private DeepBeliefNetwork updatingNetwork;
        private DeepBeliefNetworkLearning unsupervisedTeacher;
        private BackPropagationLearning supervisedTeacher;
        private int Epochs = 300;
        private int HiddenLayerNodes;
        private bool hasTrained;
        private bool declineEpochs = true;
        private int declineRate = 100;

        public double LastPrediction { get; private set; }
        public double LastMSE { get; private set; }
        public int LastSampleSize { get; private set; }
        public bool IsReady { get; private set; }
        public bool IsCurrentlyLearning { get; private set; }
        public Stopwatch LearningStopwatch { get; private set; }= new Stopwatch();
        private readonly Mutex _modelMutex = new Mutex();
        private double unsupervisedLR;
        private double unsupervisedM;
        private double unsupervisedD;
        private double supervisedLR;
        private double supervisedM;

        public void Initialize(int inputCount, int hiddenLayerNodes, double usLR = 0.8, double usM = 0.8, double usD = 0.9, double sLR = 0.2, double sM = 0.21)
        {
            IsReady = false;
            HiddenLayerNodes = hiddenLayerNodes;
            unsupervisedLR = usLR;
            unsupervisedM = usM;
            unsupervisedD = usD;
            supervisedLR = sLR;
            supervisedM = sM;

            network = new DeepBeliefNetwork(inputCount, HiddenLayerNodes, 1);
            new GaussianWeights(network, 0.1).Randomize();
            network.UpdateVisibleWeights();

            CreateTeachers(network);
        }

        public void CreateTeachers(DeepBeliefNetwork dbn)
        {
            unsupervisedTeacher = new DeepBeliefNetworkLearning(dbn)
            {
                Algorithm = (h, v, i) => new ContrastiveDivergenceLearning(h, v)
                {
                    LearningRate = unsupervisedLR,
                    Momentum = unsupervisedM,
                    Decay = unsupervisedD,
                }
            };

            supervisedTeacher = new BackPropagationLearning(dbn)
            {
                LearningRate = supervisedLR,
                Momentum = supervisedM
            };

        }

        public string GetName()
        {
            var baseName = GetType().ToString().Replace("AITesting.Models.", "").Replace("Model", "");

            return baseName + Epochs.ToString() + "Epochs" + HiddenLayerNodes.ToString() + "Nodes";
        }

        public void LearnAll(WaveData waveData)
        {
            IsCurrentlyLearning = true;
            UpdateMeanSquaredError(waveData);
            //var updatedNetwork = 
                LearnForUpdatedModel(waveData.WaveInputs.ToArray(), waveData.WaveScores.ToArray());

            //var performanceData = new
            //{
            //    MSE = LastMSE,
            //    AVMMSE = AVMMSE,
            //    SampleSize = LastSampleSize,
            //    LastScore = waveData.WaveScores.Last(),
            //    LearnTime = LastLearnTime,
            //};
            //AnalyticsManager.SendEventImmediately("ModelUpdate", performanceData);

            //ReplaceModelWithUpdate(updatedNetwork);
        }

        private void ReplaceModelWithUpdate(DeepBeliefNetwork updatedNetwork)
        {
            _modelMutex.WaitOne();
            network = updatedNetwork;
            _modelMutex.ReleaseMutex();
            IsReady = true;
            IsCurrentlyLearning = false;
        }

        private void LearnForUpdatedModel(double[][] inputs, double[] outputDouble)
        {
            _modelMutex.WaitOne();
            //updatingNetwork = network.DeepClone();
            _modelMutex.ReleaseMutex();

            //CreateTeachers(network);

            var sampleSize = outputDouble.Length;
            var inputToUse = inputs;
            var outputToUse = outputDouble;

            var outputData = new double[outputToUse.Length][];
            for (var i = 0; i < outputToUse.Length; i++)
            {
                outputData[i] = new[] { outputToUse[i] };
            }

            LearningStopwatch.Reset();
            LearningStopwatch.Start();

            // Setup batches of input for learning.
            var batchCount = Math.Max(1, inputToUse.Length / 100);
            // Create mini-batches to speed learning.

            int[] groups = Accord.Statistics.Tools.RandomGroups(inputToUse.Length, batchCount);
            double[][][] batches = inputToUse.Subgroups(groups);

            var epochsToUse = Epochs;
            if (declineEpochs && sampleSize > declineRate)
            {
                epochsToUse = Math.Max(10, epochsToUse + declineRate - sampleSize);
            }

            // Unsupervised learning on each hidden layer, except for the output layer.
            for (var layerIndex = 0; layerIndex < network.Machines.Count - 1; layerIndex++)
            {
                unsupervisedTeacher.LayerIndex = layerIndex;
                var layerData = unsupervisedTeacher.GetLayerInput(batches);
                for (var i = 0; i < epochsToUse / 3; i++)
                {
                    unsupervisedTeacher.RunEpoch(layerData);
                }
            }

            // Run supervised learning.
            for (var i = 0; i < epochsToUse; i++)
            {
                supervisedTeacher.RunEpoch(inputToUse, outputData);
            }
            //updatingNetwork.UpdateVisibleWeights();

            LearningStopwatch.Stop();
            
            LastLearnTime = LearningStopwatch.ElapsedMilliseconds;

            LearningStopwatch.Reset();

            //return updatingNetwork;
        }

        private double UpdateMeanSquaredError(WaveData waveData)
        {
            var input = waveData.WaveInputs.ToArray();
            var outputData = waveData.WaveScores.ToArray();
            var error = 0.0;
            var avmError = 0.0;
            
            for (var i = 0; i < outputData.Length; i++)
            {
                var prediction = network.Compute(input[i])[0];
                var av = i == 0 ? 0 : outputData.Take(i).Average(d => d);
                var actual = outputData[i];
                error += Math.Pow(prediction - actual, 2);
                avmError += Math.Pow(av - actual, 2);
            }
            
            error /= outputData.Length;
            avmError /= outputData.Length;

            LastSampleSize = outputData.Length;
            LastMSE = error;
            AVMMSE = avmError;

            return error;
        }


        public double Predict(double[] input)
        {
            var sw = Stopwatch.StartNew();
            _modelMutex.WaitOne();
            var prediction = network.Compute(input)[0];
            _modelMutex.ReleaseMutex();
            sw.Stop();

            if (double.IsInfinity(prediction) || double.IsNaN(prediction))
            {
#if DEBUG
                throw new Exception("Prediction was NaN");
#endif
                var errorEventObject = new
                {
                    SampleSize = LastSampleSize,
                    LearnTime = LastLearnTime,
                    MSE = LastMSE
                };
                AnalyticsManager.SendEventImmediately("PredictionError", errorEventObject);
                prediction = FlatRedBallServices.Random.Between(0.00000001f, 0.00000005f);
            }

            LastPredictTime = sw.ElapsedMilliseconds;
            LastPrediction = prediction;

            return prediction;
        }

        public bool Load(string fileName)
        {
            _modelMutex.WaitOne();
            var fileExists = FileManager.FileExists(fileName);
            if (!fileExists)
            {
                _modelMutex.ReleaseMutex();
                return false;
            }

            try
            {
                Serializer.Load(fileName, out network);
                //CreateTeachers();
            }
            catch (Exception ex)
            {
                _modelMutex.ReleaseMutex();
                return false;
            }
            hasTrained = true;
            IsReady = true;
            _modelMutex.ReleaseMutex();
            return true;
        }

        public bool Save(string fileName)
        {
            try
            {
                _modelMutex.WaitOne();
                Serializer.Save(network, fileName);
                _modelMutex.ReleaseMutex();
            }
            catch (Exception ex)
            {
                _modelMutex.ReleaseMutex();
                return false;
            }
            return true;
        }
    }
}
