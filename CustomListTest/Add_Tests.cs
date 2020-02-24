using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PraseodymiumTDD;
namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_OneValue_CountIncrement()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 1;

            //Act
            myList.Add(5);

            //Assert
            Assert.AreEqual(expected, myList.Count);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;

            //Act
            myList.Add(expected);

            //Assert
            Assert.AreEqual(expected, myList[0]);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 10;
            int value1 = 5;
            int value2 = 10;
            //Act
            myList.Add(value1);
            myList.Add(value2);

            //Assert
            Assert.AreEqual(expected, myList[1]);
        }
    }
}
