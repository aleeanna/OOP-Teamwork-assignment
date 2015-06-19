namespace TeamworkProjectOOP.Interfaces
{
    using Enumerations;

    public interface IEnemy : ICharacter
    {
        CreatureType CreatureType { get; }
        int Experience { get; }
    }
}
