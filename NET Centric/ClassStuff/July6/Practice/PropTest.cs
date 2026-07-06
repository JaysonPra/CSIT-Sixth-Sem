namespace Practice;

class Circle
{
    private double _radius;

    public double Radius
    {
        get => _radius;
        set => _radius = value;
    }
}

internal class PropTest
{
    static void Main()
    {
        Circle c1 = new();

        c1.Radius = 5;
        Console.WriteLine(c1.Radius);
    }
}
