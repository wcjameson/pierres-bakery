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
      Pastry testPastry = new Pastry("5");
      Assert.AreEqual(5, testPastry.Price);
    }
    [TestMethod]
    public void CalculatePastryPrice_TallyPastryPriceIfPastriesAmountIsOneOrTwo_PastryPrice()
    {
      Pastry bakedPastry = new Pastry("2");
      Assert.AreEqual(4, bakedPastry.Price);
    }
  
  }
}