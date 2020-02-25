using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProj;

namespace CustomListTest
{
    [TestClass]
    public class Remove_Tests
    {
        [TestMethod]
        public void Remove_RemoveOneItem_CountDecreases()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(5);
            list.Add(10);
            list.Add(15);
            list.Remove(15);
            int expected = 2;
            int actual;
            //act
            actual = list.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveOneItem_ItemRemoved()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(500);
            list.Remove(500);
            int expected = 0;
            int actual;
            //act
            actual = list[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveFirstIndiceItem_OtherItemsShiftDown()
        {
            //arange
            CustomList<int> list = new CustomList<int>();
            list.Add(10);
            list.Add(15);
            list.Remove(10);
            int expected = 15;
            int actual;
            //act
            actual = list[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveInteger_FirstMatchingIntegerRemoved()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(7);
            list.Add(21);
            list.Add(7);
            list.Remove(7);
            int expected = 21;
            int actual;
            //act
            actual = list[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItems_CapacityDecreases()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Remove(5);
            list.Remove(6);
            int expected = 4;
            int actual;
            //act
            actual = list.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }





    }
}
    

