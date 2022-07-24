using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork10;
using Point = HomeWork10.Point;

namespace TestHomeWork10
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestDistance(Point point1, Point point2)
        {
            //arrenge
            Point p1 = new Point(5, 2);
            Point p2 = new Point(2, 5);
            double expected = 12.488851938354607;
            //actual
            double actual = Distance(p1, p2);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPerimeter(Point point1, Point point2, Point point3)
        {
            //arrenge
            Point p1 = new Point(5, 2);
            Point p2 = new Point(2, 5);
            Point p3 = new Point(6, 6);
            double expected = 5.03;
            //actual
            //double actual = Perimeter(p1, p2, p3);
            //assert
            //Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSquare(Triangle tr)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(2, 5);
            Point p3 = new Point(6, 6);
            Triangle t = new Triangle(p1, p2, p3);
            double expected = 50.3;
            //double actual = Square(t);
            //Assert.AreEqual(expected, actual); 
        }
    }
}
