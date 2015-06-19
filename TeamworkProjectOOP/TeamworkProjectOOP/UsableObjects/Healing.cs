namespace TeamworkProjectOOP.UsableObjects
{
    using Interfaces;
    using Enumerations;

    class Healing : Spell
    {
        public Healing()
            : base(SpellType.Healing)
        {
        }

        public override void Cast(ICharacter character)
        {
            character.HitPoints += 100;
        }
    }
}
