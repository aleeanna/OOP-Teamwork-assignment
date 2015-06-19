namespace TeamworkProjectOOP.UsableObjects
{
    using Enumerations;
    using Interfaces;

    public abstract class Spell : ISpell
    {
        protected Spell(SpellType spellType)
        {
            this.SpellType = spellType;
        }

        public SpellType SpellType { get; set; }

        public abstract void Cast(ICharacter character);
    }
}