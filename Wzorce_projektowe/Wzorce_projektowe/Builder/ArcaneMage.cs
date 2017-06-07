using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Builder
{
    class ArcaneMage : SourcerBuilder
    {
        public override void colorOfRobesPlayer()
        {
            sourcer.colorOfRobes = "Grey";
        }

        public override void spellBookPlayer()
        {
            sourcer.spellBookName = "Arcane magic book";
        }

        public override void spellSchoolPlayer()
        {
            sourcer.spellSchoolName = "Arcane";
        }
    }
}
