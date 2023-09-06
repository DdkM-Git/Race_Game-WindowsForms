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
    public partial class LogInForm : Form
    {
        bool openMenu;
        public LogInForm()
        {
            openMenu = false;
            InitializeComponent();
        }

        private void dalejButton_Click(object sender, EventArgs e)
        {
            if (nicktextBox.Text == "")
            {
                openMenu = true;
                Refresh();
            }
        }
    }
}
