using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Models.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CalcBreadPrice_OneBreadEqualsfive() 
    {
      Assert.AreEqual(5, Bread.CalcBreadPrice(1));
    }
  }
}