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
            CustomList<string> testList = new CustomList<string>() { "hello", "people", "what is that?" };
            testList.Add("Last");
            //Act
            string result = testList[3];
            string expected = "Last";
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
            CustomList<int> testList = new CustomList<int>() { 5, 4, 6, 7, 8, 9 };
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
            CustomList<double> testList = new CustomList<double>() {3,5,6,7,8};
            testList.Add(1.33);
            //Act
            string result = testList[5];
            string expected = 1.33;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCountToCustomListEmpty()
        {
            //Arrange
            CustomList<double> testList = new CustomList<double>();
            //Act
            int result = testList.count;
            int expected = 0;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCountToCustomListMade()
        {
            //Arrange
            CustomList<double> testList = new CustomList<double>(){4,4,4,4,4);
            //Act
            int result = testList.count;
            int expected = 5;
            //Assert
            Assert.AreEqual(expected, result);
        }
}
