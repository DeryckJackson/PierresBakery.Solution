using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Models.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CalcBreadPrice_1BreadEquals5()
    {
      Bread bread = new Bread(1);
      Assert.AreEqual(5, bread.CalcBreadPrice());
    }

    [TestMethod]
    public void CalcBreadPrice_3BreadEquals10()
    {
      Bread bread = new Bread(3);
      Assert.AreEqual(10, bread.CalcBreadPrice());
    }
  }
}