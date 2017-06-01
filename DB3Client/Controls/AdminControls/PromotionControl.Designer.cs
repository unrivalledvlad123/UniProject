namespace DB3Client.Controls.AdminControls
{
    partial class PromotionControl
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
            this.btnSave = new Common.Forms.Base.MLButtonOk();
            this.mlLabel4 = new Common.Forms.Base.MLLabel();
            this.tbDiscount = new System.Windows.Forms.NumericUpDown();
            this.mlLabel3 = new Common.Forms.Base.MLLabel();
            this.tbDiscountEnd = new Common.Forms.Base.MLTextBox();
            this.mlLabel2 = new Common.Forms.Base.MLLabel();
            this.tbDiscountStart = new Common.Forms.Base.MLTextBox();
            this.mlLabel1 = new Common.Forms.Base.MLLabel();
            this.tbDiscountTitle = new Common.Forms.Base.MLTextBox();
            this.cbSelectedRow = new Common.Forms.Base.MLComboBox();
            this.cbEnablePromotions = new Common.Forms.Base.MLCheckBox();
            this.mlGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // mlGroupBox1
            // 
            this.mlGroupBox1.BackColor = System.Drawing.Color.White;
            this.mlGroupBox1.Controls.Add(this.labelError);
            this.mlGroupBox1.Controls.Add(this.btnSave);
            this.mlGroupBox1.Controls.Add(this.mlLabel4);
            this.mlGroupBox1.Controls.Add(this.tbDiscount);
            this.mlGroupBox1.Controls.Add(this.mlLabel3);
            this.mlGroupBox1.Controls.Add(this.tbDiscountEnd);
            this.mlGroupBox1.Controls.Add(this.mlLabel2);
            this.mlGroupBox1.Controls.Add(this.tbDiscountStart);
            this.mlGroupBox1.Controls.Add(this.mlLabel1);
            this.mlGroupBox1.Controls.Add(this.tbDiscountTitle);
            this.mlGroupBox1.Controls.Add(this.cbSelectedRow);
            this.mlGroupBox1.Controls.Add(this.cbEnablePromotions);
            this.mlGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.mlGroupBox1.Name = "mlGroupBox1";
            this.mlGroupBox1.Size = new System.Drawing.Size(919, 489);
            this.mlGroupBox1.TabIndex = 0;
            this.mlGroupBox1.TabStop = false;
            this.mlGroupBox1.Text = "promotion_settings";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(6, 323);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(201, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mlLabel4
            // 
            this.mlLabel4.AutoSize = true;
            this.mlLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel4.Location = new System.Drawing.Point(7, 274);
            this.mlLabel4.Name = "mlLabel4";
            this.mlLabel4.Size = new System.Drawing.Size(113, 19);
            this.mlLabel4.TabIndex = 9;
            this.mlLabel4.Text = "discount_percent";
            // 
            // tbDiscount
            // 
            this.tbDiscount.DecimalPlaces = 2;
            this.tbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbDiscount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tbDiscount.Location = new System.Drawing.Point(5, 296);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(148, 24);
            this.tbDiscount.TabIndex = 8;
            // 
            // mlLabel3
            // 
            this.mlLabel3.AutoSize = true;
            this.mlLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel3.Location = new System.Drawing.Point(6, 214);
            this.mlLabel3.Name = "mlLabel3";
            this.mlLabel3.Size = new System.Drawing.Size(144, 19);
            this.mlLabel3.TabIndex = 7;
            this.mlLabel3.Text = "discount_end_amount";
            // 
            // tbDiscountEnd
            // 
            // 
            // 
            // 
            this.tbDiscountEnd.CustomButton.Image = null;
            this.tbDiscountEnd.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.tbDiscountEnd.CustomButton.Name = "";
            this.tbDiscountEnd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDiscountEnd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDiscountEnd.CustomButton.TabIndex = 1;
            this.tbDiscountEnd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDiscountEnd.CustomButton.UseSelectable = true;
            this.tbDiscountEnd.CustomButton.Visible = false;
            this.tbDiscountEnd.Lines = new string[0];
            this.tbDiscountEnd.Location = new System.Drawing.Point(6, 236);
            this.tbDiscountEnd.MaxLength = 32767;
            this.tbDiscountEnd.Name = "tbDiscountEnd";
            this.tbDiscountEnd.PasswordChar = '\0';
            this.tbDiscountEnd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDiscountEnd.SelectedText = "";
            this.tbDiscountEnd.SelectionLength = 0;
            this.tbDiscountEnd.SelectionStart = 0;
            this.tbDiscountEnd.ShortcutsEnabled = true;
            this.tbDiscountEnd.Size = new System.Drawing.Size(148, 23);
            this.tbDiscountEnd.TabIndex = 6;
            this.tbDiscountEnd.UseSelectable = true;
            this.tbDiscountEnd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDiscountEnd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbDiscountEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDiscountEnd_KeyPress);
            // 
            // mlLabel2
            // 
            this.mlLabel2.AutoSize = true;
            this.mlLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel2.Location = new System.Drawing.Point(7, 154);
            this.mlLabel2.Name = "mlLabel2";
            this.mlLabel2.Size = new System.Drawing.Size(149, 19);
            this.mlLabel2.TabIndex = 5;
            this.mlLabel2.Text = "discount_start_amount";
            // 
            // tbDiscountStart
            // 
            // 
            // 
            // 
            this.tbDiscountStart.CustomButton.Image = null;
            this.tbDiscountStart.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.tbDiscountStart.CustomButton.Name = "";
            this.tbDiscountStart.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDiscountStart.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDiscountStart.CustomButton.TabIndex = 1;
            this.tbDiscountStart.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDiscountStart.CustomButton.UseSelectable = true;
            this.tbDiscountStart.CustomButton.Visible = false;
            this.tbDiscountStart.Lines = new string[0];
            this.tbDiscountStart.Location = new System.Drawing.Point(6, 179);
            this.tbDiscountStart.MaxLength = 32767;
            this.tbDiscountStart.Name = "tbDiscountStart";
            this.tbDiscountStart.PasswordChar = '\0';
            this.tbDiscountStart.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDiscountStart.SelectedText = "";
            this.tbDiscountStart.SelectionLength = 0;
            this.tbDiscountStart.SelectionStart = 0;
            this.tbDiscountStart.ShortcutsEnabled = true;
            this.tbDiscountStart.Size = new System.Drawing.Size(148, 23);
            this.tbDiscountStart.TabIndex = 4;
            this.tbDiscountStart.UseSelectable = true;
            this.tbDiscountStart.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDiscountStart.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbDiscountStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDiscountStart_KeyPress);
            // 
            // mlLabel1
            // 
            this.mlLabel1.AutoSize = true;
            this.mlLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel1.Location = new System.Drawing.Point(7, 93);
            this.mlLabel1.Name = "mlLabel1";
            this.mlLabel1.Size = new System.Drawing.Size(90, 19);
            this.mlLabel1.TabIndex = 3;
            this.mlLabel1.Text = "discount_title";
            // 
            // tbDiscountTitle
            // 
            // 
            // 
            // 
            this.tbDiscountTitle.CustomButton.Image = null;
            this.tbDiscountTitle.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.tbDiscountTitle.CustomButton.Name = "";
            this.tbDiscountTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDiscountTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDiscountTitle.CustomButton.TabIndex = 1;
            this.tbDiscountTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDiscountTitle.CustomButton.UseSelectable = true;
            this.tbDiscountTitle.CustomButton.Visible = false;
            this.tbDiscountTitle.Lines = new string[0];
            this.tbDiscountTitle.Location = new System.Drawing.Point(6, 118);
            this.tbDiscountTitle.MaxLength = 32767;
            this.tbDiscountTitle.Name = "tbDiscountTitle";
            this.tbDiscountTitle.PasswordChar = '\0';
            this.tbDiscountTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDiscountTitle.SelectedText = "";
            this.tbDiscountTitle.SelectionLength = 0;
            this.tbDiscountTitle.SelectionStart = 0;
            this.tbDiscountTitle.ShortcutsEnabled = true;
            this.tbDiscountTitle.Size = new System.Drawing.Size(148, 23);
            this.tbDiscountTitle.TabIndex = 2;
            this.tbDiscountTitle.UseSelectable = true;
            this.tbDiscountTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDiscountTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbSelectedRow
            // 
            this.cbSelectedRow.FormattingEnabled = true;
            this.cbSelectedRow.ItemHeight = 23;
            this.cbSelectedRow.Location = new System.Drawing.Point(6, 40);
            this.cbSelectedRow.Name = "cbSelectedRow";
            this.cbSelectedRow.Size = new System.Drawing.Size(298, 29);
            this.cbSelectedRow.TabIndex = 1;
            this.cbSelectedRow.UseSelectable = true;
            this.cbSelectedRow.SelectionChangeCommitted += new System.EventHandler(this.cbSelectedRow_SelectionChangeCommitted);
            // 
            // cbEnablePromotions
            // 
            this.cbEnablePromotions.AutoSize = true;
            this.cbEnablePromotions.Location = new System.Drawing.Point(6, 19);
            this.cbEnablePromotions.Name = "cbEnablePromotions";
            this.cbEnablePromotions.Size = new System.Drawing.Size(125, 15);
            this.cbEnablePromotions.TabIndex = 0;
            this.cbEnablePromotions.Text = "enable_promotions";
            this.cbEnablePromotions.UseSelectable = true;
            this.cbEnablePromotions.CheckedChanged += new System.EventHandler(this.cbEnablePromotions_CheckedChanged);
            // 
            // PromotionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mlGroupBox1);
            this.Name = "PromotionControl";
            this.Size = new System.Drawing.Size(919, 489);
            this.mlGroupBox1.ResumeLayout(false);
            this.mlGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Forms.Base.MLGroupBox mlGroupBox1;
        private Common.Forms.Base.MLCheckBox cbEnablePromotions;
        private Common.Forms.Base.MLButtonOk btnSave;
        private Common.Forms.Base.MLLabel mlLabel4;
        private System.Windows.Forms.NumericUpDown tbDiscount;
        private Common.Forms.Base.MLLabel mlLabel3;
        private Common.Forms.Base.MLTextBox tbDiscountEnd;
        private Common.Forms.Base.MLLabel mlLabel2;
        private Common.Forms.Base.MLTextBox tbDiscountStart;
        private Common.Forms.Base.MLLabel mlLabel1;
        private Common.Forms.Base.MLTextBox tbDiscountTitle;
        private Common.Forms.Base.MLComboBox cbSelectedRow;
        private Common.Forms.Base.MLErrorLabel labelError;
    }
}
