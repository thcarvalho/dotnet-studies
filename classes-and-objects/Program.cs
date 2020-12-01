using System;
using classes_and_objects.Classes;

namespace classes_and_objects
{
  class Program
  {
    static void Main(string[] args)
    {
      Ponto p = new Ponto(3, 4);
      Console.WriteLine(p.multiplyDistance(p.x, 5));
      Console.WriteLine(Ponto.duplicateDistance(p.x));
    }
  }
}
