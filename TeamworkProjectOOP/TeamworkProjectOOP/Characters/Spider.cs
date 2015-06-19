namespace TeamworkProjectOOP.Characters
{
    using Enumerations;

    class Spider : Enemy
    {
        private const CreatureType creatureType = CreatureType.Spider;
        private const int spiderExpriencePoints = 20;
        private const int spiderHitPoints = 50;
        private const int spiderAttackPoints = 50;
        private const int spiderDefencePoints = 50;

        public Spider()
            : base(creatureType, spiderHitPoints, spiderAttackPoints, spiderDefencePoints, spiderExpriencePoints)
        {

        }
    }
}