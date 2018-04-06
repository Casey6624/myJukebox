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
            
            // Creation of list for each genre, a list containing all genre lists and a seperate list for genreNames so 
            // genre titles are not posting in lstboxGenreList
            List<string> listMediaContents = new List<string>();
            List<string> genreNames = new List<string>();
            List<List<string>> allGenres = new List<List<string>>();
            List<string> listGenre1 = new List<string>();
            List<string> listGenre2 = new List<string>();
            List<string> listGenre3 = new List<string>();

            // line_of_text pulls defined which is used with the StreamReader to read the media file
            string line_of_text;
            // Setting up StreamReader with the path of the Media file (which is saved as a string)
            StreamReader My_Input_stream = File.OpenText(StrApplicationMediaPath);
            line_of_text = My_Input_stream.ReadLine();
            // search through file until no lines left
            while (line_of_text != null)
            {
                // Adds 
                listMediaContents.Add(line_of_text);
                line_of_text = My_Input_stream.ReadLine();
            }
            // Close input stream because all text is now saved tothe listMediaContents list
            My_Input_stream.Close();

            int numOfGenre = Convert.ToInt16(listMediaContents[0]);
            listMediaContents.RemoveAt(0);

            // Code to work out the amount of tracks in the genre by reading the 2nd line after the amount of genres in total
            int tracksInGenre = Convert.ToInt16(listMediaContents[0]);
            // then deletes the amount of tracks once it's stored to a variable 
            listMediaContents.RemoveAt(0);
            // Adds the tracks to a list by using a get range (+1 is for the genre name)
            listGenre1 = listMediaContents.GetRange(0, tracksInGenre + 1);
            // Similar line of code to remove the tracks and title from the list so we can get the next genre info
            listMediaContents.RemoveRange(0, tracksInGenre + 1);
            // Test listbox to see what is inside the list
            listBox1.DataSource = listGenre1;

            // Code to work out the amount of tracks in the genre by reading the 2nd line after the amount of genres in total
            tracksInGenre = Convert.ToInt16(listMediaContents[0]);
            // then deletes the amount of tracks once it's stored to a variable 
            listMediaContents.RemoveAt(0);
            // Adds the tracks to a list by using a get range (+1 is for the genre name)
            listGenre2 = listMediaContents.GetRange(0, tracksInGenre + 1);
            // Similar line of code to remove the tracks and title from the list so we can get the next genre info
            listMediaContents.RemoveRange(0, tracksInGenre + 1);
            // Test listbox to see what is inside the list
            listBox2.DataSource = listGenre2;

            // Code to work out the amount of tracks in the genre by reading the 2nd line after the amount of genres in total
            tracksInGenre = Convert.ToInt16(listMediaContents[0]);
            // then deletes the amount of tracks once it's stored to a variable 
            listMediaContents.RemoveAt(0);
            // Adds the tracks to a list by using a get range (+1 is for the genre name)
            listGenre3 = listMediaContents.GetRange(0, tracksInGenre + 1);
            // Similar line of code to remove the tracks and title from the list so we can get the next genre info
            listMediaContents.RemoveRange(0, tracksInGenre + 1);
            // Test listbox to see what is inside the list
            listBox3.DataSource = listGenre3;
            // Takes the genre name which is [0] in each list and adds them to their own list and then removes them from the list with the tracks
            genreNames.Add(listGenre1[0]);
            listGenre1.RemoveAt(0);
            genreNames.Add(listGenre2[0]);
            listGenre2.RemoveAt(0);
            genreNames.Add(listGenre3[0]);
            listGenre3.RemoveAt(0);
            int genreIndex = 0;
            // Sets the genretitle text to the name of the genre
            txtGenreTitle.Text = genreNames[genreIndex];

            allGenres.Add(listGenre1);
            allGenres.Add(listGenre2);
            allGenres.Add(listGenre3);

            lstboxGenreList.DataSource = allGenres[genreIndex];
            string trackName = "";
            
            // Code to play the tracks
            // new string audio path combines the directory and the track name which is selected from the listbox
            string audioFilePath = Path.Combine(StrApplicationTracksPath, trackName);
            axWindowsMediaPlayer1.URL = audioFilePath;
            txtPlayingFilePath.Text = audioFilePath;
        }

        // the path of the media files
        public static string StrApplicationMediaPath = Directory.GetCurrentDirectory() + "\\Media\\Media.txt";
        // the path of the config file
        public string StrApplicationTracksPath = Directory.GetCurrentDirectory() + "\\Tracks\\";
        // the number of generes in the config file
        public int int_Number_of_Genre;
        private object allGenres;
        private object genreNames;

        public string trackName { get; private set; }
        public int genreIndex { get; private set; }
        public int numOfGenre { get; private set; }

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

        private void lstboxGenreList_DoubleClick(object sender, EventArgs e)
        {
            trackName = lstboxGenreList.SelectedItem.ToString();
            string audioFilePath = Path.Combine(StrApplicationTracksPath, trackName);
            axWindowsMediaPlayer1.URL = audioFilePath;
            txtPlayingFilePath.Text = audioFilePath;
        }

        private void btnNextGenre_Click(object sender, EventArgs e)
        {
            if(genreIndex < numOfGenre)
            {
                genreIndex = genreIndex + 1;
               
            }
            else
            {
                btnNextGenre.Enabled = false;
            }
            MessageBox.Show("genreIndex: " + genreIndex + " numOfGenre " + numOfGenre);
            


        }
    }
}
