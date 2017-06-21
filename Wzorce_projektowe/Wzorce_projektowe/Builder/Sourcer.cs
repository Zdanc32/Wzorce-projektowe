using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Builder
{
    /// <summary>
    /// Obiekt maga, ktory przetrzymuje publiczne wartosci maga
    /// </summary>
    public class Sourcer
    {
        public string name { get; set; }
        public string level { get; set; }
        public string spellBookName { get; set; }
        public string spellSchoolName { get; set; }
        public string colorOfRobes { get; set; }
        public void showMage()
        {
            Console.WriteLine("\nYour Name: \t" + name 
                + "\nYour level: \t" + level 
                + "\nYour Spell book name: \t" + spellBookName 
                + "\nYour Spell school name: " + spellSchoolName 
                + "\nColor of your Robes: \t" + colorOfRobes);
        }
    }
}
