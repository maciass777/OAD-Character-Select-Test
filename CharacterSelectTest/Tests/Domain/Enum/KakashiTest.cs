using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character;

[TestClass]
public class KakashiTest
{
    [TestMethod]
    public void TestKakashiCreation()
    {
        var kakashi = new Kakashi("Kakashi");

        Assert.IsNotNull(kakashi);
    }

    [TestMethod]
    public void TestKakashiStats()
    {
        var kakashi = new Kakashi("Kakashi");

        Assert.AreEqual(110, kakashi.Health);
        Assert.AreEqual(10, kakashi.Strength);
        Assert.AreEqual(17, kakashi.Intelligence);
        Assert.AreEqual(14, kakashi.Agility);
    }

    [TestMethod]
    public void TestKakashiAttack()
    {
        var kakashi = new Kakashi("Kakashi");

        Assert.AreEqual(51, kakashi.Attack());
    }

    [TestMethod]
    public void TestKakashiSpecialAbility()
    {
        var kakashi = new Kakashi("Kakashi");

        Assert.AreEqual("Raikiri", kakashi.SpecialAbility());
    }
}