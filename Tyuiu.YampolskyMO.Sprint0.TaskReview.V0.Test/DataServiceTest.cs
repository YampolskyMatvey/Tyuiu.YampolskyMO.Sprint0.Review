using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.YampolskyMO.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.YampolskyMO.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();

            int x = 1;
            int y = 2;
            int z = 3;

            int res = ds.Calc(x, y, z);
            int wait = 30; // (1 + 2 + 3) * 5 = 30

            Assert.AreEqual(wait, res);
        }
    }
}