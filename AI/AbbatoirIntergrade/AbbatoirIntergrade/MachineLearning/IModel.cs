using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbatoirIntergrade.MachineLearning
{
    public interface IModel
    {
        void Initialize(int param1, int param2);
        void LearnAll(double[][] input, double[] outputDouble);
        double Predict(double[] input);
        long LastLearnTime { get; }
    }
}
