using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Dekorator
{
    class Warrior : Person
    {
        public Warrior()
        {
            person = "Warrior";
        }
        public override int attackPower()
        {
            return 100;
        }
    }
}
