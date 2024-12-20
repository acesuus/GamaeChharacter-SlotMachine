using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacterWinForms.Models
{ 
 class Mage : GameCharacter
{
    public int spellPower = 10;

    public Mage(string name, int level, int health, int mana, int intelligence, int spellpower) : base(name, level, health, mana, 0, intelligence)
    {
        spellPower = spellpower;

    }

    public override void Attack()
    {
        int MagicDamage = Intelligence * 3 + spellPower;
        bool haBurningEffect = _random.Next(99) < 25;
        string isBurned = haBurningEffect ? "with burning effect" : "without burning effect";
        Console.WriteLine($"Name: {Name} deals {MagicDamage}dmg {isBurned}.");

    }

    public override void Defending()
    {
        int dmgReduction = Mana / 4;
        bool isEvaded = _random.Next(99) < 20;
        if (isEvaded)
        {
            Console.WriteLine($"{Name} evades the attack completely!");
        }
        else
        {
            Console.WriteLine($"{Name} reduces the damage by {dmgReduction}.");
        }


    }


    public override void LevelUp()
    {
        Level += 1;
        Intelligence += 5;
        Mana += 15;
        spellPower += 3;
        Console.WriteLine($"Name: {Name} leveled up to {Level}, intelligence increase to {Intelligence}, mana increased to {Mana}, spellpower increased to {spellPower}");



    }


    public override string ToString()
    {
        return $"{Name}: Level {Level}, Health {Health}, Mana {Mana}, Intelligence {Intelligence}, Spell Power {spellPower}";
    }
}

}