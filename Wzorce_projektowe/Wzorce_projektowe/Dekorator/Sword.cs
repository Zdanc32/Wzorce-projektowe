using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Dekorator
{
    class Sword : Decorator
    {
        Person person;
        public Sword(Person person)
        {
            this.person = person;
        }
        public override string about()
        {
            return person.about() + " sword";
        }

        public override int attackPower()
        {
            if(person is EliteWarrior)
            {
                return person.attackPower() + 70;
            }
            if(person is Warrior)
            {
                return person.attackPower() + 50;
            }
            return 0;
        }
    }
}
