using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public string PastryAmount { get; set; }
    public int Price { get; set; }

    public Pastry(string pastryAmount)
    {
      PastryAmount = pastryAmount;
      Price = CalculatePastryPrice(pastryAmount);
    }

    private int CalculatePastryPrice(string pastryAmount)
    {
      int numberOfPastries = int.Parse(pastryAmount);
      // return numberOfPastries;
      if (numberOfPastries == 1 || numberOfPastries == 2)
      {
        return numberOfPastries * 2;
      }
      else
      {
        return numberOfPastries;
      }
    }
  }
}