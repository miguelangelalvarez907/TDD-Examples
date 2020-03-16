using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDD.Examples.CodeExamples;

namespace TDD.Unit.Tests
{
    [TestFixture]
    class FuzzBuzzyTests
    {
        private FizzBuzz fizzy;
        public FuzzBuzzyTests()
        {
            fizzy = new FizzBuzz();
        }

        [TestCase("Fizz", 3)]
        [TestCase("Fizz", 6)]
        [TestCase("Buzz", 5)]
        [TestCase("Buzz", 10)]
        [TestCase("FizzBuzz", 15)]
        [TestCase("FizzBuzz", 30)]
        [TestCase("", 7)]
        public void TestFizzBuzz(string expected, int number)
        {
            Assert.AreEqual(expected, fizzy.FizzBuzzy(number));
        }
    }
}
