using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcLib.Tests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum_10and20_30return()
        {
            string x = "A111AA11";

            char[] w = x.ToCharArray();

            string q7 = x.Substring(6, x.Length - 6);

            MyCalc c = new MyCalc();
            bool ac = c.Sum(x, w, q7);

            Assert.AreEqual(true, ac);
        }
    }
}
