using RPG.CharacterClasses;
using RPG.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class Frm_GameMenu : Form
    {
        public Frm_GameMenu()
        {
            InitializeComponent();
        }

        private void Frm_GameMenu_Load(object sender, EventArgs e)
        {
            PlayerBase player = new PlayerBase();
            player = FileManager.LoadGame();

            
            Lbl_ShowName.Text = player.Name;
            Lbl_ShowGender.Text = player.Gender.ToString();
            Lbl_ShowClass.Text = player.CharacterClass.ToString();
            Lbl_ShowStrength.Text = player.Strength.ToString();
            Lbl_ShowDexterity.Text = player.Dexterity.ToString();
            Lbl_ShowWisdom.Text = player.Wisdom.ToString();


            
        }

    }
}
