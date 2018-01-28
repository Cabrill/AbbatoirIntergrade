using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Math;
using Accord.Neuro;
using Accord.Neuro.Learning;
using Accord.Neuro.Networks;

namespace AbbatoirIntergrade.MachineLearning.Models
{
    public class NeuralNetworkModel : IModel
    {
        public long LastLearnTime { get; private set; }
        public long LastPredictTime { get; private set; }

        private Accord.Neuro.Networks.DeepBeliefNetwork network;
        private DeepBeliefNetworkLearning unsupervisedTeacher;
        private BackPropagationLearning supervisedTeacher;
        private int Epochs;
        private int HiddenLayerNodes;
        private bool hasTrained = false;
        private bool shouldUseOnlyLastData;

        public double LastPrediction { get; private set; }
        public double LastMSE { get; private set; }

        public void Initialize(int epochs = 200, int hiddenLayerNodes = 100)
        {
            var inputCount = 450;
            Epochs = (int)epochs;
            HiddenLayerNodes = (int)hiddenLayerNodes;
            network = new Accord.Neuro.Networks.DeepBeliefNetwork((int)inputCount, HiddenLayerNodes, 1);
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

        public string GetName()
        {
            var baseName = GetType().ToString().Replace("AITesting.Models.", "").Replace("Model", "");

            return baseName + Epochs.ToString() + "Epochs" + HiddenLayerNodes.ToString() + "Nodes";
        }

        public void LearnAll(double[][] inputs, double[] outputDouble)
        {
            var outputData = new double[outputDouble.Length][];

            for (var i = 0; i < outputDouble.Length; i++)
            {
                outputData[i] = new[] { outputDouble[i] };
            }

            var sw = Stopwatch.StartNew();
            // Start running the learning procedure
            // Setup batches of input for learning.
            int batchCount = Math.Max(1, inputs.Length / 100);
            // Create mini-batches to speed learning.
            int[] groups = Accord.Statistics.Tools.RandomGroups(inputs.Length, batchCount);
            double[][][] batches = inputs.Subgroups(groups);
            // Learning data for the specified layer.
            double[][][] layerData;

            // Unsupervised learning on each hidden layer, except for the output layer.
            for (var layerIndex = 0; layerIndex < network.Machines.Count - 1; layerIndex++)
            {
                unsupervisedTeacher.LayerIndex = layerIndex;
                layerData = unsupervisedTeacher.GetLayerInput(batches);
                for (int i = 0; i < Epochs / 2.5; i++)
                {
                    unsupervisedTeacher.RunEpoch(layerData);
                }
            }

            // Run supervised learning.
            for (var i = 0; i < Epochs; i++)
            {
                supervisedTeacher.RunEpoch(inputs, outputData);
            }
            network.UpdateVisibleWeights();

            sw.Stop();
            LastLearnTime = sw.ElapsedMilliseconds;
        }

        public double MeanSquaredError(double[][] input, double[] outputDouble, int[] outputInt, bool[] outputBool)
        {
            double error = 0;
            for (var i = 0; i < outputDouble.Length; i++)
            {
                var prediction = network.Compute(input[i])[0];
                var actual = outputDouble[i];
                error += Math.Pow(prediction - actual, 2);
            }

            error /= outputDouble.Length;

            LastMSE = error;

            return error;
        }


        public double Predict(double[] input)
        {
            var sw = Stopwatch.StartNew();

            var prediction = network.Compute(input)[0];
            sw.Stop();

            LastPredictTime = sw.ElapsedMilliseconds;
            LastPrediction = prediction;

            return prediction;
        }
    }
}
