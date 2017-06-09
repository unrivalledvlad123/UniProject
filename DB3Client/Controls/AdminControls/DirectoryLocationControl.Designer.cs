namespace DB3Client.Controls.AdminControls
{
    partial class DirectoryLocationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mlGroupBox1 = new Common.Forms.Base.MLGroupBox();
            this.labelError = new Common.Forms.Base.MLErrorLabel();
            this.btnSave = new Common.Forms.Base.MLButton();
            this.ff = new Common.Forms.Base.MLLabel();
            this.tbPdfSaveLocation = new Common.Forms.Base.MLTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.mlGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlGroupBox1
            // 
            this.mlGroupBox1.BackColor = System.Drawing.Color.White;
            this.mlGroupBox1.Controls.Add(this.labelError);
            this.mlGroupBox1.Controls.Add(this.btnSave);
            this.mlGroupBox1.Controls.Add(this.ff);
            this.mlGroupBox1.Controls.Add(this.tbPdfSaveLocation);
            this.mlGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.mlGroupBox1.Name = "mlGroupBox1";
            this.mlGroupBox1.Size = new System.Drawing.Size(596, 508);
            this.mlGroupBox1.TabIndex = 7;
            this.mlGroupBox1.TabStop = false;
            this.mlGroupBox1.Text = "directory_settings";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(6, 93);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(237, 67);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ff
            // 
            this.ff.AutoSize = true;
            this.ff.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ff.Location = new System.Drawing.Point(6, 16);
            this.ff.Name = "ff";
            this.ff.Size = new System.Drawing.Size(116, 19);
            this.ff.TabIndex = 5;
            this.ff.Text = "pdf_save_location";
            // 
            // tbPdfSaveLocation
            // 
            // 
            // 
            // 
            this.tbPdfSaveLocation.CustomButton.Image = null;
            this.tbPdfSaveLocation.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.tbPdfSaveLocation.CustomButton.Name = "";
            this.tbPdfSaveLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPdfSaveLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPdfSaveLocation.CustomButton.TabIndex = 1;
            this.tbPdfSaveLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPdfSaveLocation.CustomButton.UseSelectable = true;
            this.tbPdfSaveLocation.CustomButton.Visible = false;
            this.tbPdfSaveLocation.Lines = new string[0];
            this.tbPdfSaveLocation.Location = new System.Drawing.Point(7, 38);
            this.tbPdfSaveLocation.MaxLength = 32767;
            this.tbPdfSaveLocation.Name = "tbPdfSaveLocation";
            this.tbPdfSaveLocation.PasswordChar = '\0';
            this.tbPdfSaveLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPdfSaveLocation.SelectedText = "";
            this.tbPdfSaveLocation.SelectionLength = 0;
            this.tbPdfSaveLocation.SelectionStart = 0;
            this.tbPdfSaveLocation.ShortcutsEnabled = true;
            this.tbPdfSaveLocation.Size = new System.Drawing.Size(306, 23);
            this.tbPdfSaveLocation.TabIndex = 6;
            this.tbPdfSaveLocation.UseSelectable = true;
            this.tbPdfSaveLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPdfSaveLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbPdfSaveLocation.Click += new System.EventHandler(this.tbPdfSaveLocation_Click);
            // 
            // DirectoryLocationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mlGroupBox1);
            this.Name = "DirectoryLocationControl";
            this.Size = new System.Drawing.Size(596, 508);
            this.mlGroupBox1.ResumeLayout(false);
            this.mlGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Forms.Base.MLTextBox tbPdfSaveLocation;
        private Common.Forms.Base.MLLabel ff;
        private Common.Forms.Base.MLGroupBox mlGroupBox1;
        private Common.Forms.Base.MLButton btnSave;
        private Common.Forms.Base.MLErrorLabel labelError;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
