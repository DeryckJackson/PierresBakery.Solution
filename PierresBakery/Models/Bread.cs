using System;

namespace Models
{
  public class Bread
  {
    public int numLoafs { get; set; }

    public Bread(int Bread)
    {
      numLoafs = Bread;
    }

    public int CalcBreadPrice() 
    {
      int price = 0;
      if (numLoafs % 2 == 0)
      {
        price = (numLoafs / 2) * 5; 
      }
      else
      {
        price = (numLoafs / 2) * 5 + 5;
      }
      return price;
    }
  }
}