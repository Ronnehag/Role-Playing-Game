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
    }
}
