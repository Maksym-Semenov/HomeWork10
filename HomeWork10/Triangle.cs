using System;

namespace HomeWork10
{
    public class Triangle
    {
        private Point p1, p2, p3;
        public Triangle(Point a, Point b, Point c)
        {
            p1 = a;
            p2 = b;
            p3 = c;
        }
        public double Distance(Point a, Point b)
        {
            double distance;
            return distance = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }
        public double Perimeter(Point a, Point b, Point c)
        {
            double AB = Distance(a, b);
            double BC = Distance(b, c);
            double AC = Distance(a, c);
            double perimeter;
            return perimeter = AB + BC + AC;
        }
        public double Square(Triangle t)
        {
            double temp = t.Perimeter(p1, p2, p3);
            double halfPerimeter = temp / 2;
            double square;
            return square = Math.Sqrt(halfPerimeter / 2 * (halfPerimeter - Distance(p1,p2)) * (halfPerimeter - Distance(p2, p3)) * (halfPerimeter - Distance(p1, p3)));
        }
        public void Print()
        {
            Console.WriteLine($"Triangle has 3 points: " +
                                $"point A (X = {p1.X}, Y = {p1.Y}), " +
                                $"point B (X = {p2.X}, Y = {p2.Y}), " +
                                $"point C (X = {p3.X}, Y = {p3.Y}) ");
        }
    }
}
