using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DreminIa.Sprint2.Task4.V19.Lib;

namespace Tyuiu.DreminIa.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 1;

            double z = ds.Calculate(x, y);
            double wait = 0.871;

            Assert.AreEqual(z, wait);
        }
    }
}
