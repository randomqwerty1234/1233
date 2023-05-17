using System;
using System.Collections.Generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string foo;
      double result = 1;
      Console.WriteLine("Введіть значення x: ");
      foo = Console.Readline();
      int x = Convert.ToInt32(foo);
      if (x >= -2 && x <= 50)
      {
        for (int i = 0; i <= x; i++)
        {
          result += i + 3 / 4
        }
        Console.WriteLine("Результат програми: " + result);
      }
      else if (x >= -12 && x <= -3)
      {
        result = Math.Pow(x, 2) + 5;
        Console.WriteLine("Результат програми: " + result);
      }
      Console.ReadLine();
    }
  }
}
