namespace ConsoleApp1;

class Father
{
    public string test = "hello";

    public Father(string name)
    {
        Console.WriteLine($"Name: {name}");
    }

    public virtual void Marriage() => Console.WriteLine("Arrange");
}

class Son : Father
{
    public new string test = "Namaste";

    public Son(string name, int age) : base(name)
    {
        Console.WriteLine($"Age: {age}");
    }

    public void DisplayInfo() => Console.WriteLine(test);

    public override void Marriage() => Console.WriteLine("Love");
}

class Daughter : Father
{
    public Daughter(string name) : base(name) { }
    public override void Marriage() => Console.WriteLine("Court");
}

internal class Program
{
    public static void Main()
    {
        // Using base
        Son son = new("Jayson", 5);
        son.DisplayInfo();

        // Dynamic Polymorphism + Runtime Binding + Late Binding
        Father p;
        p = new Father("Julen");
        p.Marriage();

        p = new Son("Aveg", 14);
        p.Marriage();

        p = new Daughter("Umesh");
        p.Marriage();
    }
}