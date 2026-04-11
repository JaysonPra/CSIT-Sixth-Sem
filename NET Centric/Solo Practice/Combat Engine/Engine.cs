namespace Combat_Engine;

using Combat_Engine.Entities;
using Combat_Engine.Mechanics;

class Program
{
    public static void Main()
    {
        Player hero = new(100, "Jayson", 20);

        Console.WriteLine("--- Initial Stats ---");
        Console.WriteLine($"{hero.Name} | HP: {hero.Health} | Level: {hero.Level}");

        Console.WriteLine("--- Combat Test ---");
        int rawDamage = 10;
        hero.TakeDamage(rawDamage);
        Console.WriteLine($"Ouch! You got hit! HP: {hero.Health}");

        Console.WriteLine("--- EXP Test ---");
        int gainedExp = 100;
        hero.GainExp(gainedExp);

        Console.WriteLine("--- Death Test ---");
        rawDamage = 1000;
        hero.TakeDamage(rawDamage);
        Console.WriteLine($"Ouch! You got hit! HP: {hero.Health}. Dead: {hero.IsDead}");
    }
}