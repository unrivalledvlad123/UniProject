namespace DB3Client.Controls.AdminControls
{
    partial class GeneralSettingsControl
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
            this.cbMapping = new Common.Forms.Base.MLCheckBox();
            this.mlGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlGroupBox1
            // 
            this.mlGroupBox1.BackColor = System.Drawing.Color.White;
            this.mlGroupBox1.Controls.Add(this.cbMapping);
            this.mlGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.mlGroupBox1.Name = "mlGroupBox1";
            this.mlGroupBox1.Size = new System.Drawing.Size(772, 455);
            this.mlGroupBox1.TabIndex = 0;
            this.mlGroupBox1.TabStop = false;
            this.mlGroupBox1.Text = "general_settings";
            // 
            // cbMapping
            // 
            this.cbMapping.AutoSize = true;
            this.cbMapping.Location = new System.Drawing.Point(6, 19);
            this.cbMapping.Name = "cbMapping";
            this.cbMapping.Size = new System.Drawing.Size(183, 15);
            this.cbMapping.TabIndex = 0;
            this.cbMapping.Text = "enable_partner_item_mapping";
            this.cbMapping.UseSelectable = true;
            this.cbMapping.CheckedChanged += new System.EventHandler(this.cbMapping_CheckedChanged);
            // 
            // GeneralSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mlGroupBox1);
            this.Name = "GeneralSettingsControl";
            this.Size = new System.Drawing.Size(772, 455);
            this.mlGroupBox1.ResumeLayout(false);
            this.mlGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Forms.Base.MLGroupBox mlGroupBox1;
        private Common.Forms.Base.MLCheckBox cbMapping;
    }
}
