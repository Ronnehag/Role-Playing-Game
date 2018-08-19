using RPG.CharacterClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Items
{
    public interface IItem
    {
       string Name { get; set; }
       string Type { get; set; }
       int MinDamage { get; set; }
       int MaxDamage { get; set; }
       int Defense { get; set; }

        void Sell();
        void Use(PlayerBase player);
        
    }
}
