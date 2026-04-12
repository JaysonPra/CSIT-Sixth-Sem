namespace Combat_Engine.Entities;

public class Enemy : Entity
{
    public Enemy(int maxHealth, string name, int armour, Dictionary<DamageType, double> startingResistances)
        : base(maxHealth, name, armour)
    {
        Resistences = startingResistances;
    }

}