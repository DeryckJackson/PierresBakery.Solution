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
      int price = numPastries * 2;
      return price;
    }
  }
}