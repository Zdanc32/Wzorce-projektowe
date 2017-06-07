using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Dekorator jest powszechnie używany do dodawania nowych funkcjonalnosci dla klas w celu ich rozszerzenia 
/// zamiast dopisywac nowe metody do klas wystarczy stworzyc klase, ktora bedzie dziedziczona przez inne klasy rozszerzajace.
/// </summary>
namespace Wzorce_projektowe.Dekorator
{
    abstract class Decorator : Person
    {
        public abstract override string about();
    }
}

