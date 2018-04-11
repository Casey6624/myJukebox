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
using MyDialogs;

namespace myJukebox
{
    public partial class setupForm : Form
    {
        public string newGenreTitle = "";
        public int genreIndex = 0;
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
        List<List<string>> Media_Libary = new List<List<string>>();
        List<string> newgenrelist = new List<string>();
        List<string> genreTitle = new List<string>();

        public setupForm()
        {
            InitializeComponent();
            populateGenreTitleAndTracks(genreIndex);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImportFromDirectory_Click(object sender, EventArgs e)
        {
            // Tells the application that something has changed 
            bool bool_Requires_Saving = true;
            // Let the user select the directory the music is comming from 
            if ( folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // Populates the list array with all the files with the stated extension 
                foreach (string file in Directory.EnumerateFiles(folderBrowserDialog1.SelectedPath,"*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".mp3") || s.EndsWith(".wma") || s.EndsWith(".wav") || s.EndsWith(".MP3") || s.EndsWith(".WMA") || s.EndsWith(".WAV")))
                {
                    lstBoxImportedTracks.Items.Add(file);
                }
                if (lstBoxImportedTracks.Items.Count > 0)
                {
                    btnCopyTrack.Enabled = true;
                    btnMoveTrack.Enabled = true;
                }
            }
        }
        public void populateGenreTitleAndTracks(int genreIndex)
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
                    // Adds the tracks to a list by using a get range (+1 is for the genre name)
                    newgenrelist.AddRange(listMediaContents.GetRange(0, tracksInGenre + 1));
                    //newgenrelist.InsertRange(0, listMediaContents);
                    Media_Libary.Add(newgenrelist);

                    // Similar line of code to remove the tracks and title from the list so we can get the next genre info
                    listMediaContents.RemoveRange(0, tracksInGenre + 1);
                }
                lstBoxCurrentTracks.DataSource = Media_Libary[genreIndex].GetRange(1, Media_Libary[genreIndex].Count - 1);

                foreach (string title in Media_Libary[genreIndex])
                {
                    genreTitle.Add(title);
                    txtGeneraTitle.Text = genreTitle[0];
                }
                genreTitle.Clear();
            }
        }
        public void addNewGenre()
        {
            newGenreTitle = My_Dialogs.InputBox("Please Enter The New Genre Title: ");
            txtGeneraTitle.Text = newGenreTitle;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (genreIndex > 0)
            {
                btnPrevious.Enabled = true;
                genreIndex--;
                populateGenreTitleAndTracks(genreIndex);
                btnNext.Enabled = true;
                genreTitle.Clear();
            }
            else
            {
                btnPrevious.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (genreIndex < int_Number_of_Genre - 1)
            {
                btnNext.Enabled = true;
                genreIndex++;
                populateGenreTitleAndTracks(genreIndex);
                btnPrevious.Enabled = true;
                genreTitle.Clear();
            }
            else
            {
                btnNext.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNewGenre();
        }

        private void btnCopyTrack_Click(object sender, EventArgs e)
        {
            if(lstBoxImportedTracks.Items.Count > 0)
            {
                // Change this to add to listboxcurrenttracks on right hand side.
                Media_Libary[genreIndex].Add(Convert.ToString(lstBoxImportedTracks.SelectedItem));
            }
        }
    }
}

