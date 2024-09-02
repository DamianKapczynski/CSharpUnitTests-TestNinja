using NUnit.Framework;
using TestNinja.Fundamentals;
using System;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _DemeritPointsCalculator;

        [SetUp]
        public void SetUp()
        {
            _DemeritPointsCalculator = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(100,7)]
        [TestCase(0, 0)]
        [TestCase(60, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        public void CalculateDemeritPoints_WhenCalledWithSpeedInLimit_ReturnsDemeritPoints(int speed, int points)
        {
            var result = _DemeritPointsCalculator.CalculateDemeritPoints(speed);
            Assert.AreEqual(result, points);
        }

        [Test]
        public void CalculateDemeritPoints_SpeedUnder0_ReturnsOutOfRangeException()
        {
            Assert.That(() => _DemeritPointsCalculator.CalculateDemeritPoints(-10), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void CalculateDemeritPoints_SpeedOver300_ReturnsOutOfRangeException()
        {
            Assert.That(() => _DemeritPointsCalculator.CalculateDemeritPoints(1000), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
