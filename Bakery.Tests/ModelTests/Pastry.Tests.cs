using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_InstantiatesPastry_PastryObject()
    {
    Pastry newPastry = new Pastry("3");
    Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void CalculatePastryPrice_ConvertsStringToInteger_Integer()
    {
      Pastry testPastry = new Pastry("10");
      Assert.AreEqual(10, testPastry.Price);
    }
  
  }
}