using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeGame1._0
{
    class Kikimora : Enemy
    {
        private const int expriencePoints = 40;
        private const int healthPoints = 80;

        public Kikimora(string creatureType, int hitPoints, int attackPoints, int defensePoints, int experiencePoints) : base( creatureType,  hitPoints,  attackPoints,  defensePoints,  experiencePoints)
        {
            
        }
    }
}
