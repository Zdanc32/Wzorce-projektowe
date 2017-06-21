using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Dekorator
{
    /// <summary>
    /// Abstrakcyjna klasa osoby, która trzyma informacje o postaci
    /// </summary>
    abstract class Person
    {
        protected string person = "Postac";
        /// <summary>
        /// Virutalna metoda, która wykorzystywana jest przez klasy w celu wyświetlnia informacji o postaciach
        /// </summary>
        /// <returns></returns>
        virtual public string about()
        {
            return person;
        }
        /// <summary>
        /// Abstrakcyjna metoda, w której to inne klasy nadają wartości ataku u postaci
        /// </summary>
        /// <returns></returns>
        public abstract int attackPower();
    }
}
