using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDO_Character_Generator
{
    public partial class Main : Form
    {
        Character character = new Character();

        public Main()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram form = new AboutProgram();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirm=DialogResult.No;
            if (character.Edited())
            {
                confirm = MessageBox.Show("Character has been edited, are you sure you wish to start a new character without saving?", "Confirm New Character", MessageBoxButtons.YesNo);
            }
            if (confirm == System.Windows.Forms.DialogResult.Yes || !character.Edited())
            {
                character.ResetCharacter(); 
            }
        }

        private void loadCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
     }
}
