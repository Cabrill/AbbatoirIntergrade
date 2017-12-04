using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbatoirIntergrade.GameClasses.BaseClasses
{
    public abstract class BaseWave
    {
        public double WaveStartTime { get;  }
        public int PointValue { get; }
        public bool HasDialogue { get; }
    }
}
