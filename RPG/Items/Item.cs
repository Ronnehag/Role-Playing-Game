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
    public class Item : IItem
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Defense { get; set; }

        public Item()
        {

        }


        public void Sell() { }
        public void Use(PlayerBase player) { }
    }
}
