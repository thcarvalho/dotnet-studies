using System;

namespace principles
{
  class Program
  {
    static void Main(string[] args)
    {
      //declarations
      int num = 1;
      const int num2 = 2;
      int sum = num2 + num;

      Console.WriteLine(sum);

      if (sum < 5)
      {
        //String Interpolation
        Console.WriteLine($"Soma: {sum}");
      }

      int[] arr = { 1, 2, 4, 5, 6 };

      //for and foreach
      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine($"for padrão {arr[i]}");
      }

      foreach (int item in arr)
      {
        Console.WriteLine($"foreach {item}");
      }
      divideNumbers();
    }

    static double divide(double x, double y)
    {
      if (y == 0)
      {
        throw new DivideByZeroException();
      }

      return x / y;
    }

    static void divideNumbers()
    {
      double x = 3;
      double y = 2;

      try
      {
        if (x == 0 || y == 0)
        {
          throw new InvalidOperationException();
        }
        Console.WriteLine(divide(x, y));
      }
      catch (InvalidOperationException e)
      {
        Console.WriteLine(e.Message);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }

    }
  }
}
