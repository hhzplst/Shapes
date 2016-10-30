using System;

namespace Shape {
  public class Circle : TwoDimensionalShape {
    public Point Center {get; set;}
    public double Radius {get; set;} 
    public Circle(Point center, double radius) : base(){
      Center = center;
      Radius = radius;
    }
    public override double GetArea() {
      return Math.PI * Radius * Radius;
    }
    public override void Move(int moveXBy, int moveYBy, int moveZBy) {
      Center.Move(moveXBy, moveYBy, moveZBy);
    }

    public override string ToString() {
      return $"Circle ID : {GetId()}; Circle locates at {Center} with radius {Radius}; Area: {GetArea():f}";
    }
  }
}