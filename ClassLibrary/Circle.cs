using FigureCalculator.Contracts;

namespace FigureCalculator
{
    public class Circle : IFigure
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
