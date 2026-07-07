namespace ConsoleApp1;

abstract class Shape
{
    protected double dim1, dim2;
    public abstract void Area();
}

class Rectangle : Shape
{
    public Rectangle(double l, double b)
    {
        dim1 = l;
        dim2 = b;
    }
    public override void Area() => Console.WriteLine($"Area of rectangle: {dim1 * dim2}");
}

class Triangle : Shape
{
    public Triangle(double b, double h)
    {
        dim1 = b;
        dim2 = h;
    }

    public override void Area() => Console.WriteLine($"Area of triangle: {0.5 * dim1 * dim2}");
}

internal class Abstraction
{
    public static void Main()
    {
        Rectangle rect1 = new(15, 10);
        rect1.Area();

        Triangle tri1 = new(5, 10);
        tri1.Area();

        Shape[] shapes =
        {
            new Rectangle(3.5, 5),
            new Triangle(5, 10)
        };

        foreach (var s in shapes) { s.Area(); }
    }
}