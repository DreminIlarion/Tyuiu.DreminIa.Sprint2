using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DreminIa.Sprint2.Task1.V4.Lib;

namespace Tyuiu.DreminIa.Sprint2.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int a = 247;
            int b = 654 ;
            int c = 671;
            int d = 671;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = { false, false, false, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
