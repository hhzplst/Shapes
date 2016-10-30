namespace Shape {
  public abstract class ThreeDimensionalShape : Shape {
    public ThreeDimensionalShape() : base(){}
    public abstract double GetArea();
    public abstract double GetVolume();
  }
}