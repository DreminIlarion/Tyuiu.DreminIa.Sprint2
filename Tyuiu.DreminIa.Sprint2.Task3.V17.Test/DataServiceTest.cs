using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DreminIa.Sprint2.Task4.V17.Lib;

namespace Tyuiu.DreminIa.Sprint2.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);

            double wait = -0.286;
            Assert.AreEqual(wait, res);
        }
    }
}