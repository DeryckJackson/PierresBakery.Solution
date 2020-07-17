using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Models.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void CalcPastryPrice_OnePastryEqualsTwo() 
    {
      Pastry pastry = new Pastry(1);
      Assert.AreEqual(2, pastry.CalcPastryPrice());
    }

    [TestMethod]
    public void CalcPastryPrice_FourPastryEqualsSeven() 
    {
      Pastry pastry = new Pastry(4);
      Assert.AreEqual(7, pastry.CalcPastryPrice());
    }

    [TestMethod]
    public void CalcPastryPrice_FivePastryEqualsNine() 
    {
      Pastry pastry = new Pastry(5);
      Assert.AreEqual(9, pastry.CalcPastryPrice());
    }
  }
}