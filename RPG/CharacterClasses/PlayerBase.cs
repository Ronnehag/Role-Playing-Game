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
        public static Type[] Types = new Type[] { typeof(Shaman), typeof(Berserker) };

        #region Fields
        protected int _strengthFactor;
        protected int _dexterityFactor;
        protected int _wisdomFactor;
        protected int _healthFactor;
        #endregion

        #region Properties
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Wisdom { get; set; }
        public int Health { get; set; }
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

        #region Methods
        public virtual void LevelUp(int points)
        {
            // Set points to factors
        }
        #endregion
    }
}
