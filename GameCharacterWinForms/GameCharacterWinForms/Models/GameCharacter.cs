using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacterWinForms.Models

{

    abstract class GameCharacter
    {
        public static Random _random = new Random();
        private string _name;
        private int _level;
        private int _health;
        private int _mana;
        private int _strength;
        private int _intelligence;


        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value), "Name cannot be null.");
        }

        public int Level
        {
            get { return _level; }
            set => _level = value;
        }
        public int Health
        {
            get => _health;
            set => _health = value;
        }
        public int Mana
        {
            get => _mana;
            set => _mana = value;
        }

        public int Strength
        {
            get => _strength;
            set => _strength = value;
        }

        public int Intelligence
        {
            get => _intelligence;
            set => _intelligence = value;
        }



        protected GameCharacter(string name, int level, int health, int mana, int strength, int intelligence)
        {
            Name = name;
            Level = level;
            Health = health;
            Mana = mana;
            Strength = strength;
            Intelligence = intelligence;
        }

        public abstract void Attack();
        public abstract void Defending();
        public abstract void LevelUp();




    }
    }