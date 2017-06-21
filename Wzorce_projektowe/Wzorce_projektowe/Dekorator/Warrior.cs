using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Dekorator
{
    /// <summary>
    /// Klasa wojownika przetrzymująca informacje o standardowym wojowniku
    /// </summary>
    class Warrior : Person
    {
        /// <summary>
        /// Kontruktor klasy Wojownik, którym tworzymy obiekt
        /// </summary>
        public Warrior()
        {
            person = "Warrior";
        }
        /// <summary>
        /// Nadpisana metoda virtualna zwracająca podstawową wartość ataku wojownika
        /// </summary>
        /// <returns></returns>
        public override int attackPower()
        {
            return 100;
        }
    }
}
