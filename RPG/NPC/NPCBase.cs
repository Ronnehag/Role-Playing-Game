using RPG.CharacterClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.NPC
{
    class NPCBase : IEntity
    {

        #region Properties
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Wisdom { get; set; }
        public int Health { get; set; }
        public EntityGender Gender { get; set; } = EntityGender.Unknown;
        public EntityClass CharacterClass { get; set; } = EntityClass.Unknown;
        #endregion

        #region Constructors
        public NPCBase() { }

        public NPCBase(string name)
        {
            Name = name;
        }
        #endregion

        #region General Methods

        public static NPCBase GetNewEnemy()
        {
            NPCBase[] npcs = new NPCBase[1] // Add NPCs here
            {
                new NPCZombie("Zombie")
            };

            Random rand = new Random();
            int next = rand.Next(0, npcs.Length);

            if (npcs != null)
            {
                return npcs[next];
            }
            return null;
        }

        #endregion


        #region Combat
        public bool IsDead() => Health is 0;

        public int Attack(int minDamage, int maxDamage)
        {
            if (!IsDead())
            {
                Random rand = new Random();
                return rand.Next(minDamage, maxDamage);
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
