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
            //act
            actual = numbers + animals;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
