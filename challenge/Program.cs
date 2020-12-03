using System;

namespace desafio
{
  class Desafio
  {
    static void Main()
    {
      int limit;
      if (!Int32.TryParse(Console.ReadLine(), out limit))
      {
        Console.WriteLine("divisão impossivel");
      }
      else
      {
        if (limit <= 0)
        {
          Console.WriteLine("divisão impossivel");
        }
        else
        {
          for (int i = 0; i < limit; i++)
          {
            string[] line = Console.ReadLine().Split(" ");
            double X;
            double Y;

            if (!double.TryParse(line[0], out X) || !double.TryParse(line[1], out Y))
            {
              Console.WriteLine("divisão impossivel");
            }
            else
            {
              // double X = double.Parse(line[0]);
              // double Y = double.Parse(line[1]);
              if ((X.Equals("")) || (Y.Equals("")))
              {
                Console.WriteLine("divisão impossivel");
              }
              else
              {
                if (Y == 0)
                {
                  Console.WriteLine("divisao impossivel");
                }
                else
                {
                  // if (X typeof double && Y typeof double) 
                  // {
                  double divisao = X / Y; // Digite aqui o calculo da divisao
                  Console.WriteLine(divisao.ToString("N1"));
                  // }  
                }
              }
            }
          }
        }
      }
    }
  }
}
