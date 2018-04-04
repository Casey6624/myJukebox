namespace myJukebox
{
    partial class setupForm
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
            this.groupBoxImported = new System.Windows.Forms.GroupBox();
            this.btnClearImportTracks = new System.Windows.Forms.Button();
            this.btnImportFromDirectory = new System.Windows.Forms.Button();
            this.lstBoxImportedTracks = new System.Windows.Forms.ListBox();
            this.btnCopyTrack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblGeneraTitle = new System.Windows.Forms.Label();
            this.txtGeneraTitle = new System.Windows.Forms.TextBox();
            this.lstBoxCurrentTracks = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMoveTrack = new System.Windows.Forms.Button();
            this.btnDelFromGenera = new System.Windows.Forms.Button();
            this.groupBoxImported.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxImported
            // 
            this.groupBoxImported.Controls.Add(this.btnClearImportTracks);
            this.groupBoxImported.Controls.Add(this.btnImportFromDirectory);
            this.groupBoxImported.Controls.Add(this.lstBoxImportedTracks);
            this.groupBoxImported.Location = new System.Drawing.Point(13, 13);
            this.groupBoxImported.Name = "groupBoxImported";
            this.groupBoxImported.Size = new System.Drawing.Size(304, 353);
            this.groupBoxImported.TabIndex = 0;
            this.groupBoxImported.TabStop = false;
            this.groupBoxImported.Text = "Imported Tracks";
            // 
            // btnClearImportTracks
            // 
            this.btnClearImportTracks.Location = new System.Drawing.Point(7, 320);
            this.btnClearImportTracks.Name = "btnClearImportTracks";
            this.btnClearImportTracks.Size = new System.Drawing.Size(291, 23);
            this.btnClearImportTracks.TabIndex = 2;
            this.btnClearImportTracks.Text = "Clear Import Tracks";
            this.btnClearImportTracks.UseVisualStyleBackColor = true;
            // 
            // btnImportFromDirectory
            // 
            this.btnImportFromDirectory.Location = new System.Drawing.Point(7, 291);
            this.btnImportFromDirectory.Name = "btnImportFromDirectory";
            this.btnImportFromDirectory.Size = new System.Drawing.Size(291, 23);
            this.btnImportFromDirectory.TabIndex = 1;
            this.btnImportFromDirectory.Text = "Import From Directory";
            this.btnImportFromDirectory.UseVisualStyleBackColor = true;
            this.btnImportFromDirectory.Click += new System.EventHandler(this.btnImportFromDirectory_Click);
            // 
            // lstBoxImportedTracks
            // 
            this.lstBoxImportedTracks.FormattingEnabled = true;
            this.lstBoxImportedTracks.Location = new System.Drawing.Point(7, 20);
            this.lstBoxImportedTracks.Name = "lstBoxImportedTracks";
            this.lstBoxImportedTracks.Size = new System.Drawing.Size(291, 264);
            this.lstBoxImportedTracks.TabIndex = 0;
            // 
            // btnCopyTrack
            // 
            this.btnCopyTrack.Location = new System.Drawing.Point(324, 75);
            this.btnCopyTrack.Name = "btnCopyTrack";
            this.btnCopyTrack.Size = new System.Drawing.Size(97, 23);
            this.btnCopyTrack.TabIndex = 1;
            this.btnCopyTrack.Text = "Copy Track >>";
            this.btnCopyTrack.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.lblGeneraTitle);
            this.groupBox1.Controls.Add(this.txtGeneraTitle);
            this.groupBox1.Controls.Add(this.lstBoxCurrentTracks);
            this.groupBox1.Location = new System.Drawing.Point(432, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 353);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Present Genre Track List";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(108, 321);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(66, 24);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(108, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 24);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(180, 290);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(81, 54);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(19, 290);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(81, 54);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "<< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // lblGeneraTitle
            // 
            this.lblGeneraTitle.AutoSize = true;
            this.lblGeneraTitle.Location = new System.Drawing.Point(16, 17);
            this.lblGeneraTitle.Name = "lblGeneraTitle";
            this.lblGeneraTitle.Size = new System.Drawing.Size(65, 13);
            this.lblGeneraTitle.TabIndex = 2;
            this.lblGeneraTitle.Text = "Genera Title";
            // 
            // txtGeneraTitle
            // 
            this.txtGeneraTitle.Location = new System.Drawing.Point(19, 33);
            this.txtGeneraTitle.Name = "txtGeneraTitle";
            this.txtGeneraTitle.Size = new System.Drawing.Size(242, 20);
            this.txtGeneraTitle.TabIndex = 1;
            // 
            // lstBoxCurrentTracks
            // 
            this.lstBoxCurrentTracks.FormattingEnabled = true;
            this.lstBoxCurrentTracks.Location = new System.Drawing.Point(19, 63);
            this.lstBoxCurrentTracks.Name = "lstBoxCurrentTracks";
            this.lstBoxCurrentTracks.Size = new System.Drawing.Size(242, 212);
            this.lstBoxCurrentTracks.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(561, 389);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(642, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMoveTrack
            // 
            this.btnMoveTrack.Location = new System.Drawing.Point(324, 118);
            this.btnMoveTrack.Name = "btnMoveTrack";
            this.btnMoveTrack.Size = new System.Drawing.Size(97, 23);
            this.btnMoveTrack.TabIndex = 5;
            this.btnMoveTrack.Text = "Move Track >>";
            this.btnMoveTrack.UseVisualStyleBackColor = true;
            // 
            // btnDelFromGenera
            // 
            this.btnDelFromGenera.Location = new System.Drawing.Point(324, 160);
            this.btnDelFromGenera.Name = "btnDelFromGenera";
            this.btnDelFromGenera.Size = new System.Drawing.Size(97, 62);
            this.btnDelFromGenera.TabIndex = 6;
            this.btnDelFromGenera.Text = "Delete Track From Genera";
            this.btnDelFromGenera.UseVisualStyleBackColor = true;
            // 
            // setupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 421);
            this.Controls.Add(this.btnDelFromGenera);
            this.Controls.Add(this.btnMoveTrack);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCopyTrack);
            this.Controls.Add(this.groupBoxImported);
            this.Name = "setupForm";
            this.Text = "Setup";
            this.groupBoxImported.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxImported;
        private System.Windows.Forms.Button btnClearImportTracks;
        private System.Windows.Forms.Button btnImportFromDirectory;
        private System.Windows.Forms.ListBox lstBoxImportedTracks;
        private System.Windows.Forms.Button btnCopyTrack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblGeneraTitle;
        private System.Windows.Forms.TextBox txtGeneraTitle;
        private System.Windows.Forms.ListBox lstBoxCurrentTracks;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMoveTrack;
        private System.Windows.Forms.Button btnDelFromGenera;
    }
}