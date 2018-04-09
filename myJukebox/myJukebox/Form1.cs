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
        string trackName = "";
        // status of playing music
        bool IsPlaying = false;
        // line_of_text pulls defined which is used with the StreamReader to read the media file
        string line_of_text;
        // the path of the media files
        public static string StrApplicationMediaPath = Directory.GetCurrentDirectory() + "\\Media\\Media.txt";
        // the path of the config file
        public string StrApplicationTracksPath = Directory.GetCurrentDirectory() + "\\Tracks\\";
        // the number of generes in the config file
        public int int_Number_of_Genre;
        // Creation of list for each genre, a list containing all genre lists and a seperate list for genreNames so 
        // genre titles are not posting in lstboxGenreList
        List<string> listMediaContents = new List<string>();
        List<string> listGenreNameAndTracks = new List<string>();

        List<string> newgenrelist = new List<string>();

        public List<List<string>> Media_Libary()
        {
            List<List<string>> Media_Libary = new List<List<string>>();

            StreamReader MediaFile_StreamReader = File.OpenText(StrApplicationMediaPath);
            line_of_text = MediaFile_StreamReader.ReadLine();
            // Read the file and store to list until line_of_text returns null (no more lines)
            while (line_of_text != null)
            {
                // Adds each line to the listMediaContents file
                listMediaContents.Add(line_of_text);
                line_of_text = MediaFile_StreamReader.ReadLine();
            }
            // Close StreamReader
            MediaFile_StreamReader.Close();
            // Save the number of genre (1st line of list) to a variable
            int_Number_of_Genre = Convert.ToInt16(listMediaContents[0]);
            listMediaContents.RemoveAt(0);
            // if there is more than one genre
            if (int_Number_of_Genre >= 1)
            {
                for (int count = 0; count < int_Number_of_Genre; count++)
                {
                    List<string> newgenrelist = new List<string>();
                    // Code to work out the amount of tracks in the genre by reading the 2nd line after the amount of genres in total
                    int tracksInGenre = Convert.ToInt16(listMediaContents[0]);
                    // then deletes the amount of tracks once it's stored to a variable 
                    listMediaContents.RemoveAt(0);
                    for (int count2 = 0; count2 < tracksInGenre; count2++)
                    {
                        // Adds the tracks to a list by using a get range (+1 is for the genre name)
                        //newgenrelist.Add(listMediaContents.GetRange(0, tracksInGenre + 1));
                        newgenrelist.InsertRange(0, listMediaContents);
                    }
                    // Similar line of code to remove the tracks and title from the list so we can get the next genre info
                    listMediaContents.RemoveRange(0, tracksInGenre + 1);
                    Media_Libary.Add(newgenrelist);
                    lstboxGenreList.DataSource = Media_Libary[0];
                }
            }
            return (Media_Libary);
        }
    

        public myJukeboxMainForm()
        {
            InitializeComponent();
            Media_Libary();
        }
        public bool queuedTracks()
        {
            if (lstboxPlaylist.Items.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void queueAndPlay()
        {
            if(queuedTracks() == true)
            {
                trackName = lstboxGenreList.SelectedItem.ToString();
                lstboxPlaylist.Items.Add(trackName);

            }
            else
            {
                trackName = lstboxGenreList.SelectedItem.ToString();
                string audioFilePath = Path.Combine(StrApplicationTracksPath, trackName);
                axWindowsMediaPlayer1.URL = audioFilePath;
                txtPlayingFilePath.Text = audioFilePath;
            }

        }

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
            MessageBox.Show(Convert.ToString(lstboxGenreList.Items[0])); 
           

           

        }

        private void btnNextGenre_Click(object sender, EventArgs e)
        {


        }
    }
}


