using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_projektowe.FactoryMethod
{
    abstract class Creator
    {
        private List<Skill> skills = new List<Skill>();

        // Constructor calls abstract Factory method
        public Creator()
        {
            this.createSkill();
        }

        public List<Skill> Skills
        {
            get { return skills; }
        }

        // Factory Method
        public abstract void createSkill();
    }
}
