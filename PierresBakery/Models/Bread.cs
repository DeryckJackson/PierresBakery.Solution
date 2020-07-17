using System;

namespace Models
{
  public static class Bread
  {
    public static int CalcBreadPrice(int bread) 
    {
      int price = bread * 5;
      return price;
    }
  }
}