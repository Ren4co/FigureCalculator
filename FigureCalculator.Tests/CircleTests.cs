using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateAreaIsCorrect()
        {
            // arrange
            var circle = new Circle(5);

            // act
            var result = circle.CalculateArea();

            // assert
            Assert.That(result, Is.EqualTo(78.5).Within(0.5));
        }
    }
}
