namespace TeamworkProjectOOP.Characters
{
    public class Warrior : PlayableCharacter
    {
        private const int warriorHitPoints = 150;
        private const int warriorAttackPoints = 100;
        private const int warriorDefencePoints = 100;

        public Warrior(string name)
            : base(name, warriorHitPoints, warriorAttackPoints, warriorDefencePoints)
        {
        }
    }
}
