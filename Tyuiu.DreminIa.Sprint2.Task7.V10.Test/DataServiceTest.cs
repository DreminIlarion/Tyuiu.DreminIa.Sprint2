using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DreminIa.Sprint2.Task7.V10.Lib;

namespace Tyuiu.DreminIa.Sprint2.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService dataService = new DataService();

            Assert.IsTrue(dataService.CheckDotInShadedArea(0, 0));  // Точка находится в области
            Assert.IsFalse(dataService.CheckDotInShadedArea(3, 4)); // Точка не находится в области
        }
    }
}
