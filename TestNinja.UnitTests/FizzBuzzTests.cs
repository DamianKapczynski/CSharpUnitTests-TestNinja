using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(11, "11")]
        public void GetOutput_WhenCalled_ReturnsProperValue(int input, string output)
        {
            var FizBuzz = new FizzBuzz();

            var result = FizzBuzz.GetOutput(input);

            Assert.That(result, Is.EqualTo(output));
        }
    }
}
