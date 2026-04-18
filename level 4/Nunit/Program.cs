using NUnit.Framework;

[TestFixture]
public class TestClass
{
    [Test]
    public void Add_Test()
    {
        Assert.AreEqual(5, 2 + 3);
    }
}