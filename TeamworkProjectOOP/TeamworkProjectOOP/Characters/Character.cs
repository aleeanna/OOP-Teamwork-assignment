namespace TeamworkProjectOOP.Characters
{
    using Interfaces;

    public abstract class Character : ICharacter
    {
        //private int hitPoints;
        //private int attackPoints;
        //private int defensePoints;

        protected Character(int hitPoints, int attackPoints, int defencePoints)
        {
            this.HitPoints = hitPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defencePoints;
        }

        public int HitPoints { get; set; }
        public int AttackPoints { get; set; }
        public int DefensePoints { get; set; }
    }
}
