namespace myJukebox
{
    partial class aboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutForm));
            this.lblAboutTitle = new System.Windows.Forms.Label();
            this.picJukeBoxAbout = new System.Windows.Forms.PictureBox();
            this.btnOkAbout = new System.Windows.Forms.Button();
            this.txtAboutInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picJukeBoxAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAboutTitle
            // 
            this.lblAboutTitle.AutoSize = true;
            this.lblAboutTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutTitle.Location = new System.Drawing.Point(233, 12);
            this.lblAboutTitle.Name = "lblAboutTitle";
            this.lblAboutTitle.Size = new System.Drawing.Size(171, 24);
            this.lblAboutTitle.TabIndex = 0;
            this.lblAboutTitle.Text = "My Juke Box v1.0";
            // 
            // picJukeBoxAbout
            // 
            this.picJukeBoxAbout.Image = ((System.Drawing.Image)(resources.GetObject("picJukeBoxAbout.Image")));
            this.picJukeBoxAbout.Location = new System.Drawing.Point(12, 12);
            this.picJukeBoxAbout.Name = "picJukeBoxAbout";
            this.picJukeBoxAbout.Size = new System.Drawing.Size(200, 236);
            this.picJukeBoxAbout.TabIndex = 1;
            this.picJukeBoxAbout.TabStop = false;
            // 
            // btnOkAbout
            // 
            this.btnOkAbout.Location = new System.Drawing.Point(161, 254);
            this.btnOkAbout.Name = "btnOkAbout";
            this.btnOkAbout.Size = new System.Drawing.Size(112, 23);
            this.btnOkAbout.TabIndex = 2;
            this.btnOkAbout.Text = "OK";
            this.btnOkAbout.UseVisualStyleBackColor = true;
            this.btnOkAbout.Click += new System.EventHandler(this.btnOkAbout_Click);
            // 
            // txtAboutInfo
            // 
            this.txtAboutInfo.Location = new System.Drawing.Point(237, 54);
            this.txtAboutInfo.Multiline = true;
            this.txtAboutInfo.Name = "txtAboutInfo";
            this.txtAboutInfo.ReadOnly = true;
            this.txtAboutInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAboutInfo.Size = new System.Drawing.Size(162, 159);
            this.txtAboutInfo.TabIndex = 3;
            this.txtAboutInfo.Text = resources.GetString("txtAboutInfo.Text");
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 288);
            this.Controls.Add(this.txtAboutInfo);
            this.Controls.Add(this.btnOkAbout);
            this.Controls.Add(this.picJukeBoxAbout);
            this.Controls.Add(this.lblAboutTitle);
            this.Name = "aboutForm";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.picJukeBoxAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAboutTitle;
        private System.Windows.Forms.PictureBox picJukeBoxAbout;
        private System.Windows.Forms.Button btnOkAbout;
        private System.Windows.Forms.TextBox txtAboutInfo;
    }
}