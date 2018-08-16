namespace RPG
{
    partial class Frm_GameMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GameMenu));
            this.Lbl_CharName = new System.Windows.Forms.Label();
            this.Lbl_Gender = new System.Windows.Forms.Label();
            this.Lbl_CharClass = new System.Windows.Forms.Label();
            this.Gbox_CharStats = new System.Windows.Forms.GroupBox();
            this.Lbl_Strength = new System.Windows.Forms.Label();
            this.Lbl_Dexterity = new System.Windows.Forms.Label();
            this.Lbl_Wisdom = new System.Windows.Forms.Label();
            this.Lbl_ShowName = new System.Windows.Forms.Label();
            this.Lbl_ShowGender = new System.Windows.Forms.Label();
            this.Lbl_ShowClass = new System.Windows.Forms.Label();
            this.Lbl_ShowStrength = new System.Windows.Forms.Label();
            this.Lbl_ShowDexterity = new System.Windows.Forms.Label();
            this.Lbl_ShowWisdom = new System.Windows.Forms.Label();
            this.Gbox_CharStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_CharName
            // 
            this.Lbl_CharName.AutoSize = true;
            this.Lbl_CharName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CharName.Location = new System.Drawing.Point(8, 22);
            this.Lbl_CharName.Name = "Lbl_CharName";
            this.Lbl_CharName.Size = new System.Drawing.Size(60, 20);
            this.Lbl_CharName.TabIndex = 0;
            this.Lbl_CharName.Text = "Name:";
            // 
            // Lbl_Gender
            // 
            this.Lbl_Gender.AutoSize = true;
            this.Lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Gender.Location = new System.Drawing.Point(8, 51);
            this.Lbl_Gender.Name = "Lbl_Gender";
            this.Lbl_Gender.Size = new System.Drawing.Size(74, 20);
            this.Lbl_Gender.TabIndex = 1;
            this.Lbl_Gender.Text = "Gender:";
            // 
            // Lbl_CharClass
            // 
            this.Lbl_CharClass.AutoSize = true;
            this.Lbl_CharClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CharClass.Location = new System.Drawing.Point(8, 82);
            this.Lbl_CharClass.Name = "Lbl_CharClass";
            this.Lbl_CharClass.Size = new System.Drawing.Size(58, 20);
            this.Lbl_CharClass.TabIndex = 2;
            this.Lbl_CharClass.Text = "Class:";
            // 
            // Gbox_CharStats
            // 
            this.Gbox_CharStats.Controls.Add(this.Lbl_ShowWisdom);
            this.Gbox_CharStats.Controls.Add(this.Lbl_ShowDexterity);
            this.Gbox_CharStats.Controls.Add(this.Lbl_ShowStrength);
            this.Gbox_CharStats.Controls.Add(this.Lbl_ShowClass);
            this.Gbox_CharStats.Controls.Add(this.Lbl_ShowGender);
            this.Gbox_CharStats.Controls.Add(this.Lbl_ShowName);
            this.Gbox_CharStats.Controls.Add(this.Lbl_Wisdom);
            this.Gbox_CharStats.Controls.Add(this.Lbl_Dexterity);
            this.Gbox_CharStats.Controls.Add(this.Lbl_Strength);
            this.Gbox_CharStats.Controls.Add(this.Lbl_CharName);
            this.Gbox_CharStats.Controls.Add(this.Lbl_Gender);
            this.Gbox_CharStats.Controls.Add(this.Lbl_CharClass);
            this.Gbox_CharStats.Location = new System.Drawing.Point(12, 494);
            this.Gbox_CharStats.Name = "Gbox_CharStats";
            this.Gbox_CharStats.Size = new System.Drawing.Size(372, 123);
            this.Gbox_CharStats.TabIndex = 4;
            this.Gbox_CharStats.TabStop = false;
            this.Gbox_CharStats.Text = "Character Stats:";
            // 
            // Lbl_Strength
            // 
            this.Lbl_Strength.AutoSize = true;
            this.Lbl_Strength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Strength.Location = new System.Drawing.Point(157, 22);
            this.Lbl_Strength.Name = "Lbl_Strength";
            this.Lbl_Strength.Size = new System.Drawing.Size(84, 20);
            this.Lbl_Strength.TabIndex = 3;
            this.Lbl_Strength.Text = "Strength:";
            // 
            // Lbl_Dexterity
            // 
            this.Lbl_Dexterity.AutoSize = true;
            this.Lbl_Dexterity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dexterity.Location = new System.Drawing.Point(157, 51);
            this.Lbl_Dexterity.Name = "Lbl_Dexterity";
            this.Lbl_Dexterity.Size = new System.Drawing.Size(85, 20);
            this.Lbl_Dexterity.TabIndex = 4;
            this.Lbl_Dexterity.Text = "Dexterity:";
            // 
            // Lbl_Wisdom
            // 
            this.Lbl_Wisdom.AutoSize = true;
            this.Lbl_Wisdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Wisdom.Location = new System.Drawing.Point(164, 82);
            this.Lbl_Wisdom.Name = "Lbl_Wisdom";
            this.Lbl_Wisdom.Size = new System.Drawing.Size(77, 20);
            this.Lbl_Wisdom.TabIndex = 5;
            this.Lbl_Wisdom.Text = "Wisdom:";
            // 
            // Lbl_ShowName
            // 
            this.Lbl_ShowName.AutoSize = true;
            this.Lbl_ShowName.Location = new System.Drawing.Point(75, 21);
            this.Lbl_ShowName.Name = "Lbl_ShowName";
            this.Lbl_ShowName.Size = new System.Drawing.Size(0, 20);
            this.Lbl_ShowName.TabIndex = 6;
            // 
            // Lbl_ShowGender
            // 
            this.Lbl_ShowGender.AutoSize = true;
            this.Lbl_ShowGender.Location = new System.Drawing.Point(88, 51);
            this.Lbl_ShowGender.Name = "Lbl_ShowGender";
            this.Lbl_ShowGender.Size = new System.Drawing.Size(51, 20);
            this.Lbl_ShowGender.TabIndex = 7;
            this.Lbl_ShowGender.Text = "label2";
            // 
            // Lbl_ShowClass
            // 
            this.Lbl_ShowClass.AutoSize = true;
            this.Lbl_ShowClass.Location = new System.Drawing.Point(72, 82);
            this.Lbl_ShowClass.Name = "Lbl_ShowClass";
            this.Lbl_ShowClass.Size = new System.Drawing.Size(51, 20);
            this.Lbl_ShowClass.TabIndex = 8;
            this.Lbl_ShowClass.Text = "label3";
            // 
            // Lbl_ShowStrength
            // 
            this.Lbl_ShowStrength.AutoSize = true;
            this.Lbl_ShowStrength.Location = new System.Drawing.Point(247, 21);
            this.Lbl_ShowStrength.Name = "Lbl_ShowStrength";
            this.Lbl_ShowStrength.Size = new System.Drawing.Size(51, 20);
            this.Lbl_ShowStrength.TabIndex = 9;
            this.Lbl_ShowStrength.Text = "label4";
            // 
            // Lbl_ShowDexterity
            // 
            this.Lbl_ShowDexterity.AutoSize = true;
            this.Lbl_ShowDexterity.Location = new System.Drawing.Point(247, 51);
            this.Lbl_ShowDexterity.Name = "Lbl_ShowDexterity";
            this.Lbl_ShowDexterity.Size = new System.Drawing.Size(51, 20);
            this.Lbl_ShowDexterity.TabIndex = 10;
            this.Lbl_ShowDexterity.Text = "label5";
            // 
            // Lbl_ShowWisdom
            // 
            this.Lbl_ShowWisdom.AutoSize = true;
            this.Lbl_ShowWisdom.Location = new System.Drawing.Point(247, 82);
            this.Lbl_ShowWisdom.Name = "Lbl_ShowWisdom";
            this.Lbl_ShowWisdom.Size = new System.Drawing.Size(51, 20);
            this.Lbl_ShowWisdom.TabIndex = 11;
            this.Lbl_ShowWisdom.Text = "label6";
            // 
            // Frm_GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 629);
            this.Controls.Add(this.Gbox_CharStats);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_GameMenu";
            this.Text = "RPG - Game Menu";
            this.Load += new System.EventHandler(this.Frm_GameMenu_Load);
            this.Gbox_CharStats.ResumeLayout(false);
            this.Gbox_CharStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CharName;
        private System.Windows.Forms.Label Lbl_Gender;
        private System.Windows.Forms.Label Lbl_CharClass;
        private System.Windows.Forms.GroupBox Gbox_CharStats;
        private System.Windows.Forms.Label Lbl_Wisdom;
        private System.Windows.Forms.Label Lbl_Dexterity;
        private System.Windows.Forms.Label Lbl_Strength;
        private System.Windows.Forms.Label Lbl_ShowWisdom;
        private System.Windows.Forms.Label Lbl_ShowDexterity;
        private System.Windows.Forms.Label Lbl_ShowStrength;
        private System.Windows.Forms.Label Lbl_ShowClass;
        private System.Windows.Forms.Label Lbl_ShowGender;
        private System.Windows.Forms.Label Lbl_ShowName;
    }
}