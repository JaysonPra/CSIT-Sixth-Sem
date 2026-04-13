namespace Combat_Engine.Entities;

using Combat_Engine.Mechanics;

abstract public class Entity : ITargetable
{
    public string Name { get; protected set; }
    public int Armour { get; protected set; }
    public int MaxHealth { get; protected set; }
    public Dictionary<DamageType, double> Resistences { get; set; } = [];

    private int _health;
    public int Health
    {
        get => _health;
        protected set => _health = Math.Clamp(value, 0, MaxHealth);
    }

    public Entity(int maxHealth, string name, int armour)
    {
        Name = name;
        Armour = armour;
        MaxHealth = Math.Max(1, maxHealth);
        Health = MaxHealth;
    }

    public bool IsDead => Health <= 0;

    public virtual void TakeDamage(int amount, DamageType type)
    {
        if (type == DamageType.True) { Health -= amount; return; }

        double multiplier = Resistences.ContainsKey(type) ? Resistences[type] : 1.0;
        double armourMultiplier = 100 / (100.0 + Armour);
        int finalDamage = (int)(amount * multiplier * armourMultiplier);

        Health -= finalDamage;
    }

    public void PerformAttack(ITargetable target, Attack move)
    {
        Console.WriteLine($"{Name} uses {move.Name} on {target.Name}");
        target.TakeDamage(move.Power, move.type);
    }
}