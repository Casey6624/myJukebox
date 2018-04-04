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
    public partial class setupForm : Form
    {
        public setupForm()
        {
            InitializeComponent();
        }

        bool bool_Requires_Saving;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImportFromDirectory_Click(object sender, EventArgs e)
        {
            // lets user know something has changed and needs saving
            bool_Requires_Saving = true;
            // Allows user to select directory for their music
            //if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
        }