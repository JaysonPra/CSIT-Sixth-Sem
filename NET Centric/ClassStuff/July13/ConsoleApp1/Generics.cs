using System.Numerics;

namespace ConsoleApp1;

class Calculator<T>
{
    public void Sum<T1, T2>(T1 a, T2 b)
    {
        dynamic? x = a;
        dynamic? y = b;
        Console.WriteLine(x + y);
    }

    public void Diff<T1, T2>(T1 a, T2 b)
    {
        dynamic? x = a;
        dynamic? y = b;
        Console.WriteLine(x - y);
    }
}

public class Generics
{
    public static void Main()
    {
        Calculator<int> calc = new();
        calc.Sum(1, 2);
        calc.Diff(1, 2);

        Calculator<float> cac = new();
        cac.Sum(1.4f, 2.6f);
        cac.Diff(4.5f, 2.1f);
    }
}