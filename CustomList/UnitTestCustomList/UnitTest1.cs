using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
namespace CustomList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddToCustomListStringEmptyList()
        {
            //Arrange
            CustomList<string> TestClass = new CustomList<string>();
            TestClass.Add("Last");
            //Act
            string result = TestClass[0];
            string expected = "Last";
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAddToCustomListStringMadeList()
        {
            //Arrange
            CustomList<string> TestClass = new CustomList<string>();
            TestClass.Add("fart1");
            TestClass.Add("fart2");
            TestClass.Add("fart3");
            TestClass.Add("Last4");
            //Act
            string result = TestClass[3];
            string expected = "Last4";
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAddToCustomListIntEmptyList()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(8);
            //Act
            int result = testList[0];
            int expected = 8;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAddToCustomListIntMadeList()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(12);
            testList.Add(11);
            testList.Add(8);
            //Act
            int result = testList[6];
            int expected = 8;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAddToCustomListDouble()
        {
            //Arrange
            CustomList<double> testList = new CustomList<double>();
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(12);
            testList.Add(1.33);
            //Act
            double result = testList[5];
            double expected = 1.33;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCountToCustomListEmpty()
        {
            //Arrange
            CustomList<double> testList = new CustomList<double>();
            //Act
            int result = testList.Count;
            int expected = 0;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCountToCustomListMade()
        {
            //Arrange
            CustomList<double> testList = new CustomList<double>();
            //Act
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(5);
            int result = testList.Count;
            int expected = 5;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestRemoveFromtCustomListString()
        {
            //Arrange
            CustomList<string> TestClass = new CustomList<string>();
            TestClass.Add("fox");
            TestClass.Add("cow");
            TestClass.Add("chicken");
            TestClass.Add("cow");
            //Act
            TestClass.Remove("cow");
            string result = TestClass[1];
            string expected = "chicken";
            int result2nd = TestClass.Count;
            int expected2nd = 3;
            //Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2nd, result2nd);
        }

        [TestMethod]
        public void TestRemoveFromtCustomListStringEntireListSame()
        {
            //Arrange
            CustomList<string> TestClass = new CustomList<string>();
            TestClass.Add("cow");
            TestClass.Add("cow");
            TestClass.Add("cow");
            TestClass.Add("cow");
            //Act
            TestClass.Remove("cow");
            int result = TestClass.Count;
            int expected = 3;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestRemoveFromtCustomListInt()
        {
            //Arrange
            CustomList<int> TestClass = new CustomList<int>();
            TestClass.Add(1);
            TestClass.Add(2);
            TestClass.Add(3);
            TestClass.Add(2);
            //Act
            TestClass.Remove(2);
            int result = TestClass[1];
            int expected = 3;
            int result2nd = TestClass.Count;
            int expected2nd = 3;
            //Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2nd, result2nd);
        }

        [TestMethod]
        public void TestRemoveFromtCustomListIntEntireListSame()
        {
            //Arrange
            CustomList<int> TestClass = new CustomList<int>();
            TestClass.Add(2);
            TestClass.Add(2);
            TestClass.Add(2);
            TestClass.Add(2);
            //Act
            TestClass.Remove(2);
            int result = TestClass.Count;
            int expected = 3;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestRemoveFromtCustomListDouble()
        {
            //Arrange
            CustomList<double> TestClass = new CustomList<double>();
            TestClass.Add(1);
            TestClass.Add(2);
            TestClass.Add(3.5);
            TestClass.Add(2);
            //Act
            TestClass.Remove(2);
            double result = TestClass[1];
            double expected = 3.5;
            int result2nd = TestClass.Count;
            int expected2nd = 3;
            //Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2nd, result2nd);
        }

        [TestMethod]
        public void TestRemoveFromtCustomListDoubleEntireList()
        {
            //Arrange
            CustomList<double> TestClass = new CustomList<double>();
            TestClass.Add(2);
            TestClass.Add(2);
            TestClass.Add(2);
            TestClass.Add(2);
            //Act
            TestClass.Remove(2);
            int result = TestClass.Count;
            int expected = 3;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestOperatorOverridePlusInt()
        {
            //Arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            //Act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList1.Add(4);
            testList1.Add(5);
            testList2.Add(6);
            testList2.Add(7);
            testList2.Add(8);
            testList2.Add(9);
            testList2.Add(10);
            CustomList<int> resultList = testList1 + testList2;
            int result = resultList.Count;
            int expected = 10;
            int result2nd = resultList[7];
            int expected2nd = 8;
            //Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2nd, result2nd);
        }
        [TestMethod]
        public void TestOperatorOverridePlusIntBothEmpty()
        {
            //Arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            //Act
            CustomList<int> resultList = testList1 + testList2;
            int result = resultList.Count;
            int expected = 0;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestOperatorOverridePlusIntOneEmpty()
        {
            //Arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            //Act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList1.Add(4);
            testList1.Add(5);
            CustomList<int> resultList = testList1 + testList2;
            int result = resultList.Count;
            int expected = 5;
            int result2nd = resultList[4];
            int expected2nd = 5;
            //Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2nd, result2nd);
        }
        [TestMethod]
        public void TestOperatorOverridePlusString()
        {
            //Arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            //Act
            testList1.Add("wow");
            testList1.Add("dude");
            testList1.Add("this");
            testList1.Add("Test");
            testList1.Add("Driven");
            testList2.Add("Design");
            testList2.Add("thing");
            testList2.Add("is");
            testList2.Add("pretty");
            testList2.Add("informative of how to build methods and classes");
            CustomList<string> resultList = testList1 + testList2;
            int result = resultList.Count;
            int expected = 10;
            string result2nd = resultList[7];
            string expected2nd = "is";
            //Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2nd, result2nd);
        }
        [TestMethod]
        public void TestOperatorOverridePlusStringBothEmpty()
        {
            //Arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            //Act
            CustomList<string> resultList = testList1 + testList2;
            int result = resultList.Count;
            int expected = 0;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestOperatorOverrideMinusInt()
        {
            //Arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            //Act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList1.Add(5);
            testList1.Add(4);
            testList2.Add(6);
            testList2.Add(5);
            testList2.Add(5);
            testList2.Add(9);
            testList2.Add(10);
            CustomList<int> resultList = testList1 - testList2;
            int result = resultList.Count;
            int expected = 4;
            int result2nd = resultList[3];
            int expected2nd = 4;
            //Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2nd, result2nd);
        }
        [TestMethod]
        public void TestOperatorOverrideMinusIntNoMatches()
        {
            //Arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            //Act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList1.Add(5);
            testList1.Add(4);
            testList2.Add(8);
            testList2.Add(9);
            testList2.Add(10);
            testList2.Add(11);
            testList2.Add(12);
            CustomList<int> resultList = testList1 - testList2;
            int result = resultList.Count;
            int expected = 5;
            int result2nd = resultList[3];
            int expected2nd = 5;
            //Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2nd, result2nd);
        }
        [TestMethod]
        public void TestOperatorOverrideMinusIntOneEmptyList()
        {
            //Arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            //Act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList1.Add(5);
            testList1.Add(4);
            CustomList<int> resultList = testList1 - testList2;
            int result = resultList.Count;
            int expected = 5;
            int result2nd = resultList[3];
            int expected2nd = 5;
            //Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2nd, result2nd);
        }
        [TestMethod]
        public void TestOperatorOverrideMinusIntBothEmptyList()
        {
            //Arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            //Act
            CustomList<int> resultList = testList1 - testList2;
            int result = resultList.Count;
            int expected = 0;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestOperatorOverrideMinusString()
        {
            //Arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            //Act
            testList1.Add("wow");
            testList1.Add("dude");
            testList1.Add("this");
            testList1.Add("Test");
            testList1.Add("Driven");
            testList2.Add("wow");
            testList2.Add("dude");
            testList2.Add("wow");
            testList2.Add("hey");
            testList2.Add("wow");
            CustomList<string> resultList = testList1 - testList2;
            int result = resultList.Count;
            int expected = 3;
            string result2nd = resultList[0];
            string expected2nd = "this";
            //Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2nd, result2nd);
        }
        [TestMethod]
        public void TestZipperMergeString()
        {
            //Arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            //Act
            testList1.Add("1");
            testList1.Add("3");
            testList1.Add("5");
            testList1.Add("7");
            testList1.Add("9");
            testList2.Add("2");
            testList2.Add("4");
            testList2.Add("6");
            testList2.Add("8");
            testList2.Add("10");
            CustomList<string> resultList = CustomList<string>.ZipperMerge(testList1, testList2);
            int result = resultList.Count;
            int expected = 10;
            string result2nd = resultList[3];
            string expected2nd = "4";
            //Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2nd, result2nd);
        }
        [TestMethod]
        public void TestZipperMergeStringUnevenCounts()
        {
            //Arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            //Act
            testList1.Add("1");
            testList1.Add("3");
            testList1.Add("5");
            testList1.Add("7");
            testList1.Add("9");
            testList2.Add("2");
            testList2.Add("4");
            testList2.Add("6");
            CustomList<string>resultList= CustomList<string>.ZipperMerge(testList1,testList2);
            int result = resultList.Count;
            int expected = 8;
            string result2nd = resultList[7];
            string expected2nd = "9";
            //Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2nd, result2nd);
        }
        [TestMethod]
        public void TestZipperMergeStringOneEmpty()
        {
            //Arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            //Act
            testList1.Add("1");
            testList1.Add("3");
            testList1.Add("5");
            testList1.Add("7");
            testList1.Add("9");
            CustomList<string> resultList = CustomList<string>.ZipperMerge(testList1, testList2);
            int result = resultList.Count;
            int expected = 5;
            string result2nd = resultList[4];
            string expected2nd = "9";
            //Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2nd, result2nd);
        }
        [TestMethod]
        public void TestZipperMergeStringBothEmpty()
        {
            //Arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            //Act
            CustomList<string> resultList = CustomList<string>.ZipperMerge(testList1, testList2);
            int result = resultList.Count;
            int expected = 0;
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
