using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbatoirIntergrade.MachineLearning
{
    [Serializable]
    public class WaveData
    {
        public List<double[]> WaveInputs;
        public List<double> WaveScores;
    }
}
