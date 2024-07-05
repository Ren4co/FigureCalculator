using FigureCalculator.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator.Tests
{
    [TestFixture]
    public class RandomFigureTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateAreaRandomFigureIsNotZero()
        {
            // arrange
            var random = new Random();
            int figureNumber = random.Next(1, 2);
            IFigure figure = figureNumber switch
            {
                1 => new Circle(3),
                2 => new Triangle(3, 4, 5),
            };

            // act
            var figureArea = figure.CalculateArea();

            // assert
            Assert.NotZero(figureArea);
        }
    }
}
