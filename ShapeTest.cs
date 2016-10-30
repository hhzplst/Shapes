using System;

namespace Shape {
  public class ShapeTest {
    public static void Main(string[] args) {
      Shape[] shapes = new Shape[]{
        new Point(1,2,3),
        new Line(new Point(0,0,0), new Point(4,4,4)),
        new Circle(new Point(3,3,3), 3),
        new Sphere(new Point(5,5,5), 2)
      };
      foreach (Shape s in shapes) {
        Console.WriteLine(s);
        s.Move(1,4,7);
        Console.WriteLine("Moving x, y, z coordinates by 1,4,7 respectively...");
        Console.WriteLine(s);
        Console.WriteLine("\n");
      }
    }
  }
}

/**************************************TEST OUTPUT****************************************

Point ID : 1, Location : (1,2,3)
Moving x, y, z coordinates by 1,4,7 respectively...
Point ID : 1, Location : (2,6,10)


Line ID : 4; Line starts at Point ID : 2, Location : (0,0,0) and ends at Point ID : 3, Location : (4,4,4); Length: 6.928 
Moving x, y, z coordinates by 1,4,7 respectively...
Line ID : 4; Line starts at Point ID : 2, Location : (1,4,7) and ends at Point ID : 3, Location : (5,8,11); Length: 6.928 


Circle ID : 6; Circle locates at Point ID : 5, Location : (3,3,3) with radius 3; Area: 28.274
Moving x, y, z coordinates by 1,4,7 respectively...
Circle ID : 6; Circle locates at Point ID : 5, Location : (4,7,10) with radius 3; Area: 28.274


Sphere ID : 8; Sphere locates at Point ID : 7, Location : (5,5,5) with radius 2; Area: 50.265; Volume: 33.510
Moving x, y, z coordinates by 1,4,7 respectively...
Sphere ID : 8; Sphere locates at Point ID : 7, Location : (6,9,12) with radius 2; Area: 50.265; Volume: 33.510


*************************************TEST OUTPUT END**************************************/