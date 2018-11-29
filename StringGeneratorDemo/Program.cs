using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringGeneratorDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("starting...");

      // Generate a random string the simple way.
      Console.WriteLine(GenerateString(14));

      Console.WriteLine("complete");
      Console.ReadKey();
    }

    static string GenerateString(int iLen)
    {
      StringBuilder builder = new StringBuilder();
      Random random = new Random();
      char ch;
      for (int i = 0; i < iLen; i++)
      {
        ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
        builder.Append(ch);
      }

      return builder.ToString();
    }
  }
}
