using RPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RPG.CharacterClasses
{
    [XmlRoot(Namespace = "PlayerBase")]
    public class Shaman : PlayerBase
    {
        #region Fields
        private int _baseStrength = 5;
        private int _baseDexterity = 5;
        private int _baseWisdom = 10;
        private int _baseHealth = 20;

        private Item[] _inventory = new Item[] { new HealthPotion(), new HealthPotion(), new HealthPotion() };

        private int _minDmg = 2;
        private int _maxDmg = 6;
        #endregion

        #region Constructors
        public Shaman()
        {
            CharacterClass = EntityClass.Shaman;
            Strength = _baseStrength;
            Dexterity = _baseDexterity;
            Wisdom = _baseWisdom;
            maxHealth = _baseHealth;
            Health = _baseHealth;

            _minDamage = _minDmg;
            _maxDamage = _maxDmg;
        }

        public Shaman(string name, EntityGender gender, Item[] inventory) : base(name, gender, inventory)
        {
            CharacterClass = EntityClass.Shaman;
            Strength = _baseStrength;
            Dexterity = _baseDexterity;
            Wisdom = _baseWisdom;
            Health = _baseHealth;
            maxHealth = _baseHealth;

            inventory = _inventory;



            _minDamage = _minDmg;
            _maxDamage = _maxDmg;
        }
        #endregion


    }

}
