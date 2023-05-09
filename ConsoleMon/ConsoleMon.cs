using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{

    internal class ConsoleMon
    {
        public int health;
        public int energy;
        string name;

        private List<Skill> skill;


        public void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        public void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }
        
    }

}
