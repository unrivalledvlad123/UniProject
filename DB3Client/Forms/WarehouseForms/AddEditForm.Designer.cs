namespace DB3Client.Forms.WarehouseForms
{
    partial class AddEditForm
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
            this.mlErrorError = new Common.Forms.Base.MLErrorLabel();
            this.btnSave = new Common.Forms.Base.MLButton();
            this.btnCancel = new Common.Forms.Base.MLButton();
            this.labelDescriptionGoods = new Common.Forms.Base.MLLabel();
            this.labelTypeGoods = new Common.Forms.Base.MLLabel();
            this.labelNameGoods = new Common.Forms.Base.MLLabel();
            this.tbDescriptionGoods = new Common.Forms.Base.MLTextBox();
            this.tbTypeGoods = new Common.Forms.Base.MLTextBox();
            this.tbNameGoods = new Common.Forms.Base.MLTextBox();
            this.mlGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlGroupBox1
            // 
            this.mlGroupBox1.Controls.Add(this.mlErrorError);
            this.mlGroupBox1.Controls.Add(this.btnSave);
            this.mlGroupBox1.Controls.Add(this.btnCancel);
            this.mlGroupBox1.Controls.Add(this.labelDescriptionGoods);
            this.mlGroupBox1.Controls.Add(this.labelTypeGoods);
            this.mlGroupBox1.Controls.Add(this.labelNameGoods);
            this.mlGroupBox1.Controls.Add(this.tbDescriptionGoods);
            this.mlGroupBox1.Controls.Add(this.tbTypeGoods);
            this.mlGroupBox1.Controls.Add(this.tbNameGoods);
            this.mlGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlGroupBox1.Location = new System.Drawing.Point(20, 60);
            this.mlGroupBox1.Name = "mlGroupBox1";
            this.mlGroupBox1.Size = new System.Drawing.Size(374, 449);
            this.mlGroupBox1.TabIndex = 0;
            this.mlGroupBox1.TabStop = false;
            this.mlGroupBox1.Text = "add_edit_goods";
            // 
            // mlErrorError
            // 
            this.mlErrorError.AutoSize = true;
            this.mlErrorError.ForeColor = System.Drawing.Color.Red;
            this.mlErrorError.Location = new System.Drawing.Point(7, 390);
            this.mlErrorError.Name = "mlErrorError";
            this.mlErrorError.Size = new System.Drawing.Size(0, 13);
            this.mlErrorError.TabIndex = 8;
            this.mlErrorError.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(212, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(293, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseSelectable = true;
            // 
            // labelDescriptionGoods
            // 
            this.labelDescriptionGoods.AutoSize = true;
            this.labelDescriptionGoods.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelDescriptionGoods.Location = new System.Drawing.Point(4, 169);
            this.labelDescriptionGoods.Name = "labelDescriptionGoods";
            this.labelDescriptionGoods.Size = new System.Drawing.Size(110, 19);
            this.labelDescriptionGoods.TabIndex = 5;
            this.labelDescriptionGoods.Text = "label_description";
            // 
            // labelTypeGoods
            // 
            this.labelTypeGoods.AutoSize = true;
            this.labelTypeGoods.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelTypeGoods.Location = new System.Drawing.Point(7, 104);
            this.labelTypeGoods.Name = "labelTypeGoods";
            this.labelTypeGoods.Size = new System.Drawing.Size(114, 19);
            this.labelTypeGoods.TabIndex = 4;
            this.labelTypeGoods.Text = "label_type_goods";
            // 
            // labelNameGoods
            // 
            this.labelNameGoods.AutoSize = true;
            this.labelNameGoods.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelNameGoods.Location = new System.Drawing.Point(7, 47);
            this.labelNameGoods.Name = "labelNameGoods";
            this.labelNameGoods.Size = new System.Drawing.Size(121, 19);
            this.labelNameGoods.TabIndex = 3;
            this.labelNameGoods.Text = "label_name_goods";
            // 
            // tbDescriptionGoods
            // 
            // 
            // 
            // 
            this.tbDescriptionGoods.CustomButton.Image = null;
            this.tbDescriptionGoods.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.tbDescriptionGoods.CustomButton.Name = "";
            this.tbDescriptionGoods.CustomButton.Size = new System.Drawing.Size(187, 187);
            this.tbDescriptionGoods.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDescriptionGoods.CustomButton.TabIndex = 1;
            this.tbDescriptionGoods.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDescriptionGoods.CustomButton.UseSelectable = true;
            this.tbDescriptionGoods.CustomButton.Visible = false;
            this.tbDescriptionGoods.Lines = new string[0];
            this.tbDescriptionGoods.Location = new System.Drawing.Point(4, 191);
            this.tbDescriptionGoods.MaxLength = 32767;
            this.tbDescriptionGoods.Multiline = true;
            this.tbDescriptionGoods.Name = "tbDescriptionGoods";
            this.tbDescriptionGoods.PasswordChar = '\0';
            this.tbDescriptionGoods.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDescriptionGoods.SelectedText = "";
            this.tbDescriptionGoods.SelectionLength = 0;
            this.tbDescriptionGoods.SelectionStart = 0;
            this.tbDescriptionGoods.ShortcutsEnabled = true;
            this.tbDescriptionGoods.Size = new System.Drawing.Size(364, 192);
            this.tbDescriptionGoods.TabIndex = 2;
            this.tbDescriptionGoods.UseSelectable = true;
            this.tbDescriptionGoods.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDescriptionGoods.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbTypeGoods
            // 
            // 
            // 
            // 
            this.tbTypeGoods.CustomButton.Image = null;
            this.tbTypeGoods.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.tbTypeGoods.CustomButton.Name = "";
            this.tbTypeGoods.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTypeGoods.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTypeGoods.CustomButton.TabIndex = 1;
            this.tbTypeGoods.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTypeGoods.CustomButton.UseSelectable = true;
            this.tbTypeGoods.CustomButton.Visible = false;
            this.tbTypeGoods.Lines = new string[0];
            this.tbTypeGoods.Location = new System.Drawing.Point(7, 126);
            this.tbTypeGoods.MaxLength = 32767;
            this.tbTypeGoods.Name = "tbTypeGoods";
            this.tbTypeGoods.PasswordChar = '\0';
            this.tbTypeGoods.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTypeGoods.SelectedText = "";
            this.tbTypeGoods.SelectionLength = 0;
            this.tbTypeGoods.SelectionStart = 0;
            this.tbTypeGoods.ShortcutsEnabled = true;
            this.tbTypeGoods.Size = new System.Drawing.Size(159, 23);
            this.tbTypeGoods.TabIndex = 1;
            this.tbTypeGoods.UseSelectable = true;
            this.tbTypeGoods.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTypeGoods.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbNameGoods
            // 
            // 
            // 
            // 
            this.tbNameGoods.CustomButton.Image = null;
            this.tbNameGoods.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.tbNameGoods.CustomButton.Name = "";
            this.tbNameGoods.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNameGoods.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNameGoods.CustomButton.TabIndex = 1;
            this.tbNameGoods.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNameGoods.CustomButton.UseSelectable = true;
            this.tbNameGoods.CustomButton.Visible = false;
            this.tbNameGoods.Lines = new string[0];
            this.tbNameGoods.Location = new System.Drawing.Point(66, 69);
            this.tbNameGoods.MaxLength = 32767;
            this.tbNameGoods.Name = "tbNameGoods";
            this.tbNameGoods.PasswordChar = '\0';
            this.tbNameGoods.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNameGoods.SelectedText = "";
            this.tbNameGoods.SelectionLength = 0;
            this.tbNameGoods.SelectionStart = 0;
            this.tbNameGoods.ShortcutsEnabled = true;
            this.tbNameGoods.Size = new System.Drawing.Size(159, 23);
            this.tbNameGoods.TabIndex = 0;
            this.tbNameGoods.UseSelectable = true;
            this.tbNameGoods.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNameGoods.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 529);
            this.Controls.Add(this.mlGroupBox1);
            this.Name = "AddEditForm";
            this.mlGroupBox1.ResumeLayout(false);
            this.mlGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Forms.Base.MLGroupBox mlGroupBox1;
        private Common.Forms.Base.MLLabel labelDescriptionGoods;
        private Common.Forms.Base.MLLabel labelTypeGoods;
        private Common.Forms.Base.MLLabel labelNameGoods;
        private Common.Forms.Base.MLTextBox tbDescriptionGoods;
        private Common.Forms.Base.MLTextBox tbTypeGoods;
        private Common.Forms.Base.MLTextBox tbNameGoods;
        private Common.Forms.Base.MLButton btnSave;
        private Common.Forms.Base.MLButton btnCancel;
        private Common.Forms.Base.MLErrorLabel mlErrorError;
    }
}