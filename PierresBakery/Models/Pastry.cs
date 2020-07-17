using System;
using Models;

namespace Models
{
  public class Pastry
  {
    public int numPastries { get; set; }

    public Pastry(int pastry) 
    {
      numPastries = pastry;
    }

    public int CalcPastryPrice()
    {
      int price = 0;
      if (numPastries % 12 == 0)
      {
        price = (numPastries / 12) * 18;
      }
      else if (numPastries % 3 == 0)
      {
        price = (numPastries / 3) * 5;
      }
      else if (numPastries % 3 == 1) 
      {
        price = (numPastries / 3) * 5 + 2;
      }
      else 
      {
        price = (numPastries / 3) * 5 + 4;
      }
      return price;
    }
  }
}