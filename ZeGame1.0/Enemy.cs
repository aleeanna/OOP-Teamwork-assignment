using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeGame1._0
{
    public abstract class Enemy
    {
        protected Enemy(string creatureType, int hitPoints, int attackPoints, int defensePoints, int experiencePoints)
        {
            this.CreatureType = creatureType;
            this.HitPoints = hitPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.ExperiencePoints = experiencePoints;
        }

        public int ExperiencePoints { get; set; }

        public int DefensePoints { get; set; }

        public int AttackPoints { get; set; }

        public int HitPoints { get; set; }

        public string CreatureType { get; set; }
    }
}
