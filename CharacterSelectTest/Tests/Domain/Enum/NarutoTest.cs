using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character;

[TestClass]
public class NarutoTest
{
    [TestMethod]
    public void TestNarutoCreation()
    {
        var naruto = new Naruto("Naruto");

        Assert.IsNotNull(naruto);
    }

    [TestMethod]
    public void TestNarutoStats()
    {
        var naruto = new Naruto("Naruto");

        Assert.AreEqual(125, naruto.Health);
        Assert.AreEqual(14, naruto.Strength);
        Assert.AreEqual(9, naruto.Intelligence);
        Assert.AreEqual(13, naruto.Agility);
    }

    [TestMethod]
    public void TestNarutoAttack()
    {
        var naruto = new Naruto("Naruto");

        Assert.AreEqual(42, naruto.Attack());
    }

    [TestMethod]
    public void TestNarutoSpecialAbility()
    {
        var naruto = new Naruto("Naruto");

        Assert.AreEqual("Rasengan", naruto.SpecialAbility());
    }
}