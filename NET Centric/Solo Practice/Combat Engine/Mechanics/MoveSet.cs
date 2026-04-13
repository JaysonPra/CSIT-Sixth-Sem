namespace Combat_Engine.Mechanics;

public record Attack(int Power, DamageType type, string Name);

public static class MoveSet
{
    public static readonly Attack Fireball = new(25, DamageType.Fire, "Fireball");
    public static readonly Attack Ice_Spike = new(10, DamageType.Ice, "Ice Spike");
    public static readonly Attack World_Slash = new(100, DamageType.True, "World Slash");
}