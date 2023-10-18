using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DreminIa.Sprint2.Task0.V18.Lib;

namespace Tyuiu.DreminIa.Sprint2.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestComparisonResults()
        {
            int x = 5105;
            int y = 475;
            DataService ds = new DataService();
            bool[] expectedResults = { false, true, false, true, false, true };

            bool[] actualResults = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(expectedResults, actualResults);
        }
    }
}
