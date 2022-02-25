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
    public void CalculateBreadPrice_ConvertStringToInt_Price()
    {
      
      Bread newBread = new Bread("3");
      Assert.AreEqual(3, newBread.Price);
    }
  }
}