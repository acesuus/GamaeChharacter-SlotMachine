using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacterWinForms.Models
{ 
    class Warrior : GameCharacter
{
    public int Armor = 10;

    public Warrior(string name, int level, int health, int strength, int armor) : base(name, level, health, 0, strength, 0)
    {
        Armor = armor;
    }

    public override void Attack()
    {
        int BaseDamage = Strength * 2;
        bool isCriticalHit = _random.Next(100) < 20;
        int finalDamage = isCriticalHit ? BaseDamage * 2 : BaseDamage;

        Console.WriteLine($"{Name}, Damage Dealed: {finalDamage}, CriticalHit: {isCriticalHit}. ");
    }

    public override void Defending()
    {
        int DamageReduction = Armor / 2;
        bool isBlocked = _random.Next(99) < 15;
        if (isBlocked)
        {
            Console.WriteLine($"{Name} blocks the attack completely!");
        }
        else
        {
            Console.WriteLine($"{Name} reduces the damage by {DamageReduction} points.");
        }
    }




    public override void LevelUp()
    {
        Level += 1;
        Strength += 5;
        Health += 20;
        Armor += 2;
        Console.WriteLine($"Name: {Name} Leveled up to {Level} and Strength, Health and Armor increased.  ");

    }

    public override string ToString()
    {
        return $"{Name}: Level {Level}, Health {Health}, Strength {Strength}, Armor {Armor}";
    }

}
}