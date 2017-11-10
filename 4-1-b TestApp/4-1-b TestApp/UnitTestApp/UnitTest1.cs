using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestApp.MathOperations.Double(10);
        }

        [TestMethod]
        public void TestMethod3()
        {
            TestApp.MathOperations.Triple(1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(20, TestApp.MathOperations.Double(10));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(30, TestApp.MathOperations.Triple(10));
        }
    }
}
