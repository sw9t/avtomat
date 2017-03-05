using System;
using AutomatLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testiki
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var is_number = Mashina.Match("+373(775)32261");
            Assert.AreEqual(is_number,true);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var is_number = Mashina.Match("0(775)32261");
            Assert.AreEqual(is_number, true);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var is_number = Mashina.Match("32261");
            Assert.AreEqual(is_number, true);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var is_number = Mashina.Match("+373(775)322691");
            Assert.AreNotEqual(is_number, true);
        }
        [TestMethod]
        public void TestMethod5()
        {
            var is_number = Mashina.Match("+373(7750)32261");
            Assert.AreNotEqual(is_number, true);
        }
        [TestMethod]
        public void TestMethod6()
        {
            var is_number = Mashina.Match("+373(7750)32261");
            Assert.AreNotEqual(is_number, true);
        }
        [TestMethod]
        public void TestMethod7()
        {
            var is_number = Mashina.Match("dfdfdfd373(7750)32261");
            Assert.AreNotEqual(is_number, true);
        }
        [TestMethod]
        public void TestMethod8()
        {
            var is_number = Mashina.Match("+373(7oo)32261");
            Assert.AreNotEqual(is_number, true);
        }
        [TestMethod]
        public void TestMethod9()
        {
            var is_number = Mashina.Match("+373(77532261");
            Assert.AreNotEqual(is_number, true);
        }
        [TestMethod]
        public void TestMethod10()
        {
            var is_number = Mashina.Match("+373775)32261");
            Assert.AreNotEqual(is_number, true);
        }
        [TestMethod]
        public void TestMethod11()
        {
            var is_number = Mashina.Match("+373(775)02261");
            Assert.AreNotEqual(is_number, true);
        }
    }
}
