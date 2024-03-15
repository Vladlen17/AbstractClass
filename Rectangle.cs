using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Rectangle : Shape
    {
        private double _width;
        private double _height;
        public Rectangle(double width, double height) 
        { 
            _width = width;
            _height = height;
        }
        public double Width { get => _width; set => _width = value; }
        public double Height { get => _height; set => _height = value; }

        public override double CalculateArea() => Width * Height;

        public override double CalculatePerimeter() => 2 * (Width + Height);
    }
}
