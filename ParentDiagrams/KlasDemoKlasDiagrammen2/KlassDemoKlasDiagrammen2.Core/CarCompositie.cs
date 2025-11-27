using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassDemoKlasDiagrammen2.Core
{
    public class CarCompositie
    {
        public Engine Engine { get; set; }
        public CarCompositie()
        {
            Engine = new Engine();
        }
    }
}
