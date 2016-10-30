namespace Shape {
  public class Point : ZeroDimensionalShape {
    public int X {get; set;}
    public int Y {get; set;}
    public int Z {get; set;}
    public Point(int x, int y, int z) : base() {
      X = x;
      Y = y;
      Z = z;
    }
    public override void Move(int moveXBy, int moveYBy, int moveZBy) {
      X = X + moveXBy;
      Y = Y + moveYBy;
      Z = Z + moveZBy;
    }
    public override string ToString() {
      return $"Point ID : {GetId()}, Location : ({X},{Y},{Z})";
    }
  }
}