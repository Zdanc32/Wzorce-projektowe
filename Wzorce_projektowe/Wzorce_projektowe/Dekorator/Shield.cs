using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Dekorator
{
    /// <summary>
    /// Obiekt tarczy, ktory jest dodawany do wojownikow gdy zostanie utworzony. 
    /// </summary>
    class Shield : Decorator
    {
        Person person;
        /// <summary>
        /// Kontruktor przypisujący obiekt tarczy do osoby
        /// </summary>
        /// <param name="person"></param>
        public Shield(Person person)
        {
            this.person = person;
        }
        /// <summary>
        /// Nadpisana metoda virtualna, która wyświetla informacje o osobie
        /// </summary>
        /// <returns></returns>
        public override string about()
        {
            return person.about() + " shield";
        }
        /// <summary>
        /// Nadpisana metoda abstrakcyjna, która zwiększa atak wojownika.
        /// </summary>
        /// <returns></returns>
        public override int attackPower()
        {
            return person.attackPower() + 40;
        }
    }
}
