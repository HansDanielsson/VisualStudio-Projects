using System;

namespace ConsoleApplication1
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] intal = { 1, 2, 3, 4, 5, 6, 7 };
      Console.WriteLine("Skriv in ett tal: ");
      try
      {
        string str = Console.ReadLine();
        Console.WriteLine();
        int s = int.Parse(str);
        for (int i = 0; i < s; i++)
        {
          Console.WriteLine("Talet = " + i);
        }
        Console.WriteLine("Sträng och värde: {0}, {1}", str, s);
        switch (s == 10)
        {
          case true:
            Console.WriteLine("Ett");
            break;
          default:
            Console.WriteLine("Annat");
            break;
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}