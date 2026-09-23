using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character;

[TestClass]
public class SasukeTest
{
    [TestMethod]
    public void TestSasukeCreation()
    {
        var sasuke = new Sasuke("Sasuke");

        Assert.IsNotNull(sasuke);
    }

    [TestMethod]
    public void TestSasukeStats()
    {
        var sasuke = new Sasuke("Sasuke");

        Assert.AreEqual(105, sasuke.Health);
        Assert.AreEqual(11, sasuke.Strength);
        Assert.AreEqual(14, sasuke.Intelligence);
        Assert.AreEqual(16, sasuke.Agility);
    }

    [TestMethod]
    public void TestSasukeAttack()
    {
        var sasuke = new Sasuke("Sasuke");

        Assert.AreEqual(48, sasuke.Attack());
    }

    [TestMethod]
    public void TestSasukeSpecialAbility()
    {
        var sasuke = new Sasuke("Sasuke");

        Assert.AreEqual("Chidori", sasuke.SpecialAbility());
    }
}