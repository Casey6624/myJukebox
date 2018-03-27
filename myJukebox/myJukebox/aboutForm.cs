using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myJukebox
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void btnOkAbout_Click(object sender, EventArgs e)
        {
            // Close the about window when the OK button is pressed.
            this.Close();
        }
    }
}
