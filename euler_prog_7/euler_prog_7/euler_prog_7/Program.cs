using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace euler_prog_7
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
      UInt64 testNumber = 2;
      UInt64 primeCount = 0;

      while (primeCount < 10002)
      {
        if (isPrime(testNumber))
        {
          primeCount++;
          Console.WriteLine(primeCount + " = " + testNumber);
        }

        testNumber++;
      }
    }
  }
}
