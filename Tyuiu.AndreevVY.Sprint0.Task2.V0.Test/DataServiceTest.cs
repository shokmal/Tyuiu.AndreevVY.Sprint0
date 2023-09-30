﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AndreevVY.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AndreevVY.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageVaild()
        {
            var name = "Игорь";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Игорь", res);
        }
    }
}
