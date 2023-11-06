using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Practic3;

namespace UnitTest
{
    [TestClass]
    public class Calculation_abcTest
    {
        [TestMethod]
        public void Calc_pos_pos_pos()
        {
            var calc = new Calculation_abc(1, 2, 3);
            var testRes = 6;

            var res = calc.D();

            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void Calc_neg_neg_neg()
        {
            var calc = new Calculation_abc(-1, -2, -3);
            var testRes = -6;

            var res = calc.D();

            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void Calc_neg_neg_pos()
        {
            var calc = new Calculation_abc(-1, -2, 3);
            var testRes = 2;

            var res = calc.D();

            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void Calc_neg_pos_pos()
        {
            var calc = new Calculation_abc(-1, 2, 3);
            var testRes = 2;

            var res = calc.D();

            Assert.AreEqual(testRes, res);
        }
    }
}
