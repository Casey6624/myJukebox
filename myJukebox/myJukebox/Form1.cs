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
using WMPLib;

namespace myJukebox
{
    public partial class myJukeboxMainForm : Form
    {
        // public variable genreIndex which allows us to select which genre is in use
        public int genreIndex = 0;
        // track name which will be assigned to the first element in the playlist list
        string trackName = "";
        // status of playing music
        bool IsPlaying = false;
        // line_of_text is used with the StreamReader to read the media file and store each line
        string line_of_text;
        // the path of the media config file
        public static string StrApplicationMediaPath = Directory.GetCurrentDirectory() + "\\Media\\Media.txt";
        // the path of the mp3 and wma tracks
        public string StrApplicationTracksPath = Directory.GetCurrentDirectory() + "\\Tracks\\";
        // the number of generes in the config file (the first line of the file)
        public int int_Number_of_Genre;
        // Creation of all the lists used in my project:
        //----------------------------------------------
        // stores all the lines of the StreamReader in a list
        List<string> listMediaContents = new List<string>();
        // stores all the genre lists in a 2D list of lists
        List<List<string>> Media_Libary = new List<List<string>>();
        // used in the for loop to store each itteration through the media file to Media_Libary
        List<string> newgenrelist = new List<string>();
        // Used with a foreach loop to get all the elements from the list and the index [0] is selected to give the title text (first element)
        List<string> genreTitle = new List<string>();

        public void readMediaFile(int genreIndex)
        {
            List<List<string>> Media_Libary = new List<List<string>>();
            // New StreamReader is created
            StreamReader MediaFile_StreamReader = File.OpenText(StrApplicationMediaPath);
            // line of text is used with the ReadLine() to get the text of the file
            line_of_text = MediaFile_StreamReader.ReadLine();
            // Itterate through the file till there are no more lines
            while (line_of_text != null)
            {
                // Adds each line to the listMediaContents file
                listMediaContents.Add(line_of_text);
                line_of_text = MediaFile_StreamReader.ReadLine();
            }
            // Close StreamReader as it is not needed anymore
            MediaFile_StreamReader.Close();
            // Save the number of genre (1st line of list) to a variable
            int_Number_of_Genre = Convert.ToInt16(listMediaContents[0]);
            // Then remove the number genre as we have it saved to a variable
            listMediaContents.RemoveAt(0);
            // if there is one or more genres
            if (int_Number_of_Genre >= 1)
            {
                // loop for the amount of genres we have in the media file.
                for (int count = 0; count < int_Number_of_Genre; count++)
                {
                    // create a new list for each of genres we have
                    List<string> newgenrelist = new List<string>();
                    // Work out the amount of tracks in the genre by reading the new 0 index of the list
                    int tracksInGenre = Convert.ToInt16(listMediaContents[0]);
                    // then deletes the amount of tracks once it's stored to a variable 
                    listMediaContents.RemoveAt(0);
                    // Adds the tracks to the newgenrelist by using a get range (+1 is for the genre name)
                    newgenrelist.AddRange(listMediaContents.GetRange(0, tracksInGenre + 1));
                    //add the new genrelist to the Media_Libary list of lists. The index of where it is stored will be the local count or global genreIndex variable.
                    Media_Libary.Add(newgenrelist);
                    // Removes the genre title and tracks once it is stored within it's own list within Media_Libary list of lists
                    listMediaContents.RemoveRange(0, tracksInGenre + 1);
                }
                // Populates the genrelist with tracks at genreIndex variable. Uses a GetRange to skip the 1st element (the title)
                lstboxGenreList.DataSource = Media_Libary[genreIndex].GetRange(1, Media_Libary[genreIndex].Count - 1);

                // a foreach loop to itterate through the selected genrelist 
                foreach (string title in Media_Libary[genreIndex])
                {
                    // Save each element to a new list named genreTitle
                    genreTitle.Add(title);
                }
                // Set the genretitle text to the first element of the genreTitle list which will be the genre title.
                txtGenreTitle.Text = genreTitle[0];
                //Clear the genretitle list ready for when the user selects the next or previous genre.
                genreTitle.Clear();
            }
        }
        public myJukeboxMainForm()
        {
            InitializeComponent();
            // runs the readMediaFile function with parameter 0 which is the index of the genres. This will show the first genre.
            readMediaFile(0);
        }

        private bool checkCurrentPlaylistStatus()
        {
            // Checks to see if we have any items queued in the playlist and returns true or false accordingly
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
            // code runs if there are tracks queued up in the player and nothing is playing
            if (checkCurrentPlaylistStatus() == true && IsPlaying == false)
            {
                // gets the new track name by grabbing the first item from the playlist listbox and converting to a string
                trackName = lstboxPlaylist.Items[0].ToString();
                //Removes this item from the playlist as it's about to be played
                lstboxPlaylist.Items.RemoveAt(0);
                // creates a new file path with the new track name
                string audioFilePath = Path.Combine(StrApplicationTracksPath, trackName);
                // Starts playing with the full file path
                axWindowsMediaPlayer1.URL = audioFilePath;
                // Sets the presently playing label to the track name
                txtPresentlyPlaying.Text = trackName;
                // Sets the isplaying bool to true
                IsPlaying = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // checks to see if the player is currently playing anything
            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPlaying)
            {
                // if the player is playing a track, set the isplaying bool to true
                IsPlaying = true;
            }
            // checks to see if the tracks has stopped
            else if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsStopped)
            {
                // turns off the timer and runs the queue and play function
                timer1.Enabled = false;
                queueAndPlay();
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
            // If there are more than 0 tracks in the selected genre, add the selected item to the playlist
            if (lstboxGenreList.Items.Count > 0)
            {
                lstboxPlaylist.Items.Add(lstboxGenreList.Items[lstboxGenreList.SelectedIndex]);
                // if the player is currently not playing anything, run the queueAndPlay function which plays the track.
                if (IsPlaying == false)
                {
                    queueAndPlay();
                }
            }
        }
        // Code to switch to the next genre. This takes the index of the genre and goes forward 1 index each click. 
        //If we are on the last genre and cannot go forward anymore, the else statement disables the button.
        private void btnNextGenre_Click(object sender, EventArgs e)
        {
            if (genreIndex < int_Number_of_Genre - 1)
            {
                btnNextGenre.Enabled = true;
                // Add 1 to the index
                genreIndex++;
                readMediaFile(genreIndex);
                // re enables the previous button because we can now go back at least once.
                btnPrevGenre.Enabled = true;
                //Clears the genre list so the next genre title which is imported is at index [0]
                genreTitle.Clear();
            }
            else
            {
                btnNextGenre.Enabled = false;
            }
        }
        // Code to switch to the previous genre. This takes the index of the genre and goes back 1 index each click. 
        //If we are on the first genre and cannot go back anymore, the else statement disables the button.
        private void btnPrevGenre_Click(object sender, EventArgs e)
        {
            if (genreIndex > 0)
            {
                btnPrevGenre.Enabled = true;
                genreIndex--;
                readMediaFile(genreIndex);
                // re enables the next button because we can now go forward at least once.
                btnNextGenre.Enabled = true;
                //Clears the genre list so the next genre title which is imported is at index [0]
                genreTitle.Clear();
            }
            else
            {
                btnPrevGenre.Enabled = false;
            }
        }
        // This is triggered once the play state has changed
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Got the playstates from the MSDN Article https://msdn.microsoft.com/en-us/library/windows/desktop/dd564085(v=vs.85).aspx
            // newState 8 represents "MediaEnded"
            if (e.newState == 8)
            {
                // Sets the bool to false because nothing is playing
                IsPlaying = false;
                // timer is set to 100 miliseconds
                timer1.Interval = 100;
                // Run the timer1_Tick method everytime the timer ticks
                timer1.Tick += timer1_Tick;
                // Start the timer
                timer1.Start();
            }
            // newState 3 is when the media player is in a playing state
            else if (e.newState == 3)
            {
                // Set the IsPlaying bool to true
                IsPlaying = true;
            }
        }
    }
}


