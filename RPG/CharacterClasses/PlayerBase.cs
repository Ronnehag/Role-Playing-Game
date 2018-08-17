using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RPG.CharacterClasses
{ 
    [XmlInclude(typeof(Berserker))]
    [XmlInclude(typeof(Shaman))]
    public class PlayerBase : IEntity
    {
        public static Type[] Types = new Type[] 
        {
            typeof(Shaman),
            typeof(Berserker)
        };

        

        #region Fields
        protected int _strengthFactor;
        protected int _dexterityFactor;
        protected int _wisdomFactor;
        protected int _healthFactor;
        protected Random rand = new Random();

        // Experience needed for lvl 2.
        // Method for level upp will increase this value, so level 3 needs more experience.
        // Set exp dropped from monsters in NPCBase and Subclasses.
        private int _experienceNeeded = 100;
        private int _currentExp = 0;

        protected int _minDamage;
        protected int _maxDamage;
        #endregion

        #region Properties
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Wisdom { get; set; }
        public int Health { get; set; } // -Add: make setter default to 0 if value goes negative
        public EntityGender Gender { get; set; }
        public EntityClass CharacterClass { get; set; }
        #endregion

        #region Constructors
        public PlayerBase() { }

        public PlayerBase(string name, EntityGender gender)
        {
            Name = name;
            Gender = gender;
        }
        #endregion

        #region Combat System
        public bool IsDead() => Health is 0;

        public void LevelUp(int points)
        {
            _currentExp += points;
            if(_currentExp >= _experienceNeeded)
            {
                // Level up here
            }
        }

        public int Attack()
        {
            _minDamage = _minDamage + Strength / 3;
            _maxDamage = _maxDamage + Strength / 3;

            if (!IsDead())
            {
                return rand.Next(_minDamage, _maxDamage);
            }
            return 0;
        }

        public void DecreaseHealth(int damage)
        {
            Health -= damage;
            Health = Math.Max(0, Health);
            // Sets health to 0 if it goes below.

        }
        #endregion
    }
}
