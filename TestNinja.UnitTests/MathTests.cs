using NUnit.Framework;
using System;
using System.Linq;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        //[Ignore("To simple")]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            var result = _math.Add(100, 541);

            Assert.AreEqual(result, 641);
        }

        [Test]
        [TestCase(5, 2, 5)]
        [TestCase(-5, 2, 2)]
        [TestCase(5, 5, 5)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.AreEqual(result, expectedResult);

        }

        [Test]
        [TestCase(5, new [] {1, 3, 5})]
        [TestCase(4, new [] {1, 3})]
        public void GetOddNumbers_WhenCalled_ReturnOddNumbersUpToLimit(int a, Array b)
        {
            var result = _math.GetOddNumbers(a);

            Assert.That(result, Is.EquivalentTo(b));
        }

        [Test]
        public void GetOddNumbers_LimitEqualToZero_ReturnEmptyList()
        {
            var result = _math.GetOddNumbers(0);

            Assert.That(result, Is.Empty);
        }
    }
}
