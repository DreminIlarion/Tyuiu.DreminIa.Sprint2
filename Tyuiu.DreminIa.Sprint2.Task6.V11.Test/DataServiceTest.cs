using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DreminIa.Sprint2.Task6.V11.Lib;

namespace Tyuiu.DreminIa.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService dataService = new DataService();

            Assert.AreEqual("2023-03-01", dataService.FindDateOfNextDay(2023, 2, 28));
            Assert.AreEqual("2023-04-01", dataService.FindDateOfNextDay(2023, 3, 31));
            Assert.AreEqual("2024-01-01", dataService.FindDateOfNextDay(2023, 12, 31));
        }
    }
}
