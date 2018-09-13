using RPG.CharacterClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RPG.Items
{
    [XmlRoot(Namespace = "PlayerBase")]
    public class HealthPotion : Item, IConsumeable
    {
        private string _name = "Health Potion";
        private string _type = "Potion";
        private int _healthValue = 15;

        //private int _goldValue;

        // Creates new potion
        public HealthPotion()
        {
            Name = _name;
            Itemtype = _type;
            Consumeeffect = _healthValue;
        }

        public override void Use(PlayerBase player)
        {
            player.Health += Consumeeffect;
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
