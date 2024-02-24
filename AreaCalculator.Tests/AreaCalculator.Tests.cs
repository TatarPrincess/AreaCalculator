using FluentAssertions;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class AreaCalculatorTests
    {
        [Test]
        public void TestAreaCalculatorForTheCircleReturnsCorrectValue()
        {
            Circle circle = new Circle(10);
            AreaCalculator areaCalculator = new(circle);

            double actualCircleArea = areaCalculator.Calculate();
            double expectedCircleArea = Math.Round(Math.PI * 10 * 10, 2, MidpointRounding.AwayFromZero);
            
            actualCircleArea.Should().BeInRange(314.16, expectedCircleArea);
        }

        [Test]
        public void TestAreaCalculatorForTheTriangleReturnsCorrectValue()
        {
            Triangle triangle = new Triangle(6, 8, 10);
            AreaCalculator areaCalculator = new(triangle);

            double actualCircleArea = areaCalculator.Calculate();
            double expectedCircleArea = Math.Round((double)(12 * (12 -6) * (12 - 8) * (12 - 10)), 2, MidpointRounding.AwayFromZero);

            actualCircleArea.Should().BeInRange(24, expectedCircleArea);
        }
        
        [Test]
        public void TestAreaCalculatorForTheTriangleWithZeroSideThrows()
        {
            Action act = () => new Triangle(6, 8, 0);
            act.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}