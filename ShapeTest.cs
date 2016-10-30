using System;

namespace Shape {
  public class ShapeTest {
    public static void Main(string[] args) {
      Shape[] shapes = new Shape[]{
        new Point(1,2,3),
        new Line(new Point(0,0,0), new Point(4,4,4))
      };
      foreach (Shape s in shapes) {
        Console.WriteLine("*********************************");
        Console.WriteLine(s);
        s.Move(2,2,2);
        Console.WriteLine("Moving x, y, z coordinates by 2...");
        Console.WriteLine(s);
      }
    }
  }
  
}