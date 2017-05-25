namespace DB3Client.Controls.AdminControls
{
    partial class VatControl
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
            this.mlGroupBox3 = new Common.Forms.Base.MLGroupBox();
            this.cbItemTypes = new Common.Forms.Base.MLComboBox();
            this.tbVatMultiplier = new System.Windows.Forms.NumericUpDown();
            this.labelErrorSettings = new Common.Forms.Base.MLErrorLabel();
            this.btnSaveSettings = new Common.Forms.Base.MLButton();
            this.mlLabel1 = new Common.Forms.Base.MLLabel();
            this.mlGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVatMultiplier)).BeginInit();
            this.SuspendLayout();
            // 
            // mlGroupBox3
            // 
            this.mlGroupBox3.BackColor = System.Drawing.Color.White;
            this.mlGroupBox3.Controls.Add(this.cbItemTypes);
            this.mlGroupBox3.Controls.Add(this.tbVatMultiplier);
            this.mlGroupBox3.Controls.Add(this.labelErrorSettings);
            this.mlGroupBox3.Controls.Add(this.btnSaveSettings);
            this.mlGroupBox3.Controls.Add(this.mlLabel1);
            this.mlGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlGroupBox3.Location = new System.Drawing.Point(0, 0);
            this.mlGroupBox3.Name = "mlGroupBox3";
            this.mlGroupBox3.Size = new System.Drawing.Size(616, 533);
            this.mlGroupBox3.TabIndex = 3;
            this.mlGroupBox3.TabStop = false;
            this.mlGroupBox3.Text = "settings";
            // 
            // cbItemTypes
            // 
            this.cbItemTypes.FormattingEnabled = true;
            this.cbItemTypes.ItemHeight = 23;
            this.cbItemTypes.Location = new System.Drawing.Point(10, 39);
            this.cbItemTypes.Name = "cbItemTypes";
            this.cbItemTypes.Size = new System.Drawing.Size(222, 29);
            this.cbItemTypes.TabIndex = 8;
            this.cbItemTypes.UseSelectable = true;
            this.cbItemTypes.SelectionChangeCommitted += new System.EventHandler(this.cbItemTypes_SelectionChangeCommitted);
            // 
            // tbVatMultiplier
            // 
            this.tbVatMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbVatMultiplier.Location = new System.Drawing.Point(238, 39);
            this.tbVatMultiplier.Name = "tbVatMultiplier";
            this.tbVatMultiplier.Size = new System.Drawing.Size(75, 29);
            this.tbVatMultiplier.TabIndex = 7;
            // 
            // labelErrorSettings
            // 
            this.labelErrorSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelErrorSettings.AutoSize = true;
            this.labelErrorSettings.ForeColor = System.Drawing.Color.Red;
            this.labelErrorSettings.Location = new System.Drawing.Point(6, 100);
            this.labelErrorSettings.MaximumSize = new System.Drawing.Size(306, 61);
            this.labelErrorSettings.Name = "labelErrorSettings";
            this.labelErrorSettings.Size = new System.Drawing.Size(38, 13);
            this.labelErrorSettings.TabIndex = 6;
            this.labelErrorSettings.Text = "";
            this.labelErrorSettings.Visible = false;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveSettings.Location = new System.Drawing.Point(238, 74);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 5;
            this.btnSaveSettings.Text = "save";
            this.btnSaveSettings.UseSelectable = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // mlLabel1
            // 
            this.mlLabel1.AutoSize = true;
            this.mlLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel1.Location = new System.Drawing.Point(10, 16);
            this.mlLabel1.Name = "mlLabel1";
            this.mlLabel1.Size = new System.Drawing.Size(91, 19);
            this.mlLabel1.TabIndex = 0;
            this.mlLabel1.Text = "vat_multiplier";
            // 
            // VatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mlGroupBox3);
            this.Name = "VatControl";
            this.Size = new System.Drawing.Size(616, 533);
            this.mlGroupBox3.ResumeLayout(false);
            this.mlGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVatMultiplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Forms.Base.MLGroupBox mlGroupBox3;
        private Common.Forms.Base.MLComboBox cbItemTypes;
        private System.Windows.Forms.NumericUpDown tbVatMultiplier;
        private Common.Forms.Base.MLErrorLabel labelErrorSettings;
        private Common.Forms.Base.MLButton btnSaveSettings;
        private Common.Forms.Base.MLLabel mlLabel1;
    }
}
