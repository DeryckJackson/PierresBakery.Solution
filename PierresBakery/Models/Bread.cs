using System;

namespace Models
{
  public class Bread
  {
    public int bread { get; set; }

    public Bread(int Bread)
    {
      bread = Bread;
    }

    public int CalcBreadPrice() 
    {
      int price = 0;
      if (this.bread % 2 == 0)
      {
        price = (this.bread / 2) * 5; 
      }
      else
      {
        price = (this.bread / 2) * 5 + 5;
      }
      return price;
    }
  }
}