using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Builder
{
    /// <summary>
    /// Klasa odpowiedzalna za nekromante
    /// </summary>
    class Necromancer : SourcerBuilder
    {
        public override void colorOfRobesPlayer()
        {
            sourcer.colorOfRobes = "Black";
        }

        public override void spellBookPlayer()
        {
            sourcer.spellBookName = "Necromancy magic book";
        }

        public override void spellSchoolPlayer()
        {
            sourcer.spellSchoolName = "Necromancy";
        }
    }
}
