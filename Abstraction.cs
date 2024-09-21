public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Rectangle(double width, double height) : Shape
{
    public override global::System.Double CalculateArea()
    {
        return width * height;
    }
}