namespace FigureCalculator.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateAreaIsCorrect()
        {
            // arrange
            var triangle = new Triangle(3, 4, 5);

            // act
            var result = triangle.CalculateArea();

            // assert
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void IsNotRightTriangle()
        {
            // arrange
            var triangle = new Triangle(1, 3, 5);

            // act
            var result = triangle.IsRightTriangle();

            // assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsRightTriangle()
        {
            // arrange
            var triangle = new Triangle(3, 4, 5);

            // act
            var result = triangle.IsRightTriangle();

            // assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CalculateAreaIsNaN()
        {
            // arrange
            var triangle = new Triangle(1, -1, 6);

            // act
            var result = triangle.CalculateArea();

            // assert
            Assert.That(result, Is.EqualTo(Double.NaN));
        }
    }
}