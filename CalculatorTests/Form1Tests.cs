using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void ResultTest()
        {
            var target = new Form1();
            double result = 2;
            double expected = 2;
            target.Result = result;
            double actual = target.Result;
            Assert.AreEqual(expected, actual);
        }
    }
}