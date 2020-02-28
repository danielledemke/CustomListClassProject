using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProj;


namespace CustomListTest
{
    [TestClass]
    public class Operator_Tests
    {
        [TestMethod]
        public void AddOperator_AddTwoCustomLists_NewListReturns()
        {
            //arrange
            CustomList<string> numbers = new CustomList<string>();
            numbers.Add("1");
            CustomList<string> animals = new CustomList<string>();
            animals.Add("penguin");
            CustomList<string> actual;
            CustomList<string> expected = new CustomList<string>();
            expected.Add("1");
            expected.Add("penguin");
            string capture = expected.ToString();
            //act
            actual = numbers + animals;
            actual.ToString();
            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void AddOperator_AddTwoCustomLists_CountIncreases()
        {
            //arrange
            CustomList<int> numbers1 = new CustomList<int>();
            numbers1.Add(20);
            CustomList<int> numbers2 = new CustomList<int>();
            numbers2.Add(100);
            CustomList<int> finalNumbers = numbers1 + numbers2;
            int expected = 2;
            int actual;
            //act
            actual = finalNumbers.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractOperator_SubtractList_CountDecreases()
        {
            //arrange
            CustomList<int> numbers1 = new CustomList<int>();
            numbers1.Add(20);
            numbers1.Add(25);
            CustomList<int> numbers2 = new CustomList<int>();
            numbers2.Add(20);
            CustomList<int> finalNumbers = numbers1 - numbers2;
            int expected = 1;
            int actual;
            //act
            actual = finalNumbers.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractOperator_SubtractList_ListRemoves()
        {
            //arrange
            CustomList<int> numbers1 = new CustomList<int>();
            numbers1.Add(20);
            numbers1.Add(25);
            CustomList<int> numbers2 = new CustomList<int>();
            numbers2.Add(20);
            CustomList<int> finalNumbers = numbers1 - numbers2;
            int expected = 25;
            int actual;
            //act
            actual = finalNumbers[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_ZipTwoLists_NewListCreated()
        {
            //arrange
            CustomList<int> numbers1 = new CustomList<int>();
            numbers1.Add(1);
            numbers1.Add(3);
            CustomList<int> numbers2 = new CustomList<int>();
            numbers2.Add(2);
            numbers2.Add(4);
            CustomList<int> finalNumbers = new CustomList<int>();
            finalNumbers.Zip(numbers1, numbers2);
            int expected = 2;
            int actual;
            //act
            actual = finalNumbers[1];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_ZipTwoLists_CountIncreases()
        {
            //arrange
            CustomList<int> numbers1 = new CustomList<int>();
            numbers1.Add(1);
            numbers1.Add(3);
            CustomList<int> numbers2 = new CustomList<int>();
            numbers2.Add(2);
            numbers2.Add(4);
            CustomList<int> finalNumbers = new CustomList<int>();
            finalNumbers.Zip(numbers1, numbers2);
            int expected = 4;
            int actual;
            //act
            actual = finalNumbers.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
