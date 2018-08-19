using RPG.CharacterClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Items
{
    public class HealthPotion : IItem
    {
        public string Name { get; set; } = "Health Potion";
        public string Type { get; set; } = "Potion";
        public int MinDamage { get; set; } = 0;
        public int MaxDamage { get; set; } = 0;
        public int Defense { get; set; } = 0;

        public int Healing { get; set; }

        private int _healthValue = 15;

        // Creates new potion
        public HealthPotion()
        {
            Healing = _healthValue;
        }

        public void Use(PlayerBase player)
        {
            player.Health += Healing;
        }

        public void Sell()
        {
            // Later add sell function, set gold value private int.
        }
    }
}
