using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_InstantiatesBread_BreadObject()
    {
      Bread testBread = new Bread("3");
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
    [TestMethod]
    public void CalculateBreadPrice_ConvertStringToIntTallyBreadPrice_Price()
    {

      Bread newBread = new Bread("0");
      Assert.AreEqual(0, newBread.Price);
    }
    [TestMethod]
    public void CalculateBreadPrice_TallyBreadPriceIfLoafsEqualsOne_Price()
    {

      Bread newBread1 = new Bread("1");
      Assert.AreEqual(5, newBread1.Price);
    }
    [TestMethod]
    public void CalculateBreadPrice_TallyBreadPriceIfLoafsEqualsTwo_Price()
    {

      Bread newBread2 = new Bread("2");
      Assert.AreEqual(10, newBread2.Price);
    }
    [TestMethod]
    public void CalculateBreadPrice_TallyBreadPriceIfLoafsEqualsFour_BreadPrice()
    {
      Bread loaf = new Bread("4");
      Assert.AreEqual(15, loaf.Price);
    }
    [TestMethod]
    public void CalculateBreadPrice_TallyBreadPriceIfLoafsRemainderZero_BreadPrice()
    {
      Bread loaf = new Bread("3");
      Assert.AreEqual(10, loaf.Price);
    }
    [TestMethod]
    public void CalculateBreadPrice_TallyBreadPriceIfRemainderOne_BreadPrice()
    {
      Bread newLoaf = new Bread("16");
      Assert.AreEqual(70, newLoaf.Price);
    }
    [TestMethod]
    public void CalculateBreadPrice_TallyBreadPriceIfRemainderTwo_BreadPrice()
    {
      Bread anotherLoaf = new Bread("17");
      Assert.AreEqual(80, anotherLoaf.Price);
    }
  }
}