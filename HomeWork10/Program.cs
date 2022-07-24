using System;

namespace HomeWork10
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(5, 2);
            Point point2 = new Point(2, 5);
            Point point3 = new Point(6, 6);
            Triangle triangle = new Triangle(point1, point2, point3);
            triangle.Print();
            Console.WriteLine(triangle.ToString());
            Console.ReadLine();
            double resultPerimeter = triangle.Perimeter(point1, point2, point3);
            Console.WriteLine($"Triangle perimeter is {resultPerimeter}");
            Console.ReadLine();
            double resultSquare = triangle.Square(triangle);
            Console.WriteLine($"Triangle square is {resultSquare}");
            Console.ReadLine();
        }
    }
}
