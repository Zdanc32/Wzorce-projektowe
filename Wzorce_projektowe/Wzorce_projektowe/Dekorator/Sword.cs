using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Dekorator
{
    /// <summary>
    /// Obiekt miecza 
    /// </summary>
    class Sword : Decorator
    {
        Person person;
        /// <summary>
        /// Konstruktor, który przypisuje osobie nowy obiekt miecza.
        /// </summary>
        /// <param name="person"></param>
        public Sword(Person person)
        {
            this.person = person;
        }
        /// <summary>
        /// Nadpisana metoda z klasy Person, która ma za zadanie wyświetlać informacje o postaci
        /// </summary>
        /// <returns></returns>
        public override string about()
        {
            return person.about() + " sword";
        }
        /// <summary>
        /// Nadpisana metoda abstrakcyjna, której zadaniem jest zwiekszanie ataku wojownika w zależności od jego wyszkolenia
        /// </summary>
        /// <returns></returns>
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
