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
        // Fields
        private int _baseStrength = 5;
        private int _baseDexterity = 5;
        private int _baseWisdom = 10;
        private int _baseHealth = 20;

        // Base Constructor
        public Shaman()
        {
            CharacterClass = EntityClass.Shaman;
            Strength = _baseStrength;
            Dexterity = _baseDexterity;
            Wisdom = _baseWisdom;
            Health = _baseHealth;
        }

        // Constructor
        public Shaman(string name, EntityGender gender) : base (name, gender)
        {
            CharacterClass = EntityClass.Shaman;
            Strength = _baseStrength;
            Dexterity = _baseDexterity;
            Wisdom = _baseWisdom;
            Health = _baseHealth;
        }

    }

}
