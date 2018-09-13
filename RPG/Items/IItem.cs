﻿using RPG.CharacterClasses;
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
       string Itemtype { get; set; }

        void Sell();
        void Use(PlayerBase player);
        
    }
}
