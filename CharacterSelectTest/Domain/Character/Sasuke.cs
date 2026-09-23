using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Sasuke : Entity.Character
{
    public Sasuke(string name) : base(name, CharacterClass.Sasuke)
    {
        Health = 105;
        Strength = 11;
        Intelligence = 14;
        Agility = 16;
    }

    public int Attack()
    {
        return Agility * 3;
    }

    public string SpecialAbility()
    {
        return "Chidori";
    }
}