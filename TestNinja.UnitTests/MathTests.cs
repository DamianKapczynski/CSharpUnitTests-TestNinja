using NUnit.Framework;
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
    }
}
