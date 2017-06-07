using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Strategy
{
    class StrategyMethodA : Strategy
    {
        public override string doSomething()
        {
            return "Strategia A";
        }
    }
}
