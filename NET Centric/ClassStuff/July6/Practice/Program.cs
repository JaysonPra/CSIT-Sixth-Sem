namespace Practice;

public class Box
{
    double length, breadth, height;
    static int count = 0;

    public Box(double l, double b, double h)
    {
        Console.WriteLine("Hello from Parameterized Constructor!");
        length = l;
        breadth = b;
        height = h;
        count += 1;
    }

    static Box()
    {
        count = 100;
        Console.WriteLine("Hello from Static Constructor!");
    }

    public void DisplayValues()
    {
        Console.WriteLine($"Length: {length} | Breadth: {breadth} | Height: {height}");
    }

    public static void DisplayCount()
    {
        Console.WriteLine($"Count = {count}");
    }

    public static void Main()
    {
        Console.WriteLine("Hello from Main function!");
        Box.DisplayCount();
        Box box1 = new(10, 5, 15);
        box1.DisplayValues();
        Box.DisplayCount();
    }
}

