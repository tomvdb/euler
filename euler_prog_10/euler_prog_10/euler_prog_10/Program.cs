using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace euler_prog_10
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
      DateTime start = DateTime.Now;

      UInt64 primeSum = 2;
      UInt64 count = 3;

      while (count < 2000000)
      {
        if (isPrime(count))
        {
          primeSum += count;
          //Console.WriteLine("Current Prime: " + count);
        }

        // 2 is the only even prime number
        count+= 2;
      }

      Console.WriteLine("Prime Sum: " + primeSum);

      DateTime end = DateTime.Now;

      TimeSpan duration = end - start;

      Console.WriteLine( "Duration: " + duration.ToString());

      /*
       * // brute force
       * 
        C:\source\challenges\euler_prog_10\euler_prog_10\euler_prog_10\bin\Debug>euler_prog_10.exe
        Prime Sum: 142913828922
        Duration: 04:13:20.5044191
       * 
       */
    }
  }
}
