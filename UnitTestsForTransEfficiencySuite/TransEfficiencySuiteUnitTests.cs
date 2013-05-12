using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransEfficiencySuite.Helpers;

namespace UnitTestsForTransEfficiencySuite
{
    [TestClass]
    public class TransEfficiencySuiteUnitTests
    {
        [TestMethod]
        public void TestPostLength()
        {
            Assert.AreEqual(SignComputation.TotalPostLength("0", "24", "false"), "12.5");
            Assert.AreEqual(SignComputation.TotalPostLength("1", "36", "false"), "13.5");
            Assert.AreEqual(SignComputation.TotalPostLength("2", "12", "false"), "10.5");
        }
        [TestMethod]
        public void TestPostType()
        {
            Assert.AreEqual(SignComputation.SignPostType("4", "24", "0", "true"), "Type 2");
            Assert.AreEqual(SignComputation.SignPostType("9", "36", "0", "false"), "Type 2");
            Assert.AreEqual(SignComputation.SignPostType("16", "48", "1", "false"), "Type 4");
            Assert.AreEqual(SignComputation.SignPostType("25", "60", "1", "true"), "Type 6");
        }


    }
}
