using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Performance;

namespace AbbatoirIntergrade.GameClasses.Interfaces
{
    public interface IBuildButton
    {
        bool IsEnabled { get; }
        IEntityFactory BuildingFactory { get; }
        Type BuildingType { get; }

    }
}
