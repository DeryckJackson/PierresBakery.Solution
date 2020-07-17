using System;

namespace Models
{
  public static class Bread
  {
    public static int CalcBreadPrice(int bread) 
    {
      int price = 0;
      if (bread % 2 == 0)
      {
        price = (bread / 2) * 5; 
      }
      else
      {
        price = (bread / 2) * 5 + 5;
      }
      return price;
    }
  }
}