using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Models.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CalcBreadPrice_1BreadEquals5()
    {
      Assert.AreEqual(5, Bread.CalcBreadPrice(1));
    }

    [TestMethod]
    public void CalcBreadPrice_3BreadEquals10()
    {
      Assert.AreEqual(10, Bread.CalcBreadPrice(3));
    }
  }
}