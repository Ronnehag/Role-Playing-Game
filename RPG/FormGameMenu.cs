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
        private static PlayerBase _player = new PlayerBase();
        private static NPCBase _npc = new NPCBase();

        public Frm_GameMenu()
        {
            InitializeComponent();
        }

        private void Frm_GameMenu_Load(object sender, EventArgs e)
        {
            _player = FileManager.LoadGame();
            if (_player != null)
            {
                Lbl_ShowName.Text = _player.Name;
                Lbl_ShowGender.Text = _player.Gender.ToString();
                Lbl_ShowClass.Text = _player.CharacterClass.ToString();
                Lbl_ShowStrength.Text = _player.Strength.ToString();
                Lbl_ShowDexterity.Text = _player.Dexterity.ToString();
                Lbl_ShowWisdom.Text = _player.Wisdom.ToString();
                Lbl_ShowHealth.Text = _player.Health.ToString();
            }
            else
            {
                MessageBox.Show("No character file to load, start a new game.");
                Close();
            }


        }

        private void Btn_NewEnemy_Click(object sender, EventArgs e)
        {
            ShowNewEnemy();

        }

        public void ShowNewEnemy()
        {
            _npc = _npc.GetNewEnemy();

            Tb_Dungeon.AppendText("Eeek a " +
                _npc.Name + "!" + Environment.NewLine + Environment.NewLine +
                "Enemy: " + _npc.Name + Environment.NewLine + 
                "Current health: " + _npc.Health);
        }

        private void Btn_PlayerAttack_Click(object sender, EventArgs e)
        {
            // Temporary Placeholder
            // - Make NPC.Attack method generate the numbers within its derived classes.
            // - Add Method here to refresh the player/enemy HP after each click of btn Attack.
            // - Add astring, showing enemy attacks + damage number in textbox.
            int npcDamage = _npc.Attack();
            int playerDamage = _player.Attack();
            _npc.DecreaseHealth(playerDamage);
            _player.DecreaseHealth(npcDamage);

            if(!_player.IsDead() || !_npc.IsDead())
            {
                // Continue here with LevelUp method
            }

           

            // Add story here, player swung weapon hit for x dmg.
            // NPC attacked back for x dmg.

            Lbl_ShowHealth.Text = _player.Health.ToString();
            Tb_Dungeon.AppendText(Environment.NewLine+ "Enemy: " + _npc.Name + Environment.NewLine +
            "Current health: " + _npc.Health);

        }
    }
}
