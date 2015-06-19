namespace TeamworkProjectOOP.Characters
{
    class Mage : PlayableCharacter
    {
        private const int mageHitPoints = 100;
        private const int mageAttackPoints = 50;
        private const int mageDefencePoints = 100;

        public Mage(string name)
            : base(name, mageHitPoints, mageAttackPoints, mageDefencePoints)
        {
        }
    }
}
