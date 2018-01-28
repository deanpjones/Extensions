using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ext = Extensions.Extensions;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------
            //primes 
            //TestToConsole.TestPrimes.TestPrimesExceptionsWithTime();        //speed up list...

            //****************************************
            //TestToConsole.TestPrimes.TestRealPrimes();                      //real primes
            //****************************************

            //TestToConsole.TestPrimes.TestPrimesExceptions();                //prime exceptions
            //???
            //trying to optimizing algorithm
            //TestToConsole.TestPrimes.TestPrimesExceptions2();               //prime exceptions
            //???

            //TestToConsole.TestPrimes.TestPrimesTESTINGdifferentThings();    //testing...

            //TestToConsole.TestPrimes.TestPrimesExceptions7sOnly();
            //TestToConsole.TestPrimes.TestPrimesExceptions5sOnly();
            //TestToConsole.TestPrimes.TestPrimesMultiples5sOnly();
            //TestToConsole.TestPrimes.TestPrimesRow1and5OnlyForExceptions();
            //-----------------

            //test for odd/even
            //TestToConsole.TestString.TestIsOddEven();

            ////test for generic type
            //TestToConsole.TestString.TestGenerics();

            ////test array output
            //TestToConsole.TestString.TestToDigitArray();

            //--------------
            //TRUTH TABLE
            //TestToConsole.TestTruthTable.Test();
            //--------------
            //Extensions.CurryingExtension.Test1();
            //Extensions.CurryingExtension.Test2();
            //Extensions.CurryingExtension.Test3();

            //create truth table
            //Extensions.CurryingExtension.Permutation(new int[] { 0, 1 }, 0);
            //Extensions.CurryingExtension.Permutation(new int[] { 0, 1 }, 1);
            //Extensions.CurryingExtension.Permutation(new int[] { 0, 1 }, 2);

            //SWAP
            //Extensions.CurryingExtension.TestSwap();
            //CHAIN FUNCTIONS 
            //Extensions.CurryingExtension.ChainRun();

            //PERMUTATION
            //Extensions.PermutationExtension.Permutation(3, 3);
            //Extensions.PermutationExtension.Perm3d(4);
            //Extensions.PermutationExtension.Perm2d(3);
            //Extensions.PermutationExtension.Perm2d(4, 3);
            //Extensions.PermutationExtension.Test2dArray(10, 10);
            Extensions.PermutationExtension.Test3dArray(3, 3, 3);
            //ext.NumberExtension.DigitCount(23)
            
            Console.Read();
        }
    }
}
