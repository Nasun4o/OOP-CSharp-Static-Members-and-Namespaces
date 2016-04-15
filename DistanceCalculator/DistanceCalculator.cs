using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point3D;


namespace DistanceCalculator
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D.Point3D firstPoint, Point3D.Point3D secondPoint)
        {
            double distance = Math.Sqrt(secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X) +
                                        (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y) +
                                        (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z);
            return distance;
        }

    }
}
