namespace DB3Client.Forms.AdminForms
{
    partial class EditForm
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
            this.mlGroupBox1 = new Common.Forms.Base.MLGroupBox();
            this.btnCancel = new Common.Forms.Base.MLButton();
            this.btnSave = new Common.Forms.Base.MLButton();
            this.tbEmail = new Common.Forms.Base.MLTextBox();
            this.labelEmail = new Common.Forms.Base.MLLabel();
            this.tbPhone = new Common.Forms.Base.MLTextBox();
            this.labelPhone = new Common.Forms.Base.MLLabel();
            this.tbAddress = new Common.Forms.Base.MLTextBox();
            this.labelAddress = new Common.Forms.Base.MLLabel();
            this.tbCompanyName = new Common.Forms.Base.MLTextBox();
            this.labelName = new Common.Forms.Base.MLLabel();
            this.mlGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlGroupBox1
            // 
            this.mlGroupBox1.BackColor = System.Drawing.Color.White;
            this.mlGroupBox1.Controls.Add(this.btnCancel);
            this.mlGroupBox1.Controls.Add(this.btnSave);
            this.mlGroupBox1.Controls.Add(this.tbEmail);
            this.mlGroupBox1.Controls.Add(this.labelEmail);
            this.mlGroupBox1.Controls.Add(this.tbPhone);
            this.mlGroupBox1.Controls.Add(this.labelPhone);
            this.mlGroupBox1.Controls.Add(this.tbAddress);
            this.mlGroupBox1.Controls.Add(this.labelAddress);
            this.mlGroupBox1.Controls.Add(this.tbCompanyName);
            this.mlGroupBox1.Controls.Add(this.labelName);
            this.mlGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlGroupBox1.Location = new System.Drawing.Point(20, 60);
            this.mlGroupBox1.Name = "mlGroupBox1";
            this.mlGroupBox1.Size = new System.Drawing.Size(359, 440);
            this.mlGroupBox1.TabIndex = 1;
            this.mlGroupBox1.TabStop = false;
            this.mlGroupBox1.Text = "company_info";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(260, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(156, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbEmail
            // 
            // 
            // 
            // 
            this.tbEmail.CustomButton.Image = null;
            this.tbEmail.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.tbEmail.CustomButton.Name = "";
            this.tbEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEmail.CustomButton.TabIndex = 1;
            this.tbEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEmail.CustomButton.UseSelectable = true;
            this.tbEmail.CustomButton.Visible = false;
            this.tbEmail.Lines = new string[0];
            this.tbEmail.Location = new System.Drawing.Point(156, 131);
            this.tbEmail.MaxLength = 32767;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEmail.SelectedText = "";
            this.tbEmail.SelectionLength = 0;
            this.tbEmail.SelectionStart = 0;
            this.tbEmail.ShortcutsEnabled = true;
            this.tbEmail.Size = new System.Drawing.Size(197, 23);
            this.tbEmail.TabIndex = 7;
            this.tbEmail.UseSelectable = true;
            this.tbEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelEmail.Location = new System.Drawing.Point(7, 135);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 19);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "email";
            // 
            // tbPhone
            // 
            // 
            // 
            // 
            this.tbPhone.CustomButton.Image = null;
            this.tbPhone.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.tbPhone.CustomButton.Name = "";
            this.tbPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPhone.CustomButton.TabIndex = 1;
            this.tbPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPhone.CustomButton.UseSelectable = true;
            this.tbPhone.CustomButton.Visible = false;
            this.tbPhone.Lines = new string[0];
            this.tbPhone.Location = new System.Drawing.Point(156, 93);
            this.tbPhone.MaxLength = 32767;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PasswordChar = '\0';
            this.tbPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPhone.SelectedText = "";
            this.tbPhone.SelectionLength = 0;
            this.tbPhone.SelectionStart = 0;
            this.tbPhone.ShortcutsEnabled = true;
            this.tbPhone.Size = new System.Drawing.Size(197, 23);
            this.tbPhone.TabIndex = 5;
            this.tbPhone.UseSelectable = true;
            this.tbPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelPhone.Location = new System.Drawing.Point(7, 97);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(48, 19);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "phone";
            // 
            // tbAddress
            // 
            // 
            // 
            // 
            this.tbAddress.CustomButton.Image = null;
            this.tbAddress.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.tbAddress.CustomButton.Name = "";
            this.tbAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAddress.CustomButton.TabIndex = 1;
            this.tbAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAddress.CustomButton.UseSelectable = true;
            this.tbAddress.CustomButton.Visible = false;
            this.tbAddress.Lines = new string[0];
            this.tbAddress.Location = new System.Drawing.Point(156, 54);
            this.tbAddress.MaxLength = 32767;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PasswordChar = '\0';
            this.tbAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAddress.SelectedText = "";
            this.tbAddress.SelectionLength = 0;
            this.tbAddress.SelectionStart = 0;
            this.tbAddress.ShortcutsEnabled = true;
            this.tbAddress.Size = new System.Drawing.Size(197, 23);
            this.tbAddress.TabIndex = 3;
            this.tbAddress.UseSelectable = true;
            this.tbAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelAddress.Location = new System.Drawing.Point(7, 58);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(56, 19);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "address";
            // 
            // tbCompanyName
            // 
            // 
            // 
            // 
            this.tbCompanyName.CustomButton.Image = null;
            this.tbCompanyName.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.tbCompanyName.CustomButton.Name = "";
            this.tbCompanyName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCompanyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCompanyName.CustomButton.TabIndex = 1;
            this.tbCompanyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCompanyName.CustomButton.UseSelectable = true;
            this.tbCompanyName.CustomButton.Visible = false;
            this.tbCompanyName.Lines = new string[0];
            this.tbCompanyName.Location = new System.Drawing.Point(156, 16);
            this.tbCompanyName.MaxLength = 32767;
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.PasswordChar = '\0';
            this.tbCompanyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCompanyName.SelectedText = "";
            this.tbCompanyName.SelectionLength = 0;
            this.tbCompanyName.SelectionStart = 0;
            this.tbCompanyName.ShortcutsEnabled = true;
            this.tbCompanyName.Size = new System.Drawing.Size(197, 23);
            this.tbCompanyName.TabIndex = 1;
            this.tbCompanyName.UseSelectable = true;
            this.tbCompanyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCompanyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelName.Location = new System.Drawing.Point(7, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(105, 19);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "company_name";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 520);
            this.Controls.Add(this.mlGroupBox1);
            this.Name = "EditForm";
            this.mlGroupBox1.ResumeLayout(false);
            this.mlGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Forms.Base.MLGroupBox mlGroupBox1;
        private Common.Forms.Base.MLButton btnCancel;
        private Common.Forms.Base.MLButton btnSave;
        private Common.Forms.Base.MLTextBox tbEmail;
        private Common.Forms.Base.MLLabel labelEmail;
        private Common.Forms.Base.MLTextBox tbPhone;
        private Common.Forms.Base.MLLabel labelPhone;
        private Common.Forms.Base.MLTextBox tbAddress;
        private Common.Forms.Base.MLLabel labelAddress;
        private Common.Forms.Base.MLTextBox tbCompanyName;
        private Common.Forms.Base.MLLabel labelName;
    }
}