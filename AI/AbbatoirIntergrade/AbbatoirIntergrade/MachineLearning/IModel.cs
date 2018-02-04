using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbatoirIntergrade.MachineLearning
{
    public interface IModel
    {
        void Initialize();
        void LearnAll(WaveData waveData);
        double Predict(double[] input);
        long LastLearnTime { get; }
        bool IsReady { get; }

        bool Save(string fileName);
        bool Load(string fileName);
    }
}
