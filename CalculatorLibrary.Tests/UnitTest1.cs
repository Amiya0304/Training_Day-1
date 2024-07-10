using NUnit.Framework;
using CalculatorLibrary;
using System;

namespace CalculatorLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_Case()
        {
            int result = calculator.Add(5, 3);

            Assert.AreEqual(8, result);
        }

        [Test]
        public void Subtract_Case()
        {
            int result = calculator.Subtract(5, 3);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Multiply_Case()
        {
            int result = calculator.Multiply(5, 3);

            Assert.AreEqual(15, result);
        }

        [Test]
        public void Divide_Case()
        { 
            int result = calculator.Divide(10, 2);

            Assert.AreEqual(5, result);
        }

        [Test]
        public void Divide_Case_ByZero()
        {
            Assert.Throws<ArgumentException>(() => calculator.Divide(10, 0));
        }
    }
}
