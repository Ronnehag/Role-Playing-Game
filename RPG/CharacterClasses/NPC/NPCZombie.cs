using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.CharacterClasses
{
    public class NPCZombie : NPCBase
    {
        // Fields
        private int _defaultStrength = 1;
        private int _defaultDexterity = 1;
        private int _defaultWisdom = 0;
        private int _defaultHealth = 8;
        private string _name = "Zombie";

        private int _zombieExp = 25;

        private int _zombieMinDmg = 1;
        private int _zombieMaxDmg = 4;


        // Constructor
        public NPCZombie() { }

        public NPCZombie(string name) : base (name)
        {
            name = _name;
            Strength = _defaultStrength;
            Dexterity = _defaultDexterity;
            Wisdom = _defaultWisdom;
            Health = _defaultHealth;
            ExperienceDrop = _zombieExp;

            _minDamage = _zombieMinDmg;
            _maxDamage = _zombieMaxDmg;
            
        }
        



    }
}
