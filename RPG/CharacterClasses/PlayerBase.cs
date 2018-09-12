using RPG.Data;
using RPG.Items;
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
    [XmlInclude(typeof(Item))]
    [XmlInclude(typeof(HealthPotion))]
    public class PlayerBase : IEntity
    {
        public static Type[] Types = new Type[] 
        {
            typeof(Shaman),
            typeof(Berserker)
        };
        protected Random rand = new Random();

        #region Fields
        protected int strengthFactor;
        protected int dexterityFactor;
        protected int wisdomFactor;
        protected int healthFactor;
        protected int _health;
        public int maxHealth;

        // Experience needed for lvl 2.
        // Method for level upp will increase this value, so level 3 needs more experience.
        // Set exp dropped from monsters in NPCBase and Subclasses.
        public int experienceNeeded = 100;
        protected int _levelDefault = 1;
        protected int _minDamage;
        protected int _maxDamage;
        protected int _defaultSlots = 8;
        #endregion

        #region Properties
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Wisdom { get; set; }
        public int Experience { get; set; } = 0;
        public int Level { get; set; }
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value < 0) _health = 0;
                else _health = value;
                
            }
        }
        public Item[] Inventory { get; set; }
        public EntityGender Gender { get; set; }
        public EntityClass CharacterClass { get; set; }
   
        #endregion

        #region Constructors
        public PlayerBase() { }

        public PlayerBase(string name, EntityGender gender, Item[] inventory)
        {
            Name = name;
            Gender = gender;
            Level = _levelDefault;
            Inventory = inventory;
        }
        #endregion

        #region Combat System
        public bool IsDead() => Health is 0;
        public bool LevelUp() => Experience >= experienceNeeded;

        public void ExperienceGain(int points)
        {
            Experience += points;
            if(LevelUp())
            {
                // Level up here, placeholder variables, add stats yourself?
                Strength += 2;
                Wisdom += 2;
                Dexterity += 2;
                Health += 5;
                maxHealth = Health;
                Level += 1;
            }
            
        }

        public int Attack()
        {
            _minDamage = _minDamage + Strength / 3;
            _maxDamage = _maxDamage + Strength / 3;

            if (!IsDead())
            {
                return rand.Next(_minDamage, _maxDamage+1);
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

        #region Inventory
        //public string[] ShowInventory()
        //{



            
        //}


        public string AddItem(Item loot)
        {
            string msg = "";

            for (int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i] != null)
                {
                    Inventory[i] = loot;
                    msg = loot.Name + " is added to your inventory";
                }
                else
                {
                    msg = "Inventory is full";
                }
            }
            return msg;
        }

        #endregion
    }
}
