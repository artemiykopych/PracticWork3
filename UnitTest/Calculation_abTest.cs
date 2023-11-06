using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practic3;

namespace UnitTest
{
    [TestClass]
    public class Calculation_abTest
    {
        [TestMethod]
        public void Calc_a_great_b()
        {
            var calc = new Calculation_ab(2, 1);

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => calc.Sun());
        }

        [TestMethod]
        public void Calc_a_equal_b()
        {
            var calc = new Calculation_ab(1, 1);
            var TestRes = 0;

            var res = calc.Sun();

            Assert.AreEqual(TestRes, res);
        }

        [TestMethod]
        public void Calc_neg_pos()
        {
            var calc = new Calculation_ab(-5, 5);
            var TestRes = 6;

            var res = calc.Sun();

            Assert.AreEqual(TestRes, res);
        }
    }
}
