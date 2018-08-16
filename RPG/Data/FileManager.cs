using RPG.CharacterClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace RPG.Data
{
    public class FileManager
    {
        public static string SettingsFolder
        {
            get
            {
                // C:\Users\UserName\AppData\Roaming\RPG\CharacterSettings
                string folder = Environment.GetFolderPath(
                    Environment.SpecialFolder.ApplicationData);

                folder = Path.Combine(folder, "RPG", "CharacterSettings");
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                return folder;
            }
        }
        public static string PlayerSettingsFile
        {
            get
            {
                // C:\Users\UserName\AppData\Roaming\RPG\CharacterSettings\Player.xml
                return Path.Combine(SettingsFolder, "Player.xml");
            }
        }


        public static PlayerBase LoadGame()
        {
            if (!File.Exists(PlayerSettingsFile))
            {
               return new PlayerBase("No Char Found", EntityGender.Unknown);
            }

            using (Stream stream = File.OpenRead(PlayerSettingsFile))
            {
                XmlReader reader = new XmlTextReader(stream);
                foreach (var type in PlayerBase.Types)
                {
                    var serializer = new XmlSerializer(type);

                    if (serializer.CanDeserialize(reader))
                    {
                        return (PlayerBase)serializer.Deserialize(reader);
                    }
                }

            }
            return new PlayerBase();

        }

        public static void StoreCharacter(PlayerBase player)
        {
            using (Stream stream = File.Create(PlayerSettingsFile))
            {
                XmlSerializer ser = new XmlSerializer(player.GetType(), "PlayerBase");
                ser.Serialize(stream, player);
            }
        }
    }
}