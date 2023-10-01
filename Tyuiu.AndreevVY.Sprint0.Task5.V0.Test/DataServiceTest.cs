using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AndreevVY.Sprint0.Task5.V0.Lib;

namespace Tyuiu.AndreevVY.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckedSubtractionVaild()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void CheckedMultiplicatonValid()
        {
            Assert.AreEqual(50, DataService.Multiplicaton(10, 5));
        }

        [TestMethod]
        public void CheckedDivisionVaild()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
