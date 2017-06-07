using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Builder
{
    class FireMage : SourcerBuilder
    {

        public override void colorOfRobesPlayer()
        {
            sourcer.colorOfRobes = "Red";
        }

        public override void spellBookPlayer()
        {
            sourcer.spellBookName = "Fire magic book";
        }

        public override void spellSchoolPlayer()
        {
            sourcer.spellSchoolName = "Fire";
        }
    }
}
