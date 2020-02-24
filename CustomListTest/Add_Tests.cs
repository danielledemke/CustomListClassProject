using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PraseodymiumTDD;
namespace CustomListTest
{
    [TestClass]
    public class Add_Tests
    {
        [TestMethod]
        public void Add_OneValue_CountIncrement()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int expected = 1;
            int actual;


            //Act
            myList.Add(value1);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_OneItemAdded_ItemAddsToFirstIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;
            int actual;

            //Act
            myList.Add(expected);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_MultipleItemsAdded_ItemAddsToCorrectIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 10;
            int actual;
            int value1 = 5;
            int value2 = 10;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            actual = myList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_NumberOfItemsOverCapacity_ItemsCopyToNewArray()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 12;
            int actual;
            int number = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            //Act
            myList.Add(number);
            myList.Add(number2);
            myList.Add(number3);
            myList.Add(number4);
            myList.Add(expected);
            actual = myList[4];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //add 5, what is capacity?
        [TestMethod]
        public void Add_OverCapacityLimit_CapacityDoubles()
        {
            //arrange
            CustomList<int> myList = new CustomList<int>();
            int number = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int number5 = 5;
            int expected = 8;
            int actual;
             //act
            myList.Add(number);
            myList.Add(number2);
            myList.Add(number3);
            myList.Add(number4);
            myList.Add(number5);
            actual = myList.Capacity;
            
            //assert
            Assert.AreEqual(expected, actual);
        }
            
           

    }
}
