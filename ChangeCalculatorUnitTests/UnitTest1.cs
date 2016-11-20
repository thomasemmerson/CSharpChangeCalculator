using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChangeCalculatorUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //TODO Finish first unit test by referencing ChangeCalculator...
            AssertThat.IsEqual(1, CalculateNumberOfCoinsIn(0.01));
        }
    }
}
