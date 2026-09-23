using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Naruto : Entity.Character
{
    public Naruto(string name) : base(name, CharacterClass.Naruto)
    {
        Health = 125;
        Strength = 14;
        Intelligence = 9;
        Agility = 13;
    }

    public int Attack()
    {
        return Strength * 3;
    }

    public string SpecialAbility()
    {
        return "Rasengan";
    }
}