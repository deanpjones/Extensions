using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensions.Extensions;            //add reference to (project), add (using)
using System.Diagnostics;

namespace TestExensions.Testing
{
    //DEAN JONES
    //JUL.8, 2017
    //TEST CLASS (STRING EXTENSION METHODS)

    [TestClass]
    public class TestStrings
    {
        //ARRANGE, set up variables (as expected)
        //ACT, do calculation (run method) for result
        //ASSERT, test to see if the results are (as expected)

        //TEST menu, WINDOWS, TEST EXPLORER, (RUN ALL)
        //DEBUG... TEST menu, DEBUG, ALL TESTS

        //[TestMethod]
        //public void StringCapitalize3()
        //{
        //    //arrange
        //    string expected = "";
        //    string testString = "";

        //    //act
        //    string actual = testString.Capitalize();

        //    //assert
        //    Assert.AreEqual(actual, expected);

        //}

        [TestMethod]
        public void StringSuffix()
        {
            //arrange
            string expected = "string.txt";
            string testString = "string";

            //act
            string actual = testString.Suffix(".txt");

            //assert
            Assert.AreEqual(expected, actual);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testString: " + testString);
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void StringPrefix()
        {
            //arrange
            string expected = "Pre_string";
            string testString = "string";

            //act
            string actual = testString.Prefix("Pre_");

            //assert
            Assert.AreEqual(expected, actual);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testString: " + testString);
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void IsStringLength()
        {
            //arrange
            string testString = "abcdefghi";            

            //act
            bool actual = testString.IsStringLength(9);           

            //assert
            Assert.IsTrue(actual);

            //print
            Debug.WriteLine("testString: " + testString);
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void IsStringAlphaOnly()
        {
            //arrange
            string testString = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            //act
            bool actual = testString.IsAlphaOnly();

            //assert
            Assert.IsTrue(actual);

            //print
            Debug.WriteLine("testString: " + testString);
            Debug.WriteLine("actual: " + actual);
        }

        [TestMethod]
        public void IsStringDigitsOnly()
        {
            //arrange
            string testString = "0123456789";

            //act
            bool actual = testString.IsDigitOnly();

            //assert
            Assert.IsTrue(actual);

            //print
            Debug.WriteLine("testString: " + testString);
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void IsStringMatchRegularExpressionDigits()
        {
            //arrange
            string testString = "12454";
            string testString2 = "Abcdef";
            string testString3 = "1234abcd";                //8 char length

            //act
            //bool actual = testString.IsRegEx(@"\d");                        //test are digits
            bool actual = testString.IsRegEx(@"^[0-9]+$");                  //test are digits
            bool actual2 = testString2.IsRegEx(@"^[a-zA-Z]+$");             //test are alpha
            bool actual3 = testString3.IsRegEx(@"^.{8}$");                  //test length

            //assert
            Assert.IsTrue(actual && actual2 && actual3);

            //print
            Debug.WriteLine("testString: " + testString);
            Debug.WriteLine("testString2: " + testString2);
            Debug.WriteLine("testString3: " + testString3);
            Debug.WriteLine("actual: " + actual);
            Debug.WriteLine("actual2: " + actual2);
            Debug.WriteLine("actual3: " + actual3);
        }

        [TestMethod]
        public void StringCapitalize2()
        {
            //arrange
            string expected = "A";
            string testString = "a";

            //act
            string actual = testString.Capitalize();

            //assert
            Assert.AreEqual(actual, expected);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testString: " + testString);
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void StringCapitalize()
        {
            //arrange
            string expected = "This is a lowercase sentence.";      
            string testString = "this is a lowercase sentence.";

            //act
            string actual = testString.Capitalize();

            //assert
            Assert.AreEqual(actual, expected);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testString: " + testString);
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void IsNullOrWhiteSpace()
        {
            //arrange
            string testString = "      ";           //only whitespace

            //act
            bool actual = testString.IsNullOrWhiteSpace();
            bool actual2 = testString == "      ";
            bool actual3 = testString == null;
            bool actual4 = actual == actual2 || actual3;

            //assert
            Assert.IsTrue(actual4);

            //print
            Debug.WriteLine("testString: " + testString);
            Debug.WriteLine("actual: " + actual);
            Debug.WriteLine("actual2: " + actual2);
            Debug.WriteLine("actual3: " + actual3);
            Debug.WriteLine("actual4: " + actual4);

        }

        [TestMethod]
        public void IsStringEmpty2()
        {
            //arrange
            string testString = "";

            //act
            bool actual = testString.IsNullOrEmpty();
            bool actual2 = testString == "";

            //assert
            Assert.AreEqual(actual, actual2);

            //print
            Debug.WriteLine("testString: " + testString);
            Debug.WriteLine("actual: " + actual);
            Debug.WriteLine("actual2: " + actual2);
        }

        [TestMethod]
        public void IsStringEmpty()
        {
            //arrange
            string testString = "";

            //act
            bool actual = testString.IsEmpty();
            bool actual2 = testString == "";

            //assert
            Assert.AreEqual(actual, actual2);

            //print
            Debug.WriteLine("testString: " + testString);
            Debug.WriteLine("actual: " + actual);
            Debug.WriteLine("actual2: " + actual2);
        }

        [TestMethod]
        public void IsStringNull2()
        {
            //arrange
            string testString = null;

            //act
            bool actual = testString.IsNullOrEmpty();
            bool actual2 = testString == null;

            //assert
            Assert.AreEqual(actual, actual2);

            //print
            Debug.WriteLine("testString: " + testString);
            Debug.WriteLine("actual: " + actual);
            Debug.WriteLine("actual2: " + actual2);
        }

        [TestMethod]
        public void IsStringNull()
        {
            //arrange
            string testString = null;         

            //act
            bool actual = testString.IsNull();
            bool actual2 = testString == null;

            //assert
            Assert.AreEqual(actual, actual2);

            //print
            Debug.WriteLine("testString: " + testString);
            Debug.WriteLine("actual: " + actual);
            Debug.WriteLine("actual2: " + actual2);

        }

        [TestMethod]
        public void ConvertSentenceToSingleSpaces()
        {
            //arrange
            string expected = "This is a poor sentence .";      //this points out problem (with period)
            string testString = "This   is    a poor     sentence   .";

            //act
            string actual = testString.SingleSpace();

            //assert
            Assert.AreEqual(expected, actual);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("testString: " + testString);
            Debug.WriteLine("actual: " + actual);
            
        }
    }
}
