using System;
using Point3D;


namespace DistanceCalculator
{
    class Program
    {
     public  static void Main()
        {
            Point3D.Point3D point1 = new Point3D.Point3D(4, -7, 3.2);
            Point3D.Point3D point2 = new Point3D.Point3D(13, 2.12, 8);
            Console.WriteLine(DistanceCalculator.CalculateDistance(point1 , point2));

            Point3D.Point3D point3 = new Point3D.Point3D(-3.4, 2, -7);
            Point3D.Point3D point4 = new Point3D.Point3D(4, 2, 4.7);
            Console.WriteLine(DistanceCalculator.CalculateDistance(point3, point4));

        }
    }
}
