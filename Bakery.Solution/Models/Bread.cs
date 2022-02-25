using System;

namespace Bakery.Models
{
  public class Bread
  {
    public string BreadAmount { get; set; }
    public int Price { get; set; }

    public Bread(string breadAmount)
    {
      BreadAmount = breadAmount;
      Price = CalculateBreadPrice(breadAmount);
    }

    private int CalculateBreadPrice(string breadAmount)
    {
      int numberOfLoafs = int.Parse(breadAmount);
      // return numberOfLoafs;
      if (numberOfLoafs == 1)
      {
        return 5;
      }
      else if (numberOfLoafs == 2)
      {
        return 10;
      }
      else if (numberOfLoafs % 3 == 0)
      {
        int discountedLoafs = numberOfLoafs / 3; 
        return (numberOfLoafs - discountedLoafs) * 5;
      }
      else if (numberOfLoafs % 3 == 1)
      {
        return (numberOfLoafs * 5) - 10;
      }
      else if (numberOfLoafs % 3 == 2)
      {
        return (numberOfLoafs * 5) - 5;
      }
      else
      {
        return numberOfLoafs;
      }
    }
  }
}