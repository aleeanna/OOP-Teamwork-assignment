namespace TeamworkProjectOOP.Characters
{
    using Interfaces;
    using Enumerations;
    using System.Text;

    public abstract class Enemy : Character, IEnemy
    {
        protected Enemy(CreatureType creatureType, int hitPoints, int attackPoints, int defencePoints, int experience)
            : base(hitPoints, attackPoints, defencePoints)
        {
            this.CreatureType = creatureType;
            this.Experience = experience;
        }

        public CreatureType CreatureType { get; set; }
        public int Experience { get; set; }

        public override string ToString()
        {
            StringBuilder creatureSheet = new StringBuilder();

            creatureSheet.AppendLine(string.Format("Enemy name: {0}", this.CreatureType));
            creatureSheet.AppendLine(string.Format("Health: {0}", this.HitPoints));
            creatureSheet.AppendLine(string.Format("Attack: {0}", this.AttackPoints));
            creatureSheet.AppendLine(string.Format("Defence: {0}", this.DefensePoints));

            return creatureSheet.ToString();
        }

        public void Attack(IPlayableCharacter player)
        {
            if (this.AttackPoints > player.DefensePoints)
            {
                player.HitPoints -= this.AttackPoints;
            }
            else
            {
                player.HitPoints -= this.AttackPoints / 2;
            }
        }
    }
}