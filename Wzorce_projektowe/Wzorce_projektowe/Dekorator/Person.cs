using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Dekorator
{
    abstract class Person
    {
        protected string person = "Postac";
        virtual public string about()
        {
            return person;
        }
        public abstract int attackPower();
    }
}
