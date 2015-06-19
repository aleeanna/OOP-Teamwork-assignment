namespace TeamworkProjectOOP.Characters
{
    using Enumerations;

    class Kikimora : Enemy
    {
        private const CreatureType creatureType = CreatureType.Kikimora;
        private const int kikimoraExpriencePoints = 60;
        private const int kikimoraHitPoints = 150;
        private const int kikimoraAttackPoints = 50;
        private const int kikimoraDefencePoints = 50;

        public Kikimora()
            : base(creatureType, kikimoraHitPoints, kikimoraAttackPoints, kikimoraDefencePoints, kikimoraExpriencePoints)
        {

        }
    }
}