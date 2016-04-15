# OOP-CSharp-Static-Members-and-Namespaces

Problem 1.	Point3D
Create a class Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Create appropriate constructors. Override ToString() to enable printing a 3D point.
Add a private static read-only field in the Point3D class to hold the start of the coordinate system – the point StartingPoint {0, 0, 0}. Add a static property to return the starting point.

Problem 2.	Distance Calculator
Write a static class DistanceCalculator with a static method to calculate the distance between two points in the 3D space. Search in Internet how to calculate distance in the 3D Euclidian space.

Problem 3.	Paths
Create a class Path3D to hold a sequence of points in 3D space. Create a static class Storage with static methods to save and load paths from a text file. Use a file format of your choice. Ensure you close correctly all files with the "using" statement.

Problem 4.	Namespaces
Design a group of classes to work with geometric figures. Put them into namespaces. You do not need to implement the classes, just create them and put them into namespaces. Make sure the files are placed in directories corresponding to the namespaces.
Namespace Geometry.Geometry2D holds classes:
•	Point2D
•	Figure2D
•	Square
•	Rectangle
•	Polygon
•	Circle
•	Ellipse
•	DistanceCalculator2D
Namespace Geometry.Geometry3D holds classes:
•	Point3D
•	Path3D
•	DistanceCalculator3D
Namespace Geometry.Storage holds classes:
•	GeometryXMLStorage
•	GeometryBinaryStorage
•	GeometrySVGStorage
Namespace Geometry.UI holds classes:
•	Screen2D
•	Screen3D
