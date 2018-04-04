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
            // status of playing music
            bool IsPlaying = false;
            readGenre();
        }
        public void readGenre()
        {
            List<string> listMediaContents = new List<string>();
            List<string> listGenre1 = new List<string>();
            List<string> listGenre2 = new List<string>();
            List<string> listGenre3 = new List<string>();
              
            string line_of_text;
            StreamReader My_Input_stream = File.OpenText(StrApplicationMediaPath);
            line_of_text = My_Input_stream.ReadLine();
            while(line_of_text != null)
            {
                lstboxGenreList.Items.Add(line_of_text + Environment.NewLine);
                listMediaContents.Add(line_of_text);
                line_of_text = My_Input_stream.ReadLine();
            }
            My_Input_stream.Close();
            int numOfGenre = Convert.ToInt16(listMediaContents[0]);
            listMediaContents.RemoveAt(0);
            int tracksInGenre = Convert.ToInt16(listMediaContents[0]);
            for (int i = 1; i >  numOfGenre; i++)
            {
                if(i == 1)
                {
                    listGenre1 = listMediaContents.GetRange(0, tracksInGenre + 1);
                    listMediaContents.RemoveRange(0, tracksInGenre + 1);
                    MessageBox.Show(listGenre1[1]);

                }
                if(i == 2)
                {
                    listGenre2 = listMediaContents.GetRange(0, tracksInGenre + 1);
                    listMediaContents.RemoveRange(0, tracksInGenre + 1);
                    textBox2.Text = listGenre2.ToString();
                }
                if (i == 3)
                {
                    listGenre3 = listMediaContents.GetRange(0, tracksInGenre + 1);
                    listMediaContents.RemoveRange(0, tracksInGenre + 1);
                    textBox3.Text = listGenre3.ToString();
                }
            }

        }
        // the path of the media files
        public static string StrApplicationMediaPath = Directory.GetCurrentDirectory() + "\\Media\\Media.txt";
        // the path of the config file
        public string StrApplicationTracksPath = Directory.GetCurrentDirectory() + "\\Tracks";
        // the number of generes in the config file
        public int int_Number_of_Genre;

        ListBox[] Media_Libary;


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
