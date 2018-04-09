﻿namespace myJukebox
{
    partial class myJukeboxMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myJukeboxMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGenreTitle = new System.Windows.Forms.TextBox();
            this.lstboxGenreList = new System.Windows.Forms.ListBox();
            this.txtPresentlyPlaying = new System.Windows.Forms.TextBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.txtPlayingFilePath = new System.Windows.Forms.TextBox();
            this.btnNextGenre = new System.Windows.Forms.Button();
            this.btnPrevGenre = new System.Windows.Forms.Button();
            this.lstboxPlaylist = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 706);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mainMenuStrip1";
            // 
            // setUpToolStripMenuItem
            // 
            this.setUpToolStripMenuItem.Name = "setUpToolStripMenuItem";
            this.setUpToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.setUpToolStripMenuItem.Text = "Set Up";
            this.setUpToolStripMenuItem.Click += new System.EventHandler(this.setUpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // txtGenreTitle
            // 
            this.txtGenreTitle.BackColor = System.Drawing.Color.Thistle;
            this.txtGenreTitle.Location = new System.Drawing.Point(135, 189);
            this.txtGenreTitle.Name = "txtGenreTitle";
            this.txtGenreTitle.ReadOnly = true;
            this.txtGenreTitle.Size = new System.Drawing.Size(209, 20);
            this.txtGenreTitle.TabIndex = 1;
            // 
            // lstboxGenreList
            // 
            this.lstboxGenreList.DisplayMember = "Name";
            this.lstboxGenreList.FormattingEnabled = true;
            this.lstboxGenreList.HorizontalExtent = 100000;
            this.lstboxGenreList.HorizontalScrollbar = true;
            this.lstboxGenreList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstboxGenreList.Location = new System.Drawing.Point(135, 207);
            this.lstboxGenreList.MultiColumn = true;
            this.lstboxGenreList.Name = "lstboxGenreList";
            this.lstboxGenreList.ScrollAlwaysVisible = true;
            this.lstboxGenreList.Size = new System.Drawing.Size(209, 82);
            this.lstboxGenreList.TabIndex = 2;
            this.lstboxGenreList.ValueMember = "Tracks";
            this.lstboxGenreList.DoubleClick += new System.EventHandler(this.lstboxGenreList_DoubleClick);
            // 
            // txtPresentlyPlaying
            // 
            this.txtPresentlyPlaying.BackColor = System.Drawing.Color.Lime;
            this.txtPresentlyPlaying.Location = new System.Drawing.Point(117, 321);
            this.txtPresentlyPlaying.Name = "txtPresentlyPlaying";
            this.txtPresentlyPlaying.ReadOnly = true;
            this.txtPresentlyPlaying.Size = new System.Drawing.Size(246, 20);
            this.txtPresentlyPlaying.TabIndex = 3;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(320, 9);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(154, 13);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "Copyright © 2018. Casey Smith";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(169, 602);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(145, 37);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.ColumnWidth = 3;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(13, 38);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(169, 38);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 8;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(323, 38);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 95);
            this.listBox3.TabIndex = 9;
            // 
            // txtPlayingFilePath
            // 
            this.txtPlayingFilePath.Location = new System.Drawing.Point(12, 683);
            this.txtPlayingFilePath.Name = "txtPlayingFilePath";
            this.txtPlayingFilePath.Size = new System.Drawing.Size(460, 20);
            this.txtPlayingFilePath.TabIndex = 10;
            // 
            // btnNextGenre
            // 
            this.btnNextGenre.Location = new System.Drawing.Point(323, 266);
            this.btnNextGenre.Name = "btnNextGenre";
            this.btnNextGenre.Size = new System.Drawing.Size(22, 23);
            this.btnNextGenre.TabIndex = 11;
            this.btnNextGenre.Text = ">";
            this.btnNextGenre.UseVisualStyleBackColor = true;
            this.btnNextGenre.Click += new System.EventHandler(this.btnNextGenre_Click);
            // 
            // btnPrevGenre
            // 
            this.btnPrevGenre.Location = new System.Drawing.Point(135, 266);
            this.btnPrevGenre.Name = "btnPrevGenre";
            this.btnPrevGenre.Size = new System.Drawing.Size(22, 23);
            this.btnPrevGenre.TabIndex = 12;
            this.btnPrevGenre.Text = "<";
            this.btnPrevGenre.UseVisualStyleBackColor = true;
            // 
            // lstboxPlaylist
            // 
            this.lstboxPlaylist.BackColor = System.Drawing.Color.Bisque;
            this.lstboxPlaylist.FormattingEnabled = true;
            this.lstboxPlaylist.Location = new System.Drawing.Point(156, 341);
            this.lstboxPlaylist.Name = "lstboxPlaylist";
            this.lstboxPlaylist.Size = new System.Drawing.Size(169, 121);
            this.lstboxPlaylist.TabIndex = 13;
            // 
            // myJukeboxMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(484, 730);
            this.Controls.Add(this.lstboxPlaylist);
            this.Controls.Add(this.btnPrevGenre);
            this.Controls.Add(this.btnNextGenre);
            this.Controls.Add(this.txtPlayingFilePath);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.txtPresentlyPlaying);
            this.Controls.Add(this.lstboxGenreList);
            this.Controls.Add(this.txtGenreTitle);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "myJukeboxMainForm";
            this.Text = "My Juke Box v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtGenreTitle;
        private System.Windows.Forms.ListBox lstboxGenreList;
        private System.Windows.Forms.TextBox txtPresentlyPlaying;
        private System.Windows.Forms.Label lblCopyright;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox txtPlayingFilePath;
        private System.Windows.Forms.Button btnNextGenre;
        private System.Windows.Forms.Button btnPrevGenre;
        private System.Windows.Forms.ListBox lstboxPlaylist;
    }
}

