using FigureCalculator.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator
{
    public class Triangle : IFigure
    {
        double side_1;
        double side_2;
        double side_3;
        

        public Triangle(double side_1, double side_2, double side_3)
        { 
            this.side_1 = side_1;
            this.side_2 = side_2;
            this.side_3 = side_3;
        }

        private double P => (side_1 + side_2 + side_3) / 2;

        public double CalculateArea()
        {
            return Math.Sqrt(P * (P - side_1) * (P - side_2) * (P - side_3));
        }
        public bool IsRightTriangle()
        {
            List<double> sides = new() { side_1, side_2, side_3 };

            sides.Sort();

            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }
    }
}
