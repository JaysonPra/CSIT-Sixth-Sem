namespace Combat_Engine.Entities;

abstract public class Entity
{
    public string Name { get; protected set; }
    public int Armour { get; protected set; }
    public int MaxHealth { get; protected set; }

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

    public virtual void TakeDamage(int amount)
    {
        var multiplier = 1.0 - (Armour / 100.0);
        Health -= (int)(amount * multiplier);
    }
}