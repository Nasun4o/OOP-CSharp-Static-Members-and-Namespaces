using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point3D;

namespace Paths
{
    class Program
    {
        static void Main()
        {
            List<Point3D.Point3D> points = new List<Point3D.Point3D>();
            points.Add(new Point3D.Point3D(-9, 4, 3));
            points.Add(new Point3D.Point3D(-3, 4, 4));
            points.Add(new Point3D.Point3D(-2, 7, 2));
            points.Add(new Point3D.Point3D(-1, 6, 1));
            points.Add(new Point3D.Point3D(-6, 9, 3));
            Path3D path = new Path3D();
            Console.WriteLine("Writed: {0}{1}", Environment.NewLine, path);
            Storage.SavePathToFile("..\\..\\path.txt", path);
            Path3D pathFromFile = Storage.ReadPathFormFile("..\\..\\paths.txt");
            Console.WriteLine("Readed: {0}{1}", Environment.NewLine, pathFromFile);
        }
    }
}
