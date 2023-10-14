using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MedvedevA.Sprint2.Task5.V1.Lib;

namespace Tyuiu.MedvedevA.Sprint2.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();

            int value = 9;

            var res = ds.FindMonthDaysCount(value);
            Assert.AreEqual(30, res);
        }
    }
}
