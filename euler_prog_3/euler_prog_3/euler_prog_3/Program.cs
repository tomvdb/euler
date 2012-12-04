using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace euler_prog_3
{
  class Program
  {
    static bool isPrime(UInt64 nr)
    {
      UInt64 divisor = nr - 1;


      while (divisor > 1)
      {
        if (nr % divisor == 0)
          return false;
        divisor--;
      }

      return true;
    }

    static void Main(string[] args)
    {
      UInt64 composite = 600851475143;
      UInt64 c = 1;
      UInt64 largest = 0;

      for (c = 1; c < composite; c++)
      {
        if (isPrime(c))
        {
          if (composite % c == 0)
          {
            Console.WriteLine("Found Prime Factor: " + c);
            largest = c;
          }
        }
      }

      Console.WriteLine("Largest prime factor of " + composite + " = " + largest);

      // I tried the 5th value after it was running for a while and it was correct, so never waited for it to finish
    }
  }
}
