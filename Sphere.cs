using System;

namespace Shape {
  public class Sphere : ThreeDimensionalShape {
    public Point Center {get; set;}
    public double Radius {get; set;}
    public Sphere(Point center, double radius) : base() {
      Center = center;
      Radius = radius;
    }
    public override double GetArea() {
      return 4 * Math.PI * Radius * Radius;
    }
    public override double GetVolume() {
      return (4.0 / 3) * Math.PI * Radius * Radius * Radius;
    }
    public override void Move(int moveXBy, int moveYBy, int moveZBy) {
      Center.Move(moveXBy, moveYBy, moveZBy);
    }

    public override string ToString() {
      return $"Sphere ID : {GetId()}; Sphere locates at {Center} with radius {Radius}; Area: {GetArea():f}; Volume: {GetVolume():f}";
    }
  }
}