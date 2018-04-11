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
        // Tells the application that something has changed 
        public bool bool_Requires_Saving = false;
        // int to hold the new index of the new genre which will be added 
        public int newGenreIndex = 0;
        // string which will hold the new genre title 
        public string newGenreTitle = null;
        // existing genre indexes which are used to switch between previous and next genres.
        public int genreIndex = 0;
        // line_of_text pulls defined which is used with the StreamReader to read the media file
        string line_of_text;
        // the path of the media files
        public static string StrApplicationMediaPath = Directory.GetCurrentDirectory() + "\\Media\\Media.txt";
        // the path of the config file
        public string StrApplicationTracksPath = Directory.GetCurrentDirectory() + "\\Tracks\\";
        // the number of generes in the config file
        public int int_Number_of_Genre;
        // The creation of all the lists.
        // List Media Contents is what the StreamReader saves each line to
        List<string> listMediaContents = new List<string>();
        // Media Libary is a 2D list with all the genres saved as lists inside
        List<List<string>> Media_Libary = new List<List<string>>();
        // newgenrelist is used in the for loop to create new lists for each genre
        List<string> newgenrelist = new List<string>();
        //genre title stores the chosen genre title and tracks and selects the index 0 to give the title
        List<string> genreTitle = new List<string>();

        public setupForm()
        {
            InitializeComponent();
            populateGenreTitleAndTracks(genreIndex);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Checks to see if a user has created a newGenreTitle/Made changes
            if(newGenreTitle != null)
            {
                // If user has made changes, set bool to true which will prompt the yes/no box below.
                bool_Requires_Saving = true;
            }

            if (bool_Requires_Saving == true)
            {
                // prompt a yes/no box which prompts if a user has made changes. Yes will save changes, no will discard.
                DialogResult dialogResult = MessageBox.Show("You have made changes to the configuration. Do you wish to save your changes?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Streamwriter function goes here
                }
                else if (dialogResult == DialogResult.No)
                {
                    // Close Setup window without saving
                    this.Close();
                }
            }
            else
            {
                // Close Setup window because no changes have been made.
                this.Close();
            }
        }

        private void btnImportFromDirectory_Click(object sender, EventArgs e)
        {
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
                    bool_Requires_Saving = true;
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
                // Grabs the tracks from the Media Libary list and adds them to the lstBoxCurrentTracks
                lstBoxCurrentTracks.DataSource = Media_Libary[genreIndex].GetRange(1, Media_Libary[genreIndex].Count - 1);
                // itterates through each list in the selected genre and saves to it's own list. Sets the first element (the title) to the genre title text
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
            // Input box to ask for the new genre name
            newGenreTitle = My_Dialogs.InputBox("Please Enter The New Genre Title: ");
            // Checks to see if a user entered a genre, if the variable is still null it will not be ran.
            if(newGenreTitle != null)
            {
                txtGeneraTitle.Text = newGenreTitle;
                newGenreIndex = int_Number_of_Genre;
                MessageBox.Show("Genre Index: " + newGenreIndex.ToString());
                MessageBox.Show("Media Libary Count: " + Media_Libary.Count.ToString());
                //Media_Libary[newGenreIndex].Add(newGenreTitle);
            }
        }
        // Code to switch to the previous genre. This takes the index of the genre and goes back 1 index each click. 
        //If we are on the first genre and cannot go back anymore, the else statement disables the button.
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (genreIndex > 0)
            {
                btnPrevious.Enabled = true;
                genreIndex--;
                populateGenreTitleAndTracks(genreIndex);
                // re enables the next button because we can now go forward at least once.
                btnNext.Enabled = true;
                //Clears the genre list so the next genre title which is imported is at index [0]
                genreTitle.Clear();
            }
            else
            {
                btnPrevious.Enabled = false;
            }
        }
        // Code to switch to the next genre. This takes the index of the genre and goes forward 1 index each click. 
        //If we are on the last genre and cannot go forward anymore, the else statement disables the button.
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (genreIndex < int_Number_of_Genre - 1)
            {
                btnNext.Enabled = true;
                // Add 1 to the index
                genreIndex++;
                populateGenreTitleAndTracks(genreIndex);
                // re enables the previous button because we can now go back at least once.
                btnPrevious.Enabled = true;
                //Clears the genre list so the next genre title which is imported is at index [0]
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
                string trackToAdd = Convert.ToString(lstBoxImportedTracks.SelectedItem);
                Media_Libary[newGenreIndex].Add(trackToAdd);

            }
        }

        private void btnClearImportTracks_Click(object sender, EventArgs e)
        {
            lstBoxImportedTracks.Items.Clear();
        }
    }
}

