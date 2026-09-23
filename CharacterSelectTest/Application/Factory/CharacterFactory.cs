using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Application.Factory;

public static class CharacterFactory
{
    public static Domain.Entity.Character Create(CharacterClass cls, string? name)
    {
        return cls switch
        {
            CharacterClass.Warrior => new Warrior(name ?? "Warrior"),
            CharacterClass.Mage => new Mage(name ?? "Mage"),
            CharacterClass.Rogue => new Rogue(name ?? "Rogue"),

            CharacterClass.Naruto => new Naruto(name ?? "Naruto"),
            CharacterClass.Sasuke => new Sasuke(name ?? "Sasuke"),
            CharacterClass.Kakashi => new Kakashi(name ?? "Kakashi"),

            _ => throw new ArgumentOutOfRangeException(
                nameof(cls),
                "Nieznana klasa postaci."
            )
        };
    }
}