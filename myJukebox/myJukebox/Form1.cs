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

            List<string> listMediaContents = new List<string>();
            List<List<string>> allGenres = new List<List<string>>();
            List<string> listGenre1 = new List<string>();
            List<string> listGenre2 = new List<string>();
            List<string> listGenre3 = new List<string>();

            string line_of_text;
            StreamReader My_Input_stream = File.OpenText(StrApplicationMediaPath);
            line_of_text = My_Input_stream.ReadLine();
            while (line_of_text != null)
            {
                listMediaContents.Add(line_of_text);
                line_of_text = My_Input_stream.ReadLine();
            }

            My_Input_stream.Close();

            int numOfGenre = Convert.ToInt16(listMediaContents[0]);
            listMediaContents.RemoveAt(0);

            int tracksInGenre = Convert.ToInt16(listMediaContents[0]);
            listMediaContents.RemoveAt(0);
            listGenre1 = listMediaContents.GetRange(0, tracksInGenre + 1);
            listMediaContents.RemoveRange(0, tracksInGenre + 1);
            listBox1.DataSource = listGenre1;

            tracksInGenre = Convert.ToInt16(listMediaContents[0]);
            listMediaContents.RemoveAt(0);
            listGenre2 = listMediaContents.GetRange(0, tracksInGenre + 1);
            listMediaContents.RemoveRange(0, tracksInGenre + 1);
            listBox2.DataSource = listGenre2;

            tracksInGenre = Convert.ToInt16(listMediaContents[0]);
            listMediaContents.RemoveAt(0);
            listGenre3 = listMediaContents.GetRange(0, tracksInGenre + 1);
            listMediaContents.RemoveRange(0, tracksInGenre + 1);
            listBox3.DataSource = listGenre3;

            txtGenreTitle.Text = listGenre1[0];
 
            allGenres.Add(listGenre1);
            allGenres.Add(listGenre2);
            allGenres.Add(listGenre3);
            lstboxGenreList.DataSource = allGenres;  
                
        }

        // the path of the media files
        public static string StrApplicationMediaPath = Directory.GetCurrentDirectory() + "\\Media\\Media.txt";
        // the path of the config file
        public string StrApplicationTracksPath = Directory.GetCurrentDirectory() + "\\Tracks";
        // the number of generes in the config file
        public int int_Number_of_Genre;

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Assigns the aboutForm to a variable and shows the form when About Menu Item selected
            aboutForm aboutForm = new aboutForm();
            aboutForm.ShowDialog();
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
