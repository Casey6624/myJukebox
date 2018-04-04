using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace myJukebox
{
    public partial class myJukeboxMainForm : Form
    {
        public myJukeboxMainForm()
        {
            InitializeComponent();
            readGenre();
        }
        public void readGenre()
        {
            string line_of_text;
            StreamReader My_Input_stream = File.OpenText(StrApplicationMediaPath);
            line_of_text = My_Input_stream.ReadLine();
            while(line_of_text != null)
            {
                lstboxGenreList.Items.Add(line_of_text + Environment.NewLine);
                line_of_text = My_Input_stream.ReadLine();
            }
            My_Input_stream.Close();
        }
        // the path of the media files
        public static string StrApplicationMediaPath = Directory.GetCurrentDirectory() + "\\Media\\Media.txt";
        // the path of the config file
        public string StrApplicationTracksPath = Directory.GetCurrentDirectory() + "\\Tracks";
        // the number of generes in the config file
        public int int_Number_of_Genre;

        ListBox[] Media_Libary;

        // status of playing music
        bool IsPlaying = false;
        string tracksInGenre;

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Assigns the aboutForm to a variable and shows the form when About Menu Item selected
            aboutForm aboutForm = new aboutForm();
            aboutForm.ShowDialog();
            readGenre();
        }

        private void setUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Assigns the aboutForm to a variable and shows the form when About Menu Item selected
            setupForm setupForm = new setupForm();
            setupForm.ShowDialog();
        }

        private void lstboxGenreList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
   }
}
