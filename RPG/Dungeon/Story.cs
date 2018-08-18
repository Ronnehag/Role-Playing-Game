using RPG.CharacterClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dungeon
{
    public class Story
    {
        private List<string> _firstLine = new List<string> ();
        private string[] _directon = new string[4]
        {
            "North",
            "East",
            "South",
            "West"
        };

        public void GenerateDungeon(NPCBase enemy)
        {

        }

        public static string FightingNPC(PlayerBase player, NPCBase npc, int playerDmg, int npcDmg)
        {

            return player.Name + " striked the " + npc.Name + " across its body and caused a grievous wound! " + Environment.NewLine +
                player.Name + " inflicted " + playerDmg + " damage to the " + npc.Name + "!" + Environment.NewLine +
                npc.Name + " repelled the attack and hit " + player.Name + " back for " + npcDmg + " damage!";

        }
    }
}
