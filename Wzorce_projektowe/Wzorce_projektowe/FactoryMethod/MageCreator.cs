using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.FactoryMethod
{
    /// <summary>
    /// Utworzenie Maga ktory dziedziczy z kreatora
    /// </summary>
    class MageCreator : Creator
    {
        public override void createSkill()
        {
            Skills.Add(new IceBlockSkill());
            Skills.Add(new CastFireBoltSkill());
        }
    }
}
