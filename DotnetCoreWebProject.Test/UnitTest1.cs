using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DotnetCoreWebProject.Test
{
    [TestClass]
    public class UnitTest1
    {
        SimpleClass _calc;

        public UnitTest1()
        {
            _calc = new SimpleClass();
        }

        [TestMethod]
        public void Test1()
        {
            int res = _calc.Add(5, 3);
            Console.WriteLine("Running Test1");
            Assert.AreEqual(res, 8);
            Console.WriteLine("Test1 passed");
        }

        [TestMethod]
        public void Test2()
        {
            int res = _calc.Sub(5, 3);
            Console.WriteLine("Running Test2");
            Assert.AreEqual(res, 2);
            Console.WriteLine("Test2 passed");
        }

        [TestMethod]
        public void Test3()
        {
            int res = _calc.Multiply(5, 3);
            Console.WriteLine("Running Test3");
            Assert.AreEqual(res, 15);
            Console.WriteLine("Test3 passed");
        }
    }
}
