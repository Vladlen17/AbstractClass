using System.Security.Cryptography;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Shape shapeCircle = new Circle(3);
            Console.WriteLine("Площадь круга: " + shapeCircle.CalculateArea());
            Console.WriteLine("Периметр круга: " + shapeCircle.CalculatePerimeter());
            
            Shape shapeRectangle = new Rectangle(4, 3);
            Console.WriteLine("Площадь прямоугольника: " + shapeRectangle.CalculateArea());
            Console.WriteLine("Периметр прямоугольника: " + shapeRectangle.CalculatePerimeter());
        }
    }
}
