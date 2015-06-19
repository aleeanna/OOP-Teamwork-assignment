namespace TeamworkProjectOOP.Interfaces
{
    using UsableObjects;
    using Interfaces;
    using Enumerations;

    interface IPlayableCharacter : ICharacter
    {
        void Attack(IEnemy enemy);
        void UseSpell(SpellType spell, ICharacter character);
        void AddItem(Item item);
        void AddSpell(ISpell spell);
    }
}
