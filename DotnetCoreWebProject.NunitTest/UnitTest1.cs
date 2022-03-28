using NUnit.Framework;
using System;

namespace DotnetCoreWebProject.NunitTest
{
    public class Tests
    {
        SimpleClass _calc;

        [SetUp]
        public void Setup()
        {
            _calc = new SimpleClass();
        }

        [Test]
        public void Test1()
        {
            int res = _calc.Add(5, 3);
            Console.WriteLine("Running Test1");
            Assert.AreEqual(res, 8);
            Console.WriteLine("Test1 passed");
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            int res = _calc.Sub(5, 3);
            Console.WriteLine("Running Test2");
            Assert.AreEqual(res, 2);
            Console.WriteLine("Test2 passed");
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            int res = _calc.Multiply(5, 3);
            Console.WriteLine("Running Test3");
            Assert.AreEqual(res, 15);
            Console.WriteLine("Test3 passed");
            Assert.Pass();
        }
    }
}