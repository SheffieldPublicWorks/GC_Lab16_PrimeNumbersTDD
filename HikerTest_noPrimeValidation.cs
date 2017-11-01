
using NUnit.Framework;

[TestFixture]
public class HikerTest
{
    [Test]
    public void Case1()
    {
        // a simple example to start you off
        Assert.AreEqual("The number 1 prime is 2", Hiker.PrimeNumLookUp(1));
    }
    
    [Test]
    public void Case2()
    {
        // a simple example to start you off
        Assert.AreEqual("The number 46 prime is 199", Hiker.PrimeNumLookUp(46));
    }
}
