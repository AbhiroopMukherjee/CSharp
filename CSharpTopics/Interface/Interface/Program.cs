using System;
using Polygons.Library;

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPolygon("Square", square);

            var triangle = new Triangle(6);
            DisplayPolygon("Triangle",triangle);

            var octagon = new Octagon(6);
            DisplayPolygon("Octagon", octagon);

            Console.ReadLine();
        }

        private static void DisplayPolygon(string polygonType, dynamic polygon)
        {
            Console.WriteLine(polygonType + " Number of sides: "+polygon.NumberOfSides);
            Console.WriteLine(polygonType + " Side Length: " + polygon.SideLength);
            Console.WriteLine(polygonType + " Perimeter: " + polygon.GetPerimeter());
            Console.WriteLine(polygonType + " Area: " + polygon.GetArea());

        }
    }
}
