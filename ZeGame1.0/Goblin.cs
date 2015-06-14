using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeGame1._0
{
    class Goblin : Enemy
    {
        private const int expriencePoints = 60;
        private const int healthPoints = 150;

        public Goblin(string creatureType, int hitPoints, int attackPoints, int defensePoints, int experiencePoints) : base( creatureType,  hitPoints,  attackPoints,  defensePoints,  experiencePoints)
        {
            
        }
    }
}
