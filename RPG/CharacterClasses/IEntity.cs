using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.CharacterClasses
{
    public enum EntityGender { Male, Female, Unknown };
    public enum EntityClass { Shaman, Berserker, Rogue, Warrior, Wizard, Unknown };

    interface IEntity
    {
        string Name { get; }
        int Strength { get; set; }
        int Dexterity { get; set; }
        int Wisdom { get; set; }
        int Health { get; set; }
        EntityGender Gender { get; set; }
        EntityClass CharacterClass { get; set; }

    }
}
