using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassDemoKlasDiagrammen2.Core
{
    public class CarAggregatie
    {
        public Engine Engine { get; set; }
        public CarAggregatie(Engine engine)
        {
            Engine = engine;
        }
    }
}
