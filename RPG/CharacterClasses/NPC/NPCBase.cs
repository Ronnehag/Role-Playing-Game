using RPG.CharacterClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.CharacterClasses
{
    public class NPCBase : IEntity
    {
        protected Random rand = new Random();
        protected int _minDamage;
        protected int _maxDamage;
        protected int _expDrop;

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

        public NPCBase GetNewEnemy()
        {
         NPCBase[] _npcs = new NPCBase[]{
             new NPCZombie("Zombie") };

        Random rand = new Random();
            int next = rand.Next(0, _npcs.Length);

            if (_npcs != null)
            {
                return _npcs[next];
            }
            return null;
        }

        #endregion

        #region Combat Methods
        public bool IsDead() => Health is 0;

        public int Attack()
        {
            if (!IsDead())
            {
                return rand.Next(_minDamage, _maxDamage);
            }
            return 0;
        }

        public int DecreaseHealth(int damage)
        {
            Health -= damage;
            Health = Math.Max(0, Health); // Sets health to 0 if it goes below.

            if (IsDead())
            {
                return _expDrop; // Drop exp if dead

            }

            else return 0;
            
        }



        // Add method, NPC is defeated.
        // Give experience?


        #endregion

    }
}
