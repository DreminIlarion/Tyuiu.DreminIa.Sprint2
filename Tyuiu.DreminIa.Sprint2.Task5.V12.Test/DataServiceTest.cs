using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DreminIa.Sprint2.Task5.V12.Lib;

namespace Tyuiu.DreminIa.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetPreviousDate_LeapYear_CorrectlyCalculatesPreviousDate()
        {
            DataService calculator = new DataService();

            DateTime previousDate = calculator.FindDateOfPreviousDay(2020, 1, 1);

            Assert.AreEqual(new DateTime(2019, 12, 31), previousDate);
        }
    }
}
