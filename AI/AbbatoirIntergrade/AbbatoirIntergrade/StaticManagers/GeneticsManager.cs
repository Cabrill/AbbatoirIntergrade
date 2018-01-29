using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Genetic;

namespace AbbatoirIntergrade.StaticManagers
{
    class GeneticsManager
    {
        private ISelectionMethod SelectionMethod;

        private List<IChromosome> ChickenChromosomes;
        private List<IChromosome> PigChromosomes;
        private List<IChromosome> RabbitChromosomes;
        private List<IChromosome> SheepChromosomes;
        private List<IChromosome> CowChromosomes;

        public void Initialize()
        {
            //SelectionMethod.
        }
    }
}
