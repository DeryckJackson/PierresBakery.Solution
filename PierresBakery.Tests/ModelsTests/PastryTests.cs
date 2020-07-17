using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Models.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void CalcPastryPrice_1PastryEquals2() 
    {
      Pastry pastry = new Pastry(1);
      Assert.AreEqual(2, pastry.CalcPastryPrice());
    }

    [TestMethod]
    public void CalcPastryPrice_4PastryEquals7() 
    {
      Pastry pastry = new Pastry(4);
      Assert.AreEqual(7, pastry.CalcPastryPrice());
    }
  }
}