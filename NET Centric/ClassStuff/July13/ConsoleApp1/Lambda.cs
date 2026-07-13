namespace ConsoleApp1;

public delegate void GreetDelegate(string n);

public class Lambda
{
    public static void Main()
    {
        Lambda demo = new();

        // Expression Lambda
        GreetDelegate gd = (n) => Console.WriteLine($"Namaste, {n}");

        // Statement Lambda
        GreetDelegate gd1 = (n) =>
        {
            Console.WriteLine($"Namaste, {n}");
            Console.WriteLine("How are you?");
        };

        gd("Jayson");
    }
}