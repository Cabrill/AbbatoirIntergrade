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

        private const int Epochs = 50;

        private DeepBeliefNetwork _network;
        private DeepNeuralNetworkLearning _teacher;
        private int _numberOfInputs;
        private int _hiddenLayerNodes;
        private bool _hasTrained;

        public void Initialize(int numberOfInputs, int numberOfHiddenNodes)
        {
            _hasTrained = false;
            _numberOfInputs = numberOfInputs;
            _hiddenLayerNodes = numberOfHiddenNodes;

            _network = new DeepBeliefNetwork(_numberOfInputs, _hiddenLayerNodes, 1);
            new GaussianWeights(_network, 0.1).Randomize();
            _network.UpdateVisibleWeights();

            _teacher = new DeepNeuralNetworkLearning(_network)
            {
                Algorithm = (ann, i) => new ParallelResilientBackpropagationLearning(ann),
                LayerIndex = _network.Layers.Length - 1,
            };
        }

        public void LearnAll(double[][] input, double[] outputDouble)
        {
            var sw = Stopwatch.StartNew();

            // Gather learning data for the layer
            var layerData = _teacher.GetLayerInput(input);

            var outputData = new double[outputDouble.Length][];

            for (var i = 0; i < outputDouble.Length; i++)
            {
                outputData[i] = new[] { outputDouble[i] };
            }

            // Start running the learning procedure
            for (var i = 0; i < Epochs; i++)
            {
                _teacher.RunEpoch(layerData, outputData);
            }
            _network.UpdateVisibleWeights();

            sw.Stop();
            LastLearnTime = sw.ElapsedMilliseconds;
        }

        public double Predict(double[] input)
        {
            var sw = Stopwatch.StartNew();

            var prediction = _network.Compute(input)[0];
            sw.Stop();

            LastPredictTime = sw.ElapsedMilliseconds;

            return prediction;
        }
    }
}
