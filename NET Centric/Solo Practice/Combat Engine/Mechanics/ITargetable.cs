namespace Combat_Engine.Mechanics;

public interface ITargetable
{
    string Name { get; }
    void TakeDamage(int amount, DamageType type);
}