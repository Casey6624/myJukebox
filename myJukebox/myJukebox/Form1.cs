﻿using System;
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
        public int genreIndex = 0;
        string trackName = "";
        public Timer timer1;
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

       
        public void readMediaFile(int genreIndex)
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
                lstboxGenreList.DataSource = Media_Libary[genreIndex].GetRange(1, Media_Libary[genreIndex].Count -1);

                foreach(string title in Media_Libary[genreIndex])
                {
                    genreTitle.Add(title);
                    txtGenreTitle.Text = genreTitle[0];
                }
                genreTitle.Clear();
            }
        }
        public myJukeboxMainForm()
        {
            InitializeComponent();
            readMediaFile(0);
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
        private void checkCurrentPlayStatus()
        {
            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPlaying)
            {
                IsPlaying = true;
            }
            else if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsMediaEnded)
            {
                IsPlaying = false;
                timer1.Interval = 100;
                timer1.Enabled = true;
                queueAndPlay();
            }
        }


        public void queueAndPlay()
        {
            if(queuedTracks() == true || IsPlaying == true)
            {
                trackName = lstboxGenreList.SelectedItem.ToString();
                lstboxPlaylist.Items.Add(trackName);
            }
            else if(queuedTracks() == true && IsPlaying == false)
            {
                trackName = Convert.ToString(lstboxPlaylist.GetItemText(0));
                lstboxPlaylist.Items.RemoveAt(0);
            }
            else
            {
                trackName = lstboxGenreList.SelectedItem.ToString();
                string audioFilePath = Path.Combine(StrApplicationTracksPath, trackName);
                axWindowsMediaPlayer1.URL = audioFilePath;
                txtPresentlyPlaying.Text = trackName;
            }
        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                IsPlaying = false;
                queueAndPlay();
            }
        }

        // Used MSDN Microsoft Article for help https://msdn.microsoft.com/en-us/library/windows/desktop/dd562692(v=vs.85).aspx 
        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("I'm sorry, there is an issue with that audio file. It may be corrupt or missing from the file directory.");
            this.Close();
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
            checkCurrentPlayStatus();
            if(IsPlaying == true)
            {
                queueAndPlay();
            }
            else
            {
                queueAndPlay();
            }
                
        }

        private void btnNextGenre_Click(object sender, EventArgs e)
        {
            if (genreIndex < int_Number_of_Genre -1)
            {
                btnNextGenre.Enabled = true;
                genreIndex++;
                readMediaFile(genreIndex);
                btnPrevGenre.Enabled = true;
                genreTitle.Clear();
            }
            else
            {
                btnNextGenre.Enabled = false;
            }          
        }

        private void btnPrevGenre_Click(object sender, EventArgs e)
        {
            if ( genreIndex > 0)
            {
                btnPrevGenre.Enabled = true;
                genreIndex--;
                readMediaFile(genreIndex);
                btnNextGenre.Enabled = true;
                genreTitle.Clear();
            }
            else
            {
                btnPrevGenre.Enabled = false;
            }
        }
    }
}


