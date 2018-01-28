using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions.Extensions;

namespace Extensions.TestToConsole
{
    public static class TestPrimes
    {
        //TEST (REAL PRIMES)
        public static void TestPrimesExceptionsWithTime()
        {
            var s1 = Stopwatch.StartNew();
            var x = Extensions.PrimeExtension.PrimeException(10000);
            s1.Stop();

            x.ToList().PrintToConsole();

            Console.WriteLine();
            Console.WriteLine((s1.Elapsed.Milliseconds).ToString("0.000 ms"));
        }

        //TEST (REAL PRIMES)
        public static void TestRealPrimes()
        {
            var primes = new List<int>();

            //--------------------------------
            //test speed of algorithm
            const int m = 10000;
            var s1 = Stopwatch.StartNew();

            //************************************************************
            //100,000 is a bit slow (but works)(console doesn't show beginning...)
            //50,000 (49,999 is 5133th prime)
            primes = Extensions.PrimeExtension.PrimeReal(50000).ToList();
            //************************************************************

            s1.Stop();
            //--------------------------------

            //var primes = Extensions.NumberExtension.PrimeReal(20000).ToList();
            primes.PrintToConsole();

            Console.WriteLine();
            //Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / m).ToString("0.00 ns"));
            Console.WriteLine((s1.Elapsed.Milliseconds).ToString("0.000 ms"));

            Console.WriteLine("\n{0} is the {1} nth prime number", primes.Last(), primes.Count);
        }

        //TEST (PRIME EXCEPTIONS)
        public static void TestPrimesExceptions2()
        {
            var x = Extensions.PrimeExtension.PrimeException2(200);
            x.ToList().PrintToConsole();
        }

        //TEST (PRIME EXCEPTIONS)
        public static void TestPrimesExceptions()
        {
            var x = Extensions.PrimeExtension.PrimeException(100);
            x.ToList().PrintToConsole();
        }

        //TEST (PRIMES)
        public static void TestPrimesTESTINGdifferentThings()
        {
            var list = Extensions.PrimeExtension.PrimeAllExceptionsTESTING();
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }
        }

        //TEST (PRIMES)
        public static void TestPrimesExceptions7sOnly()
        {
            var list = Extensions.PrimeExtension.PrimeExceptions7s();
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }
        }

        //TEST (PRIMES)
        public static void TestPrimesExceptions5sOnly()
        {
            var list = Extensions.PrimeExtension.PrimeExceptions5s();
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }
        }

        //TEST (PRIMES)
        public static void TestPrimesMultiples5sOnly()
        {
            var list = Extensions.PrimeExtension.Prime5s();
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }
        }

        //TEST (PRIMES)
        public static void TestPrimesRow1and5OnlyForExceptions()
        {
            var list = Extensions.PrimeExtension.PrimeRowException();
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }
        }
    }
}
