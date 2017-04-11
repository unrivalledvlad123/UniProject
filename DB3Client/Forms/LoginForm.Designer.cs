using System.Drawing;
using Common.Forms.Base;

namespace DB3Client.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.metroLabel1 = new MLLabel();
            this.metroLabel2 = new MLLabel();
            this.btnLogin = new MLButton();
            this.groupBox1 = new MLGroupBox();
            this.tbPassword = new MLTextBox();
            this.tbUsername = new MLTextBox();
            this.cbLanguage = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MLLabel();
            this.tbServer = new MLTextBox();
            this.metroLabel4 = new MLLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelError = new Common.Forms.Base.MLLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(280, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Username:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Language:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(379, 203);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelError);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.cbLanguage);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.tbServer);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(23, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 232);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.CustomButton.Image = null;
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(280, 102);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(197, 29);
            this.tbPassword.TabIndex = 9;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbPassword.PasswordChar = '*';
            // 
            // tbUsername
            // 
            // 
            // 
            // 
            this.tbUsername.CustomButton.Image = null;
            this.tbUsername.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.tbUsername.CustomButton.Name = "";
            this.tbUsername.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUsername.CustomButton.TabIndex = 1;
            this.tbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUsername.CustomButton.UseSelectable = true;
            this.tbUsername.CustomButton.Visible = false;
            this.tbUsername.Lines = new string[0];
            this.tbUsername.Location = new System.Drawing.Point(280, 48);
            this.tbUsername.MaxLength = 32767;
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUsername.SelectedText = "";
            this.tbUsername.SelectionLength = 0;
            this.tbUsername.SelectionStart = 0;
            this.tbUsername.ShortcutsEnabled = true;
            this.tbUsername.Size = new System.Drawing.Size(197, 29);
            this.tbUsername.TabIndex = 8;
            this.tbUsername.UseSelectable = true;
            this.tbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.ItemHeight = 23;
            this.cbLanguage.Location = new System.Drawing.Point(6, 102);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(198, 29);
            this.cbLanguage.TabIndex = 7;
            this.cbLanguage.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 26);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Server:";
            // 
            // tbServer
            // 
            // 
            // 
            // 
            this.tbServer.CustomButton.Image = null;
            this.tbServer.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.tbServer.CustomButton.Name = "";
            this.tbServer.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbServer.CustomButton.TabIndex = 1;
            this.tbServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbServer.CustomButton.UseSelectable = true;
            this.tbServer.CustomButton.Visible = false;
            this.tbServer.Lines = new string[0];
            this.tbServer.Location = new System.Drawing.Point(5, 48);
            this.tbServer.MaxLength = 32767;
            this.tbServer.Multiline = true;
            this.tbServer.Name = "tbServer";
            this.tbServer.PasswordChar = '\0';
            this.tbServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbServer.SelectedText = "";
            this.tbServer.SelectionLength = 0;
            this.tbServer.SelectionStart = 0;
            this.tbServer.ShortcutsEnabled = true;
            this.tbServer.Size = new System.Drawing.Size(197, 29);
            this.tbServer.TabIndex = 5;
            this.tbServer.UseSelectable = true;
            this.tbServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(280, 77);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 261);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelError.Location = new System.Drawing.Point(7, 138);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 0);
            this.labelError.TabIndex = 10;
            this.labelError.ForeColor = Color.Red;
            this.labelError.Visible = false;
            this.labelError.Text = "invalid_username_or_password";
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(556, 535);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MLLabel metroLabel1;
        private MLLabel metroLabel2;
        private MLButton btnLogin;
        private MLGroupBox groupBox1;
        private MLLabel metroLabel3;
        private MLTextBox tbServer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MLLabel metroLabel4;
        private MLTextBox tbPassword;
        private MLTextBox tbUsername;
        private MetroFramework.Controls.MetroComboBox cbLanguage;
        private MLLabel labelError;
    }
}