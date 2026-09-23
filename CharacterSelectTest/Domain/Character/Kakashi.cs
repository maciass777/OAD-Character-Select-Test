using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Kakashi : Entity.Character
{
    public Kakashi(string name) : base(name, CharacterClass.Kakashi)
    {
        Health = 110;
        Strength = 10;
        Intelligence = 17;
        Agility = 14;
    }

    public int Attack()
    {
        return Intelligence * 3;
    }

    public string SpecialAbility()
    {
        return "Raikiri";
    }
}