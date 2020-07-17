using System;
using Models;

namespace Models
{
  public class Pastry
  {
    int numPastries { get; set; }

    public Pastry(int Pastry) 
    {
      numPastries = Pastry;
    }

    public int CalcPastryPrice()
    {
      int price = 0;
      if (numPastries % 3 == 0)
      {
        price = (numPastries / 3) * 5;
      }
      else if (numPastries % 3 == 1) 
      {
        price = (numPastries / 3) * 5 + 2;
      }
      else 
      {
        price = 0;
        // price = (numPastries / 3) * 5 + 4;
      }
      return price;
    }
  }
}