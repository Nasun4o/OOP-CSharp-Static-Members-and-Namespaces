using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point3D;
using System.IO;
using System.Text.RegularExpressions;


namespace Paths
{
     static class Storage
    {
        private static Regex dataValidation = new Regex(@"^-?\d*.?\d*\s-?\d*.?\d*\s-?\d*.?\d*$");

        public static void SavePathToFile(string filePath, Path3D path)
        {
            if (Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(path.ToString());
                }
            }
            else
            {
                throw new ArgumentException("File path is not valid");

            }
        }

        public static Path3D ReadPathFormFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                Path3D path = new Path3D();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    List<Point3D.Point3D> point = new List<Point3D.Point3D>();
                    string line = string.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (dataValidation.Match(line).Success)
                        {
                            double[] cordinates = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToArray();
                            point.Add(new Point3D.Point3D(cordinates[0], cordinates[1], cordinates[2]));
                        }
                    }
                    path = new Path3D(point);
                }
                return path;
            }
            throw new ArgumentException("File path does not exist");
        }



    }
}
