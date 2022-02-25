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
    public void CalculateBreadPrice_TallyBreadPriceIfRemainder1_BreadPrice()
    {
      Bread newLoaf = new Bread("16");
      Assert.AreEqual(70, newLoaf.Price);
    }
    [TestMethod]
    public void CalculateBreadPrice_TallyBreadPriceIfRemainder2_BreadPrice()
    {
      Bread anotherLoaf = new Bread("17");
      Assert.AreEqual(80, anotherLoaf.Price);
    }
  }
}