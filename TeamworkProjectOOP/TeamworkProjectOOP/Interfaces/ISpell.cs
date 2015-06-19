namespace TeamworkProjectOOP.Interfaces
{
    using Interfaces;
    using Enumerations;

    public interface ISpell
    {
        SpellType SpellType { get; set; }

        void Cast(ICharacter character);
    }
}