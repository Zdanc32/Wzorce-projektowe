using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Dekorator
{
    class EliteWarrior : Person
    {
        public EliteWarrior()
        {
            person = "Elite Warrior";
        }
        public override int attackPower()
        {
            return 120;
        }
    }
}
