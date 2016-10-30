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
        Console.WriteLine("Moving x, y, z coordinates by 2...");
        Console.WriteLine(s);
        Console.WriteLine("\n");
      }
    }
  }
  
}