using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RPG.Items;

namespace RPG.CharacterClasses
{
    [XmlRoot(Namespace = "PlayerBase")]
    public class Berserker : PlayerBase
    {
        // Fields
        private int _baseStrength = 10;
        private int _baseDexterity = 5;
        private int _baseWisdom = 5;
        private int _baseHealth = 25;


        // Base Constructor, default stats
        public Berserker()
        {
            CharacterClass = EntityClass.Berserker;
            Strength = _baseStrength;
            Dexterity = _baseDexterity;
            Wisdom = _baseWisdom;
            Health = _baseHealth;
        }

        // Constructor for character creation
        public Berserker(string name, EntityGender gender, Item[] inventory) : base (name, gender, inventory)
        {
            CharacterClass = EntityClass.Berserker;
            Strength = _baseStrength;
            Dexterity = _baseDexterity;
            Wisdom = _baseWisdom;
            Health = _baseHealth;
        }

    }
}
