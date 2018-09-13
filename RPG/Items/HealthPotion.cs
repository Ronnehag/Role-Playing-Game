﻿using RPG.CharacterClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RPG.Items
{
    [XmlRoot(Namespace = "PlayerBase")]
    public class HealthPotion : Item
    {
        private string _name = "Health Potion";
        private string _type = "Potion";
        private int _minDamage = 0;
        private int _maxDamage = 0;
        private int _defense = 0;


        public int Healing { get; set; }

        private int _healthValue = 15;

        // Creates new potion
        public HealthPotion()
        {
            Name = _name;
            Type = _type;

            Healing = _healthValue;
        }

        public void Use(PlayerBase player)
        {
            player.Health += Healing;
            if(player.Health > player.maxHealth)
            {
                player.Health = player.maxHealth;
            }
        }

        public void Sell()
        {
            // Later add sell function, set gold value private int.
        }
    }
}
