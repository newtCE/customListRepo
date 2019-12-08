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
            string result = TestClass.customListArray[0];
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
            string result = TestClass.customListArray[3];
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
            int result = testList.customListArray[0];
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
            int result = testList.customListArray[6];
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
            double result = testList.customListArray[5];
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
            string result = TestClass.customListArray[1];
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
            int result = TestClass.customListArray[1];
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
            double result = TestClass.customListArray[1];
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
    }
}
