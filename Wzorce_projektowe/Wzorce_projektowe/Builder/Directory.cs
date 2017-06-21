using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Wzorzec projektowy Budowniczy (ang. Builder) wykorzystujemy w celu konstrukcji 
/// skomplikowanych obiektów z zachowaniem kolejności tworzenia ich składników. 
/// Podstawowym elementem mechanizmu jest interfejs Budowniczy udostępniający metody budowy składowych końcowego produktu. 
/// Dziedziczą po nim Konkretni budowniczowie decydujący o tym jak dokładnie dany produkt będzie tworzony. 
/// Całość procesu kontroluje Nadzorca uruchamiający metody budowniczego w odpowiedniej kolejności.
/// posłużmy się przykładem z gier RPG D&D
/// Mamy czarownika ze określonej szkoły magii np ognia, lodu, mistycznej, nekromancji
/// ale nie chcemy implementować do niego wszystkich funkcji za każdym razem, więc skorzystamy z interfejsu, który nazwiemy builder.
/// Zawierać w sobie będzie metody dla kracza takie jak:
///     nadanie_imienia
///     wybranie_szkoły_magii
///     pobranie_szkoły_magii
///     
/// </summary>

namespace Wzorce_projektowe.Builder
{
    /// <summary>
    /// Klasa dekoratora odpowiedzalna za budowanie obiektow
    /// </summary>
    class Directory
    {

        private SourcerBuilder sourcerBuilder;

        public Directory(SourcerBuilder aBuilder)
        {
            sourcerBuilder = aBuilder;
        }

        public void createMage()
        {
            sourcerBuilder.CreateSourcer();
            sourcerBuilder.spellBookPlayer();
            sourcerBuilder.spellSchoolPlayer();
            sourcerBuilder.colorOfRobesPlayer();
        }

        public Sourcer getMage()
        {
            return sourcerBuilder.getSourcer();
        }
    }
}
