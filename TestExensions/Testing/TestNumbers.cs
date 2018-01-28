using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensions.Extensions;            //add reference to (project), add (using)
using System.Diagnostics;
using System.Collections.Generic;

namespace TestExensions.Testing
{
    //DEAN JONES
    //JUL.8, 2017
    //TEST CLASS (NUMBER EXTENSION METHODS)

    [TestClass]
    public class TestNumbers
    {
        //ARRANGE, set up variables (as expected)
        //ACT, do calculation (run method) for result
        //ASSERT, test to see if the results are (as expected)

        //TEST menu, WINDOWS, TEST EXPLORER, (RUN ALL)
        //DEBUG... TEST menu, DEBUG, ALL TESTS

        [TestMethod]
        public void TestRound()
        {
            //arrange
            double expected = 123.456d;
            double testInt = 123.455666d;

            //act
            double actual = testInt.Round(3);   //round to 3 decimal places
            //assert
            Assert.AreEqual(actual, expected);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("actual: " + actual);
        }

        [TestMethod]
        public void TestIsNumericType()
        {
            //arrange
            bool expected = true;
            int testInt = 6;
            double testDouble = 23.0;
            //bool expected = false;
            //string testInt = "6";

            //act
            bool actual = testInt.IsNumericType();
            bool actual2 = testDouble.IsNumericType();

            //assert
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actual2, expected);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("testDouble: " + testDouble);
            Debug.WriteLine("actual: " + actual);
            Debug.WriteLine("actual2: " + actual2);
        }

        [TestMethod]
        public void TestIsInt32()
        {
            //arrange
            bool expected = true;     
            int testInt = 6;
            //bool expected = false;
            //string testInt = "6";

            //act
            bool actual = testInt.isInt32();       

            //assert
            Assert.AreEqual(actual, expected);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("actual: " + actual);
        }

        [TestMethod]
        public void TestSum()
        {
            //arrange
            //int expected = 10;     // 1 + 2 + 3 + 4 = 10
            //int testInt = 4;
            //int expected = 15;     // 1 + 2 + 3 + 4 + 5 = 15
            //int testInt = 5;
            int expected = 21;     // 1 + 2 + 3 + 4 + 5 + 6 = 21
            int testInt = 6;

            //act
            int actual = testInt.Sum();

            //assert
            Assert.AreEqual(actual, expected);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void TestSum2()
        {
            //arrange
            int expected = 21;     // 1 + 2 + 3 + 4 = 10
            int testInt = 6;

            //act
            int actual = testInt.Sum2();

            //assert
            Assert.AreEqual(actual, expected);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void TestFactorial()
        {
            //arrange
            //int expected = 24;    // 1 * 2 * 3 * 4 = 24
            //int testInt = 4;
            int expected = 120;     // 1 * 2 * 3 * 4 * 5 = 120
            int testInt = 5;

            //act
            int actual = testInt.Factorial();

            //assert
            Assert.AreEqual(actual, expected);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void TestDigitSum()
        {
            //arrange
            int expected = 28;
            int testInt = 1234567;

            //act
            int actual = testInt.DigitSum();

            //assert
            Assert.AreEqual(actual, expected);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void TestConvertListToInt()
        {
            //arrange
            int expected = 1200;
            List<int> testInt = new List<int> { 1, 2, 0, 0 };

            //act
            int actual = testInt.ConvertListToInt();        

            //assert
            Assert.AreEqual(actual, expected);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testInt: " + testInt.PrintIntList(", "));
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void TestConvertToBase()
        {
            //arrange
            List<int> expected = new List<int> { 1, 2, 0, 0 };
            int testInt = 45;

            //act
            List<int> actual = testInt.ConvertToBase(3);        //mod-3 convert 

            //assert
            CollectionAssert.AreEqual(actual, expected);

            //print
            Debug.WriteLine("expected: " + expected.PrintIntList(", ") + " (digit places 3^2, 3^1, 3^0)");
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("actual: " + actual.PrintIntList(", ") + " (digit places 3^2, 3^1, 3^0)");

        }

        [TestMethod]
        public void TestDigitMod()
        {
            //arrange
            int expected = 2;
            int testInt = 17;

            //act
            int actual = testInt.DigitMod(5);       //mod-5, 17/5 = 15 r.2

            //assert
            Assert.AreEqual(actual, expected);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void TestDigitCount()
        {
            //arrange
            int expected1 = 3;
            int expected2 = 4;
            int expected3 = 5;
            int testInt1 = 123;
            int testInt2 = 1234;
            int testInt3 = 12345;

            //act
            int actual1 = testInt1.DigitCount();
            int actual2 = testInt2.DigitCount();
            int actual3 = testInt3.DigitCount();

            //assert
            Assert.AreEqual(actual1, expected1);
            Assert.AreEqual(actual2, expected2);
            Assert.AreEqual(actual3, expected3);

            //print
            Debug.WriteLine("expected1: " + expected1);
            Debug.WriteLine("expected2: " + expected2);
            Debug.WriteLine("expected3: " + expected3);
            Debug.WriteLine("testInt1: " + testInt1);
            Debug.WriteLine("testInt2: " + testInt2);
            Debug.WriteLine("testInt3: " + testInt3);
            Debug.WriteLine("actual1: " + actual1);
            Debug.WriteLine("actual2: " + actual2);
            Debug.WriteLine("actual3: " + actual3);

        }

        [TestMethod]
        public void TestRemoveLastDigit()
        {
            //arrange
            int expected = 123;
            int testInt = 1234;

            //act
            int actual = testInt.RemoveLastDigit();

            //assert
            Assert.AreEqual(actual, expected);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void TestGetLastNthDigits()
        {
            //arrange
            int testInt = 1234;
            int expected1 = 4;
            int expected2 = 34;
            int expected3 = 234;

            //act
            int actual1 = testInt.GetLastNthDigits(1);
            int actual2 = testInt.GetLastNthDigits(2);
            int actual3 = testInt.GetLastNthDigits(3);

            //assert
            Assert.AreEqual(actual1, expected1);
            Assert.AreEqual(actual2, expected2);
            Assert.AreEqual(actual3, expected3);

            //print
            Debug.WriteLine("expected1: " + expected1);
            Debug.WriteLine("expected2: " + expected2);
            Debug.WriteLine("expected3: " + expected3);
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("actual1: " + actual1);
            Debug.WriteLine("actual2: " + actual2);
            Debug.WriteLine("actual3: " + actual3);

        }

        [TestMethod]
        public void TestGetLastDigit()
        {
            //arrange
            int expected = 4;
            int testInt = 1234;

            //act
            int actual = testInt.GetLastDigit();

            //assert
            Assert.AreEqual(actual, expected);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void TestIntToDigitArray()
        {
            //arrange
            int[] expected = { 4, 5, 6, 1 };
            int testInt = 4561;

            //act
            int[] actual = testInt.IntToDigitArray();

            //assert
            CollectionAssert.AreEqual(actual, expected);

            //print
            Debug.WriteLine("expected: " + expected.PrintIntArray(", "));
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("actual: " + actual.PrintIntArray(", "));

        }

        [TestMethod]
        public void TestIsEven()
        {
            //arrange
            int testInt = 12;

            //act
            bool actual = testInt.IsEven();

            //assert
            Assert.IsTrue(actual);

            //print
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void TestIsOdd()
        {
            //arrange
            int testInt = 13;

            //act
            bool actual = testInt.IsOdd();

            //assert
            Assert.IsTrue(actual);

            //print
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void TestConvertToDecimal()
        {
            //arrange
            decimal expected = 100m;

            double testDouble = 100d;
            int testInt = 100;
            float testFloat = 100f;
            long testLong = 100L;

            //act
            decimal actual1 = testDouble.ToDec();
            decimal actual2 = testInt.ToDec();
            decimal actual3 = testFloat.ToDec();
            decimal actual4 = testLong.ToDec();

            //assert
            Assert.IsTrue(actual1 == expected &&
                actual2 == expected &&
                actual3 == expected &&
                actual4 == expected);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testDouble: " + testDouble);
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("testFloat: " + testFloat);
            Debug.WriteLine("testLong: " + testLong);
            Debug.WriteLine("actual1: " + actual1);
            Debug.WriteLine("actual2: " + actual2);
            Debug.WriteLine("actual3: " + actual3);
            Debug.WriteLine("actual4: " + actual4);

        }

        [TestMethod]
        public void TestConvertToDouble()
        {
            //arrange
            double expected = 100d;

            decimal testDecimal = 100m;
            int testInt = 100;
            float testFloat = 100f;
            long testLong = 100L;

            //act
            double actual1 = testDecimal.ToDbl();
            double actual2 = testInt.ToDbl();
            double actual3 = testFloat.ToDbl();
            double actual4 = testLong.ToDbl();

            //assert
            Assert.IsTrue(actual1 == expected &&
                actual2 == expected &&
                actual3 == expected &&
                actual4 == expected);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testDouble: " + testDecimal);
            Debug.WriteLine("testInt: " + testInt);
            Debug.WriteLine("testFloat: " + testFloat);
            Debug.WriteLine("testLong: " + testLong);
            Debug.WriteLine("actual1: " + actual1);
            Debug.WriteLine("actual2: " + actual2);
            Debug.WriteLine("actual3: " + actual3);
            Debug.WriteLine("actual4: " + actual4);
        }

        [TestMethod]
        public void TestConvertToInteger()
        {
            //arrange
            int expected = 100;

            double testDouble = 100.5d;
            decimal testDecimal = 100.5m;
            float testFloat = 100.5f;
            long testLong = 100L;

            //act
            int actual1 = testDouble.ToInt();
            int actual2 = testDecimal.ToInt();
            int actual3 = testFloat.ToInt();
            int actual4 = testLong.ToInt();

            //assert
            Assert.IsTrue(actual1 == expected &&
                actual2 == expected &&
                actual3 == expected &&
                actual4 == expected);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testDouble: " + testDouble);
            Debug.WriteLine("testDecimal: " + testDecimal);
            Debug.WriteLine("testFloat: " + testFloat);
            Debug.WriteLine("testLong: " + testLong);
            Debug.WriteLine("actual1: " + actual1);
            Debug.WriteLine("actual2: " + actual2);
            Debug.WriteLine("actual3: " + actual3);
            Debug.WriteLine("actual4: " + actual4);
        }

    }
}
