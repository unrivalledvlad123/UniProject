using System.Windows.Forms;

namespace DB3Client.Forms.AdminForms
{
    partial class AddNewUserForm
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
            this.tbPassword = new Common.Forms.Base.MLTextBox();
            this.mlLabel2 = new Common.Forms.Base.MLLabel();
            this.mlLabel3 = new Common.Forms.Base.MLLabel();
            this.tbPassword2 = new Common.Forms.Base.MLTextBox();
            this.labelError = new Common.Forms.Base.MLErrorLabel();
            this.btncCancel = new Common.Forms.Base.MLButton();
            this.btnSave = new Common.Forms.Base.MLButton();
            this.cbUserRole = new Common.Forms.Base.MLComboBox();
            this.tbAssignedTo = new Common.Forms.Base.MLTextBox();
            this.mlLabel5 = new Common.Forms.Base.MLLabel();
            this.mlLabel6 = new Common.Forms.Base.MLLabel();
            this.tbUsername = new Common.Forms.Base.MLTextBox();
            this.mlLabel1 = new Common.Forms.Base.MLLabel();
            this.mlGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlGroupBox1
            // 
            this.mlGroupBox1.Controls.Add(this.tbPassword);
            this.mlGroupBox1.Controls.Add(this.mlLabel2);
            this.mlGroupBox1.Controls.Add(this.mlLabel3);
            this.mlGroupBox1.Controls.Add(this.tbPassword2);
            this.mlGroupBox1.Controls.Add(this.labelError);
            this.mlGroupBox1.Controls.Add(this.btncCancel);
            this.mlGroupBox1.Controls.Add(this.btnSave);
            this.mlGroupBox1.Controls.Add(this.cbUserRole);
            this.mlGroupBox1.Controls.Add(this.tbAssignedTo);
            this.mlGroupBox1.Controls.Add(this.mlLabel5);
            this.mlGroupBox1.Controls.Add(this.mlLabel6);
            this.mlGroupBox1.Controls.Add(this.tbUsername);
            this.mlGroupBox1.Controls.Add(this.mlLabel1);
            this.mlGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlGroupBox1.Location = new System.Drawing.Point(20, 60);
            this.mlGroupBox1.Name = "mlGroupBox1";
            this.mlGroupBox1.Size = new System.Drawing.Size(374, 449);
            this.mlGroupBox1.TabIndex = 0;
            this.mlGroupBox1.TabStop = false;
            this.mlGroupBox1.Text = "create_new_user";
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.CustomButton.Image = null;
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(202, 54);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(159, 23);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlLabel2
            // 
            this.mlLabel2.AutoSize = true;
            this.mlLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel2.Location = new System.Drawing.Point(7, 54);
            this.mlLabel2.Name = "mlLabel2";
            this.mlLabel2.Size = new System.Drawing.Size(67, 19);
            this.mlLabel2.TabIndex = 2;
            this.mlLabel2.Text = "password";
            // 
            // mlLabel3
            // 
            this.mlLabel3.AutoSize = true;
            this.mlLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel3.Location = new System.Drawing.Point(7, 92);
            this.mlLabel3.Name = "mlLabel3";
            this.mlLabel3.Size = new System.Drawing.Size(112, 19);
            this.mlLabel3.TabIndex = 4;
            this.mlLabel3.Text = "repeat_password";
            // 
            // tbPassword2
            // 
            // 
            // 
            // 
            this.tbPassword2.CustomButton.Image = null;
            this.tbPassword2.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.tbPassword2.CustomButton.Name = "";
            this.tbPassword2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPassword2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword2.CustomButton.TabIndex = 1;
            this.tbPassword2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword2.CustomButton.UseSelectable = true;
            this.tbPassword2.CustomButton.Visible = false;
            this.tbPassword2.Lines = new string[0];
            this.tbPassword2.Location = new System.Drawing.Point(202, 92);
            this.tbPassword2.MaxLength = 32767;
            this.tbPassword2.Name = "tbPassword2";
            this.tbPassword2.PasswordChar = '*';
            this.tbPassword2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword2.SelectedText = "";
            this.tbPassword2.SelectionLength = 0;
            this.tbPassword2.SelectionStart = 0;
            this.tbPassword2.ShortcutsEnabled = true;
            this.tbPassword2.Size = new System.Drawing.Size(159, 23);
            this.tbPassword2.TabIndex = 5;
            this.tbPassword2.UseSelectable = true;
            this.tbPassword2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelError
            // 
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(6, 214);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(357, 71);
            this.labelError.TabIndex = 13;
            this.labelError.Text = "empty_username_or_password";
            this.labelError.Visible = false;
            // 
            // btncCancel
            // 
            this.btncCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncCancel.Location = new System.Drawing.Point(260, 398);
            this.btncCancel.Name = "btncCancel";
            this.btncCancel.Size = new System.Drawing.Size(104, 23);
            this.btncCancel.TabIndex = 12;
            this.btncCancel.Text = "cancel";
            this.btncCancel.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbUserRole
            // 
            this.cbUserRole.FormattingEnabled = true;
            this.cbUserRole.ItemHeight = 23;
            this.cbUserRole.Location = new System.Drawing.Point(202, 130);
            this.cbUserRole.Name = "cbUserRole";
            this.cbUserRole.Size = new System.Drawing.Size(159, 29);
            this.cbUserRole.TabIndex = 10;
            this.cbUserRole.UseSelectable = true;
            // 
            // tbAssignedTo
            // 
            // 
            // 
            // 
            this.tbAssignedTo.CustomButton.Image = null;
            this.tbAssignedTo.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.tbAssignedTo.CustomButton.Name = "";
            this.tbAssignedTo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAssignedTo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAssignedTo.CustomButton.TabIndex = 1;
            this.tbAssignedTo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAssignedTo.CustomButton.UseSelectable = true;
            this.tbAssignedTo.CustomButton.Visible = false;
            this.tbAssignedTo.Lines = new string[0];
            this.tbAssignedTo.Location = new System.Drawing.Point(202, 174);
            this.tbAssignedTo.MaxLength = 32767;
            this.tbAssignedTo.Name = "tbAssignedTo";
            this.tbAssignedTo.PasswordChar = '\0';
            this.tbAssignedTo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAssignedTo.SelectedText = "";
            this.tbAssignedTo.SelectionLength = 0;
            this.tbAssignedTo.SelectionStart = 0;
            this.tbAssignedTo.ShortcutsEnabled = true;
            this.tbAssignedTo.Size = new System.Drawing.Size(159, 23);
            this.tbAssignedTo.TabIndex = 9;
            this.tbAssignedTo.UseSelectable = true;
            this.tbAssignedTo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAssignedTo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlLabel5
            // 
            this.mlLabel5.AutoSize = true;
            this.mlLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel5.Location = new System.Drawing.Point(7, 178);
            this.mlLabel5.Name = "mlLabel5";
            this.mlLabel5.Size = new System.Drawing.Size(81, 19);
            this.mlLabel5.TabIndex = 8;
            this.mlLabel5.Text = "assigned_to";
            // 
            // mlLabel6
            // 
            this.mlLabel6.AutoSize = true;
            this.mlLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel6.Location = new System.Drawing.Point(7, 140);
            this.mlLabel6.Name = "mlLabel6";
            this.mlLabel6.Size = new System.Drawing.Size(64, 19);
            this.mlLabel6.TabIndex = 6;
            this.mlLabel6.Text = "user_role";
            // 
            // tbUsername
            // 
            // 
            // 
            // 
            this.tbUsername.CustomButton.Image = null;
            this.tbUsername.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.tbUsername.CustomButton.Name = "";
            this.tbUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUsername.CustomButton.TabIndex = 1;
            this.tbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUsername.CustomButton.UseSelectable = true;
            this.tbUsername.CustomButton.Visible = false;
            this.tbUsername.Lines = new string[0];
            this.tbUsername.Location = new System.Drawing.Point(202, 16);
            this.tbUsername.MaxLength = 32767;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUsername.SelectedText = "";
            this.tbUsername.SelectionLength = 0;
            this.tbUsername.SelectionStart = 0;
            this.tbUsername.ShortcutsEnabled = true;
            this.tbUsername.Size = new System.Drawing.Size(159, 23);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.UseSelectable = true;
            this.tbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlLabel1
            // 
            this.mlLabel1.AutoSize = true;
            this.mlLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel1.Location = new System.Drawing.Point(9, 20);
            this.mlLabel1.Name = "mlLabel1";
            this.mlLabel1.Size = new System.Drawing.Size(69, 19);
            this.mlLabel1.TabIndex = 0;
            this.mlLabel1.Text = "username";
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 529);
            this.Controls.Add(this.mlGroupBox1);
            this.Name = "AddNewUserForm";
            this.mlGroupBox1.ResumeLayout(false);
            this.mlGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Forms.Base.MLGroupBox mlGroupBox1;
        private Common.Forms.Base.MLTextBox tbUsername;
        private Common.Forms.Base.MLLabel mlLabel1;
        private Common.Forms.Base.MLTextBox tbAssignedTo;
        private Common.Forms.Base.MLLabel mlLabel5;
        private Common.Forms.Base.MLLabel mlLabel6;
        private Common.Forms.Base.MLTextBox tbPassword2;
        private Common.Forms.Base.MLLabel mlLabel3;
        private Common.Forms.Base.MLTextBox tbPassword;
        private Common.Forms.Base.MLLabel mlLabel2;
        private Common.Forms.Base.MLButton btncCancel;
        private Common.Forms.Base.MLButton btnSave;
        private Common.Forms.Base.MLComboBox cbUserRole;
        private Common.Forms.Base.MLErrorLabel labelError;
    }
}