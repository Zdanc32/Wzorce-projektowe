using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Dekorator
{
    class Shield : Decorator
    {
        Person person;
        public Shield(Person person)
        {
            this.person = person;
        }
        public override string about()
        {
            return person.about() + " shield";
        }

        public override int attackPower()
        {
            return person.attackPower() + 40;
        }
    }
}
