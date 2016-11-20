using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChangeCalculatorUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_that_one_pence_change_requires_1_coin()
        {
            Assert.AreEqual(1, ChangeCalculator.Program.CalculateNumberOfCoinsIn(0.01));
        }
    }
}
