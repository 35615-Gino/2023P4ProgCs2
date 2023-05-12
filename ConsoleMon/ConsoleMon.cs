using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{

    internal class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name;

        private List<Skill> skill;

        internal Element weakness;
        

        internal void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }

        public ConsoleMon()
        {

        }

        internal ConsoleMon(int health, int energy, string name, Element weakness)
        {
            //opdracht 13
            this.energy= energy;
            this.name= name;
            this.weakness= weakness;
            this.health= health;

        }
    }
}
