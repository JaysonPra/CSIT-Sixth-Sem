namespace Combat_Engine.Entities;

abstract class Entity
{
    private int _health;
    private int _maxHealth;

    public Entity(int maxHealth, string name, int armour)
    {
        Health = MaxHealth = maxHealth;
        Name = name;
        Armour = armour;
    }

    public int Armour { get; protected set; }

    public string Name { get; protected set; }
    public int MaxHealth
    {
        get => _maxHealth;
        protected set => _maxHealth = value > 0 ? value : 1;
    }

    public int Health
    {
        get => _health;
        protected set => _health = Math.Clamp(value, 0, MaxHealth);
    }

    public bool IsDead => _health <= 0;

    public virtual void TakeDamage(int amount)
    {
        double damageMultiplier = 1.0 - (Armour / 100.0);
        int finalDamage = (int)(amount * damageMultiplier);
        Health -= finalDamage;
    }
}