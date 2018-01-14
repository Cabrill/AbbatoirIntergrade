using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Neuro;
using Accord.Neuro.Learning;
using Accord.Neuro.Networks;

namespace AbbatoirIntergrade.MachineLearning.Models
{
    public class NeuralNetworkModel : IModel
    {
        public long LastLearnTime { get; private set; }
        public long LastPredictTime { get; private set; }

        public DeepBeliefNetwork Network;
        public DeepNeuralNetworkLearning Teacher;
        private const int Epochs = 50;
        private const int HiddenLayerNodes = 130;
        private bool hasTrained = false;

        public void Initialize()
        {
            Network = new DeepBeliefNetwork(HiddenLayerNodes, HiddenLayerNodes, 1);
            new GaussianWeights(Network, 0.1).Randomize();
            Network.UpdateVisibleWeights();

            Teacher = new DeepNeuralNetworkLearning(Network)
            {
                Algorithm = (ann, i) => new ParallelResilientBackpropagationLearning(ann),
                LayerIndex = Network.Layers.Length - 1,
            };
        }

        public void Initialize(DeepBeliefNetwork dbn)
        {
            Network = dbn;
            Teacher = new DeepNeuralNetworkLearning(Network)
            {
                Algorithm = (ann, i) => new ParallelResilientBackpropagationLearning(ann),
                LayerIndex = Network.Layers.Length - 1,
            };
        }

        public void LearnAll(double[][] input, double[] outputDouble)
        {
            var sw = Stopwatch.StartNew();

            // Gather learning data for the layer
            var layerData = Teacher.GetLayerInput(input);

            var outputData = new double[outputDouble.Length][];

            for (var i = 0; i < outputDouble.Length; i++)
            {
                outputData[i] = new[] { outputDouble[i] };
            }

            // Start running the learning procedure
            for (var i = 0; i < Epochs; i++)
            {
                Teacher.RunEpoch(layerData, outputData);
            }
            Network.UpdateVisibleWeights();

            sw.Stop();
            LastLearnTime = sw.ElapsedMilliseconds;
        }

        public double Predict(double[] input)
        {
            var sw = Stopwatch.StartNew();

            var prediction = Network.Compute(input)[0];
            sw.Stop();

            LastPredictTime = sw.ElapsedMilliseconds;

            return prediction;
        }
    }
}
