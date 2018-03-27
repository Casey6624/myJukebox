namespace myJukebox
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
            this.txtPlaylist = new System.Windows.Forms.TextBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
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
            this.lstboxGenreList.FormattingEnabled = true;
            this.lstboxGenreList.HorizontalScrollbar = true;
            this.lstboxGenreList.Location = new System.Drawing.Point(135, 207);
            this.lstboxGenreList.Name = "lstboxGenreList";
            this.lstboxGenreList.ScrollAlwaysVisible = true;
            this.lstboxGenreList.Size = new System.Drawing.Size(209, 82);
            this.lstboxGenreList.TabIndex = 2;
            // 
            // txtPresentlyPlaying
            // 
            this.txtPresentlyPlaying.BackColor = System.Drawing.Color.Lime;
            this.txtPresentlyPlaying.Location = new System.Drawing.Point(118, 321);
            this.txtPresentlyPlaying.Name = "txtPresentlyPlaying";
            this.txtPresentlyPlaying.ReadOnly = true;
            this.txtPresentlyPlaying.Size = new System.Drawing.Size(237, 20);
            this.txtPresentlyPlaying.TabIndex = 3;
            // 
            // txtPlaylist
            // 
            this.txtPlaylist.BackColor = System.Drawing.Color.Khaki;
            this.txtPlaylist.Location = new System.Drawing.Point(157, 347);
            this.txtPlaylist.Multiline = true;
            this.txtPlaylist.Name = "txtPlaylist";
            this.txtPlaylist.ReadOnly = true;
            this.txtPlaylist.Size = new System.Drawing.Size(169, 131);
            this.txtPlaylist.TabIndex = 4;
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
            // myJukeboxMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(484, 730);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.txtPlaylist);
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
        private System.Windows.Forms.TextBox txtPlaylist;
        private System.Windows.Forms.Label lblCopyright;
    }
}

