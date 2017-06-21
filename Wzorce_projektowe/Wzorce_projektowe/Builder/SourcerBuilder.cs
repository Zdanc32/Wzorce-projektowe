using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.Builder
{
    /// <summary>
    /// Budowniczy maga jest odpowiedzalna za budowanie każdego z magow Ognia, Lodu, Arcana i Nekromanty
    /// </summary>
    public abstract class SourcerBuilder
    {
        protected Sourcer sourcer;
        public void CreateSourcer()
        {
            sourcer = new Sourcer();
        }
        public Sourcer getSourcer()
        {
            return sourcer;
        }
        public abstract void spellBookPlayer();
        public abstract void spellSchoolPlayer();
        public abstract void colorOfRobesPlayer();
    }
}
