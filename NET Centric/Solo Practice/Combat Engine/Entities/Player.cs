using System.Diagnostics.Tracing;

namespace Combat_Engine.Entities;

public class Player : Entity
{
    private int _currentExp;
    public int MaxExp { get; protected set; }
    public int Level { get; protected set; }
    public int Exp
    {
        get => _currentExp;
        protected set
        {
            _currentExp = value;
            if (_currentExp >= MaxExp) { LevelUp(); }
        }
    }

    public Player(int maxHealth, string name, int armour) : base(maxHealth, name, armour)
    {
        Level = 1;
        MaxExp = 100;
        Exp = 0;
    }

    private void LevelUp()
    {
        Level++;
        Exp = 0;
        MaxExp += Level * 2;

        MaxHealth += 10;
        Health = MaxHealth;

        Console.WriteLine($"Player {Name} reached Level {Level}!");
    }

    public void GainExp(int gainedExp)
    {
        Console.WriteLine($"You have gained {gainedExp} EXP");
        Exp += gainedExp;
    }
}