using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("We have the following deals:");
      Console.WriteLine("Loafs of bread are $5 each. Buy 2 get 1 Free.");
      Console.WriteLine("Pastries are $2 each or 3 for $5.");
      Console.WriteLine("Enter how many loafs of bread you wish to purchase:");
      string numOfLoafs = Console.ReadLine();
      Bread newBread = new Bread(numOfLoafs);
      Console.WriteLine("Enter the amount of pastries you wish to purchase:");
      string numOfPastries = Console.ReadLine();
      Pastry newPastry = new Pastry(numOfPastries);
      Console.WriteLine("Your order total will be $" + (newBread.Price + newPastry.Price));
      Console.WriteLine("Would you like to continue shopping? Y/N");
      string answer = Console.ReadLine();
      if (answer == "Y" || answer == "y")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye");
      }
    }
  }
}