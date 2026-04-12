namespace Combat_Engine.EnemyFactory;

using Combat_Engine.Entities;

public enum EnemyType { BlueSlime, IronGolem, FireBat }

public static class Spawner
{
    public static Enemy Spawn(EnemyType type)
    {
        return type switch
        {
            EnemyType.BlueSlime => new Enemy(100, "Blue Slime", 0, new() { { DamageType.Fire, 2.0 } }),
            EnemyType.FireBat => new Enemy(50, "Fire Bat", 0, new() { { DamageType.Ice, 2.0 } }),
            EnemyType.IronGolem => new Enemy(300, "Iron Golem", 50, new() { { DamageType.Physical, 0.5 } }),
            _ => throw new ArgumentException("I don't know what that enemy is!")
        };
    }
}
