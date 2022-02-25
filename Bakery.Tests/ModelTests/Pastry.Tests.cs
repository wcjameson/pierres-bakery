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
      Pastry testPastry = new Pastry("0");
      Assert.AreEqual(0, testPastry.Price);
    }
    [TestMethod]
    public void CalculatePastryPrice_TallyPastryPriceIfPastriesAmountIsOneOrTwo_PastryPrice()
    {
      Pastry bakedPastry = new Pastry("2");
      Assert.AreEqual(4, bakedPastry.Price);
    }
    [TestMethod]
      public void CalculatePastryPrice_TallyPastryPriceIfRemainderIs0_PastryPrice()
    {
      Pastry anotherPastry = new Pastry("3");
      Assert.AreEqual(5, anotherPastry.Price);
    }
    [TestMethod]
    public void CalculatePastryPrice_TallyPriceIfRemainderIs1_PastryPrice()
    {
      Pastry morePastry = new Pastry("4");
      Assert.AreEqual(7, morePastry.Price);
    }
    [TestMethod]
    public void CalculatePastryPrice_TallyPriceIfRemainderIs2_PastryPrice()
    {
      Pastry lastPastry = new Pastry("5");
      Assert.AreEqual(9, lastPastry.Price);
    }
  
  }
}