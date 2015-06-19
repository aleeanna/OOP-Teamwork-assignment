namespace TeamworkProjectOOP.Characters
{
    using Enumerations;

    class Goblin : Enemy
    {
        private const CreatureType creatureType = CreatureType.Goblin;
        private const int goblinExpriencePoints = 60;
        private const int goblinHitPoints = 200;
        private const int goblinAttackPoints = 50;
        private const int goblinDefencePoints = 200;

        public Goblin()
            : base(creatureType, goblinHitPoints, goblinAttackPoints, goblinDefencePoints, goblinExpriencePoints)
        {

        }
    }
}