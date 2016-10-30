namespace Shape {
  public abstract class Shape {
    private int shapeId;
    private static int count = 0;
    public Shape() {
      CreateId();
      shapeId = count;
    }
    private static void CreateId() {
      count++;
    }
    public int GetId() {
      return shapeId;
    }
    public abstract void Move(int moveXBy, int moveYBy, int moveZBy);
  }
}