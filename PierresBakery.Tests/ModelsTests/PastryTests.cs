using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Models.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void CalcPastryPrice() 
    {
      Pastry pastry = new Pastry(1);
      Assert.AreEqual(2, pastry.CalcPastryPrice());
    }
  }
}