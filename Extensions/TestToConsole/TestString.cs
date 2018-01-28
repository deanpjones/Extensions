using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions.Extensions;
using System.Diagnostics;

namespace Extensions.TestToConsole
{
    public static class TestString
    {
        
        //TEST (GENERICS)
        public static void TestGenerics()
        {
            var x = Extensions.StringExtension.TestGeneric<int>(14);
            Console.WriteLine(x.GetType());
        }

        //TEST (TO DIGIT ARRAY)
        public static void TestToDigitArray()
        {           
            var list = Extensions.NumberExtension.IntToDigitArray(456123);
            foreach (var n in list)
            {
                Console.Write("," + n);
            }

            Console.WriteLine("\nCompare to...");

            int[] list2 = { 4, 5, 6, 1, 2, 3 };
            foreach (var n in list2)
            {
                Console.Write("," + n);
            }
        }

        //TEST (ODD/EVEN)
        public static void TestIsOddEven()
        {
            int[] numList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine("\nIsEven...");
            foreach (var n in numList)
            {
                bool boo = Extensions.NumberExtension.IsEven(n);
                Console.WriteLine("{0} is: {1}", n, boo);
            }
            Console.WriteLine("\nIsOdd...");
            foreach (var n in numList)
            {
                bool boo = Extensions.NumberExtension.IsOdd(n);
                Console.WriteLine("{0} is: {1}", n, boo);
            }
        }

    }
}
