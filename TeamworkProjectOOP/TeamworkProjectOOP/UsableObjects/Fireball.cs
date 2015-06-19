namespace TeamworkProjectOOP.UsableObjects
{
    using Interfaces;
    using Enumerations;

    class Fireball : Spell
    {
        public Fireball()
            : base(SpellType.Fireball)
        {
        }

        public override void Cast(ICharacter character)
        {
            character.HitPoints -= 100;
        }
    }
}
