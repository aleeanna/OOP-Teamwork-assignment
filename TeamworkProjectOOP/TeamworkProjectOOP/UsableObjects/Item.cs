namespace TeamworkProjectOOP.UsableObjects
{
    public abstract class Item
    {
        //private int attackPoints;
        //private int defensePoints;

        protected Item(int attackPoints, int defencePoints)
        {
            this.AttackPoints = attackPoints;
            this.DefensePoints = defencePoints;
        }

        public int AttackPoints { get; set; }
        public int DefensePoints { get; set; }
    }
}
