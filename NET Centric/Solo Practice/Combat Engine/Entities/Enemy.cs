namespace Combat_Engine.Entities;

using Combat_Engine.Mechanics;

public class Enemy : Entity
{
    public Enemy(int maxHealth, string name, int armour, Dictionary<DamageType, double> startingResistances)
        : base(maxHealth, name, armour)
    {
        Resistences = startingResistances;
    }

}