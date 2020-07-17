using System;
using Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("   _______");
      Console.WriteLine("  /       )");
      Console.WriteLine(" /_____   |");
      Console.WriteLine("(  '   ) /");
      Console.WriteLine(" |.  '| / ");
      Console.WriteLine(" |____|/  \n");

      Console.WriteLine("A loaf of bread is $5 for one or Buy one get one free.");
      Console.WriteLine("A pastry is $2 for one or 3 for $5 or 12 for $18.\n");
      try
      {
        Console.WriteLine("How many loafs of bread would you like?");
        int loafs = int.Parse(Console.ReadLine());

        Console.WriteLine("How many pastries would you like?");
        int pastries = int.Parse(Console.ReadLine());

        Bread newBreadOrder = new Bread(loafs);
        int breadPrice = newBreadOrder.CalcBreadPrice();
        Pastry newPastryOrder = new Pastry(pastries);
        int pastryPrice = newPastryOrder.CalcPastryPrice();
        
        Console.WriteLine($"Your order total comes to ${breadPrice + pastryPrice}.");
        Console.WriteLine("Have a great day!");
      }
      catch
      {
        Console.WriteLine("Oops! Please only enter numbers. Please try again.");
        Main();
      }
    }
  }
}