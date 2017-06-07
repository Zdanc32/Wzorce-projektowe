using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Builder
{
    class FrostMage : SourcerBuilder
    {
        public override void colorOfRobesPlayer()
        {
            sourcer.colorOfRobes = "Blue";
        }

        public override void spellBookPlayer()
        {
            sourcer.spellBookName = "Frost magic book";
        }

        public override void spellSchoolPlayer()
        {
            sourcer.spellSchoolName = "Frost";
        }
    }
}
