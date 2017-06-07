using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.FactoryMethod
{
    class WarriorCreator : Creator
    {
        public override void createSkill()
        {
            Skills.Add(new HeroicAttackSkill());
            Skills.Add(new FurySkill());
        }
    }
}
