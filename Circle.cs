using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Circle : Shape
    {
        private double _radius;
        public double Radius { get => _radius; set => _radius = value; }
        public Circle(double radius) 
        {
            _radius = radius;
        }
        public override double CalculateArea() => Math.PI * Radius * Radius;

        public override double CalculatePerimeter() => 2 * Math.PI * Radius;
    }
}
