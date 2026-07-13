namespace ConsoleApp1;

public delegate void AddDelegate(int x, int y);
public delegate string GreetingDelegate(string str);

internal class Program
{
    public void AddNumbers(int a, int b) => Console.WriteLine($"\tSum = {a + b}");
    public static string Greeting(string name) => $"\tHello {name}, Namaste!";
    public static void Main()
    {
        // Delegates
        Program dd = new();
        AddDelegate ad = new(dd.AddNumbers); // Method 1 of setting target method
        GreetingDelegate gd = Greeting; // Method 2 of setting target method

        ad.Invoke(23, 73);
        string msg = gd("Jayson");
        Console.WriteLine(msg);

        // Multicasting Delegates
        // You can add multiple functions to a delegate and invoke all of them parallely
    }
}