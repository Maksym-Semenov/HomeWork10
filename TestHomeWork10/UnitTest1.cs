using Microsoft.VisualStudio.TestTools.UnitTesting;
using Point = HomeWork10.Point;

namespace TestHomeWork10
{
    [TestClass]
    public class Triangle
    {
        [TestMethod]
        public void Perimeter(Point point1, Point point2, Point point3)
        {
            //arrenge
           
            double expected = 12.488851938354607;
            //return expected; //5,303300858899108

            //actual
            Point a = new Point(5, 2);
            Point b = new Point(2, 5);
            Point c = new Point(6, 6);
            Triangle triangle = new Triangle();
            double result;
            triangle.Perimeter(a, b, c);



            //assert
            //Assert.Equals(expected, result);
        }

    }
}
