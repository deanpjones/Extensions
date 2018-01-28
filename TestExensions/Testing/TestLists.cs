using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensions.Extensions;            //add reference to (project), add (using)
using System.Diagnostics;

namespace TestExensions.Testing
{
    [TestClass]
    public class TestLists
    {
        [TestMethod]
        public void TestApply2()
        {
            //arrange 
            int[] testList = new int[] { 1, 2, 3, 4 };
            //int[] expectedList = new int[] { 4, 8, 12, 16 };
            //int[] expectedList = new int[] { 5, 10, 15, 20};
            int[] expectedList = new int[] { 11, 22, 33, 44 };

            //act
            int[] actualList = new int[testList.Length];
            //actualList = testList.Apply2(x => x * 4);       //*** create function on the fly ***
            //actualList = testList.Apply2(x => x * 5);
            actualList = testList.Apply2(x => x * 11);

            //assert
            CollectionAssert.AreEqual(expectedList, actualList);

            //print
            Debug.WriteLine("expectedList");
            for (int i = 0; i < expectedList.Length; i++)
            {
                Debug.Write(expectedList[i] + ", ");
            }
            Debug.WriteLine("\nactualList");
            for (int i = 0; i < actualList.Length; i++)
            {
                Debug.Write(actualList[i] + ", ");
            }

        }

        [TestMethod]
        public void TestApply()
        {
            //arrange 
            int[] testList = new int[] { 1, 2, 3, 4 };
            int[] expectedList = new int[] { 2, 3, 4, 5 };

            //act
            int[] actualList = new int[testList.Length];
            actualList = testList.Apply();

            //assert
            CollectionAssert.AreEqual(expectedList, actualList);

            //print
            Debug.WriteLine("expectedList");
            for (int i = 0; i < expectedList.Length; i++)
            {
                Debug.Write(expectedList[i] + ", ");
            }
            Debug.WriteLine("\nactualList");
            for (int i = 0; i < actualList.Length; i++)
            {
                Debug.Write(actualList[i] + ", ");
            }

        }

        [TestMethod]
        public void TestGetNthList()
        {
            //arrange 
            //List<int> expectedList = new List<int>() { 2, 4, 6, 8 };
            //List<int> expectedList = new List<int>() { 3, 6, 9 };
            //List<int> expectedList = new List<int>() { 4, 8 };
            List<int> expectedList = new List<int>() { 1, 3, 5, 7, 9 };
            List<int> modifyList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //act
            List<int> actualList = new List<int>();
            //actualList = modifyList.GetNthList(2, 0);      //get every 2nd element (even)
            //actualList = modifyList.GetNthList(2, 1);      //get every 3rd element 
            //actualList = modifyList.GetNthList(2, 1);      //get every 4th element 
            actualList = modifyList.GetNthList(2, 1);      //get every 2nd element (odd)

            //assert
            CollectionAssert.AreEqual(expectedList, actualList);

            //print
            Debug.WriteLine("expectedList");
            for (int i = 0; i < expectedList.Count; i++)
            {
                Debug.Write(expectedList[i] + ", ");
            }
            Debug.WriteLine("\nactualList");
            for (int i = 0; i < actualList.Count; i++)
            {
                Debug.Write(actualList[i] + ", ");
            }

        }

        [TestMethod]
        public void TestGetNthList2()
        {
            //arrange 
            //List<int> expectedList = new List<int>() { 2, 4, 6, 8 };
            //List<int> expectedList = new List<int>() { 3, 6, 9 };
            //List<int> expectedList = new List<int>() { 4, 8 };
            List<int> expectedList = new List<int>() { 1, 3, 5, 7, 9 };
            List<int> modifyList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //act
            List<int> actualList = new List<int>();
            //actualList = modifyList.GetNthList(2, 0);      //get every 2nd element (even)
            //actualList = modifyList.GetNthList(2, 1);      //get every 3rd element 
            //actualList = modifyList.GetNthList(2, 1);      //get every 4th element 
            actualList = modifyList.GetNthList(2, 1);      //get every 2nd element (odd)

            //assert
            CollectionAssert.AreEqual(expectedList, actualList);

            //print
            Debug.WriteLine("expectedList");
            for (int i = 0; i < expectedList.Count; i++)
            {
                Debug.Write(expectedList[i] + ", ");
            }
            Debug.WriteLine("\nactualList");
            for (int i = 0; i < actualList.Count; i++)
            {
                Debug.Write(actualList[i] + ", ");
            }

        }
    }
}
