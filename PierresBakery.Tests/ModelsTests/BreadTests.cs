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

    [TestMethod]
    public void CalcBreadPrice_ThreeBreadEqualsTen()
    {
      Assert.AreEqual(10, Bread.CalcBreadPrice(3));
    }
  }
}