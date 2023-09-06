using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyscigi
{
    public partial class Menu : Form
    {
        Gra gra;
        public Menu()
        {   
            InitializeComponent();
        }

        private void HandleStart(object sender, EventArgs e)
        {
            gra = new Gra(predkoscListBox.Text,nicktextBox.Text);
            gra.ShowDialog();
        }

        private void dalejButton_Click(object sender, EventArgs e)
        {
            if (nicktextBox.Text != "")
            {
                tytułLabel.Visible = false;
                nickLabel.Visible = false;
                nicktextBox.Visible = false;
                dalejButton.Visible = false;
                startButton.Visible = true;
                predkoscLabel.Visible = true;
                predkoscListBox.Visible = true;
                Refresh();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            startButton.Enabled = true;
        }

        private void nicktextBox_TextChanged(object sender, EventArgs e)
        {
            if (nicktextBox.Text != "")
            {
                dalejButton.Enabled = true;
            }
            else
            {
                dalejButton.Enabled = false;
            }
        }
    }
}
