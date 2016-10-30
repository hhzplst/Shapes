using System;

namespace Shape {
  public class Line : OneDimensionalShape {
    public Point From {get; set;}
    public Point To {get; set;}
    public Line(Point startPos, Point endPos) : base(){
      From = startPos;
      To = endPos;
    }
    public override void Move(int moveXBy, int moveYBy, int moveZBy) {
      From.Move(moveXBy, moveYBy, moveZBy);
      To.Move(moveXBy, moveYBy, moveZBy);
    }
    public override double GetLength() {
      return Math.Sqrt(Math.Pow((To.X - From.X), 2) + Math.Pow((To.Y - From.Y), 2) + Math.Pow((To.Z - From.Z), 2));
    }

    public override string ToString() {
      return $"Line ID : {GetId()}; Line starts at {From} and ends at {To}; Length: {GetLength():f} ";
    }
  }
}