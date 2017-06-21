using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Dekorator
{
    /// <summary>
    /// Klasa odpowiedzialna za przetrzymywanie informacji o Elitarnym wojowniku
    /// </summary>
    class EliteWarrior : Person
    {
        /// <summary>
        /// Metoda towrząca elitarnego wojownika
        /// </summary>
        public EliteWarrior()
        {
            person = "Elite Warrior";
        }
        /// <summary>
        /// Metoda nadająca paramtetry startowe ataku dla elitarnego wojownika
        /// </summary>
        /// <returns></returns>
        public override int attackPower()
        {
            return 120;
        }
    }
}
