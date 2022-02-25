using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter how many loafs of bread you wish to purchase");
      string numOfLoafs = Console.ReadLine();
      Bread newBread = new Bread(numOfLoafs);
      Console.WriteLine("Enter the amount of pastries you wish to purchase");
      string numOfPastries = Console.ReadLine();
      Pastry newPastry = new Pastry(numOfPastries);
      Console.WriteLine("Your order total will be $" + (newBread.Price + newPastry.Price));
    }
  }
}