using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint1.TaskReview.V25.Lib;

namespace Tyuiu.LoginovMV.Sprint1.TaskReview.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            double wait = -0.078;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
