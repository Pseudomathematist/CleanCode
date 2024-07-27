3.1
  public class Rectangle
  {
    private double width;
    private double height;

    private Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public static Rectangle CreateSquare(double side)
    {
        return new Rectangle(side, side);
    }

    public static Rectangle CreateRectangle(double width, double height)
    {
        return new Rectangle(width, height);
    }
}
//
