using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeGame1._0
{
    class Spider : Enemy
    {
        private const int expriencePoints = 50;
        private const int healthPoints = 100;

        public Spider(string creatureType, int hitPoints, int attackPoints, int defensePoints, int experiencePoints) : base( creatureType,  hitPoints,  attackPoints,  defensePoints,  experiencePoints)
        {
            
        }
    }
}
