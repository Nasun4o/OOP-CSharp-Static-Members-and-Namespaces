using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Point3D
{
    class Program
    {
        static void Main()
        {
            Point3D point1 = new Point3D(1, 1, 1);
            Point3D point2 = new Point3D(-3, 4.12, 7);
            Console.WriteLine(point1);
            Console.WriteLine(point2);
            Console.WriteLine(Point3D.StartingPoint());
        }
    }
}
