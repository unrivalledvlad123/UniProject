using Common.Forms.Base;

namespace DB3Client.Forms.WarehouseForms
{
    partial class formPricelist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPriceListWharehouseGrid = new MetroFramework.Controls.MetroGrid();
            this.tbPriceListForm = new MetroFramework.Controls.MetroTabControl();
            this.tbPriceListWharehouse = new Common.Forms.Base.MLTabPage();
            this.tbUnderDevelopmentWharehouse = new Common.Forms.Base.MLTabPage();
            this.mlErrorPriceListForm = new Common.Forms.Base.MLErrorLabel();
            this.btnSaveNewPriceWharehouse = new Common.Forms.Base.MLButton();
            this.tbNewPriceWharehouse = new Common.Forms.Base.MLTextBox();
            this.lbOldPriceWharehouse = new Common.Forms.Base.MLLabel();
            this.lbItemDescriptionWharehouse = new Common.Forms.Base.MLLabel();
            this.Wharehouse = new Common.Forms.Base.MLLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceListWharehouseGrid)).BeginInit();
            this.tbPriceListForm.SuspendLayout();
            this.tbUnderDevelopmentWharehouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPriceListWharehouseGrid
            // 
            this.dgvPriceListWharehouseGrid.AllowUserToResizeRows = false;
            this.dgvPriceListWharehouseGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPriceListWharehouseGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPriceListWharehouseGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPriceListWharehouseGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPriceListWharehouseGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPriceListWharehouseGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPriceListWharehouseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPriceListWharehouseGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPriceListWharehouseGrid.EnableHeadersVisualStyles = false;
            this.dgvPriceListWharehouseGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPriceListWharehouseGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPriceListWharehouseGrid.Location = new System.Drawing.Point(27, 327);
            this.dgvPriceListWharehouseGrid.Name = "dgvPriceListWharehouseGrid";
            this.dgvPriceListWharehouseGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPriceListWharehouseGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPriceListWharehouseGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPriceListWharehouseGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPriceListWharehouseGrid.Size = new System.Drawing.Size(435, 180);
            this.dgvPriceListWharehouseGrid.TabIndex = 1;
            // 
            // tbPriceListForm
            // 
            this.tbPriceListForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPriceListForm.Controls.Add(this.tbPriceListWharehouse);
            this.tbPriceListForm.Controls.Add(this.tbUnderDevelopmentWharehouse);
            this.tbPriceListForm.Location = new System.Drawing.Point(23, 63);
            this.tbPriceListForm.Name = "tbPriceListForm";
            this.tbPriceListForm.SelectedIndex = 1;
            this.tbPriceListForm.Size = new System.Drawing.Size(443, 258);
            this.tbPriceListForm.TabIndex = 2;
            this.tbPriceListForm.UseSelectable = true;
            // 
            // tbPriceListWharehouse
            // 
            this.tbPriceListWharehouse.HorizontalScrollbarBarColor = true;
            this.tbPriceListWharehouse.HorizontalScrollbarHighlightOnWheel = false;
            this.tbPriceListWharehouse.HorizontalScrollbarSize = 10;
            this.tbPriceListWharehouse.Location = new System.Drawing.Point(4, 38);
            this.tbPriceListWharehouse.Name = "tbPriceListWharehouse";
            this.tbPriceListWharehouse.Size = new System.Drawing.Size(435, 216);
            this.tbPriceListWharehouse.TabIndex = 0;
            this.tbPriceListWharehouse.Text = "tb_price_list_wharehouse";
            this.tbPriceListWharehouse.VerticalScrollbarBarColor = true;
            this.tbPriceListWharehouse.VerticalScrollbarHighlightOnWheel = false;
            this.tbPriceListWharehouse.VerticalScrollbarSize = 10;
            // 
            // tbUnderDevelopmentWharehouse
            // 
            this.tbUnderDevelopmentWharehouse.Controls.Add(this.mlErrorPriceListForm);
            this.tbUnderDevelopmentWharehouse.Controls.Add(this.btnSaveNewPriceWharehouse);
            this.tbUnderDevelopmentWharehouse.Controls.Add(this.tbNewPriceWharehouse);
            this.tbUnderDevelopmentWharehouse.Controls.Add(this.lbOldPriceWharehouse);
            this.tbUnderDevelopmentWharehouse.Controls.Add(this.lbItemDescriptionWharehouse);
            this.tbUnderDevelopmentWharehouse.Controls.Add(this.Wharehouse);
            this.tbUnderDevelopmentWharehouse.HorizontalScrollbarBarColor = true;
            this.tbUnderDevelopmentWharehouse.HorizontalScrollbarHighlightOnWheel = false;
            this.tbUnderDevelopmentWharehouse.HorizontalScrollbarSize = 10;
            this.tbUnderDevelopmentWharehouse.Location = new System.Drawing.Point(4, 38);
            this.tbUnderDevelopmentWharehouse.Name = "tbUnderDevelopmentWharehouse";
            this.tbUnderDevelopmentWharehouse.Size = new System.Drawing.Size(435, 216);
            this.tbUnderDevelopmentWharehouse.TabIndex = 1;
            this.tbUnderDevelopmentWharehouse.Text = "tb_under_development_wharehouse";
            this.tbUnderDevelopmentWharehouse.VerticalScrollbarBarColor = true;
            this.tbUnderDevelopmentWharehouse.VerticalScrollbarHighlightOnWheel = false;
            this.tbUnderDevelopmentWharehouse.VerticalScrollbarSize = 10;
            this.tbUnderDevelopmentWharehouse.Click += new System.EventHandler(this.tbUnderDevelopmentWharehouse_Click);
            // 
            // mlErrorPriceListForm
            // 
            this.mlErrorPriceListForm.AutoSize = true;
            this.mlErrorPriceListForm.ForeColor = System.Drawing.Color.Red;
            this.mlErrorPriceListForm.Location = new System.Drawing.Point(4, 125);
            this.mlErrorPriceListForm.Name = "mlErrorPriceListForm";
            this.mlErrorPriceListForm.Size = new System.Drawing.Size(101, 13);
            this.mlErrorPriceListForm.TabIndex = 7;
            this.mlErrorPriceListForm.Text = "price_list_form_error";
            this.mlErrorPriceListForm.Visible = false;
            // 
            // btnSaveNewPriceWharehouse
            // 
            this.btnSaveNewPriceWharehouse.Location = new System.Drawing.Point(3, 190);
            this.btnSaveNewPriceWharehouse.Name = "btnSaveNewPriceWharehouse";
            this.btnSaveNewPriceWharehouse.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNewPriceWharehouse.TabIndex = 6;
            this.btnSaveNewPriceWharehouse.Text = "btn_save_new_price_wharehouse";
            this.btnSaveNewPriceWharehouse.UseSelectable = true;
            this.btnSaveNewPriceWharehouse.Click += new System.EventHandler(this.btnSaveNewPriceWharehouse_Click);
            // 
            // tbNewPriceWharehouse
            // 
            // 
            // 
            // 
            this.tbNewPriceWharehouse.CustomButton.Image = null;
            this.tbNewPriceWharehouse.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.tbNewPriceWharehouse.CustomButton.Name = "";
            this.tbNewPriceWharehouse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNewPriceWharehouse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNewPriceWharehouse.CustomButton.TabIndex = 1;
            this.tbNewPriceWharehouse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNewPriceWharehouse.CustomButton.UseSelectable = true;
            this.tbNewPriceWharehouse.CustomButton.Visible = false;
            this.tbNewPriceWharehouse.Lines = new string[0];
            this.tbNewPriceWharehouse.Location = new System.Drawing.Point(3, 152);
            this.tbNewPriceWharehouse.MaxLength = 32767;
            this.tbNewPriceWharehouse.Name = "tbNewPriceWharehouse";
            this.tbNewPriceWharehouse.PasswordChar = '\0';
            this.tbNewPriceWharehouse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNewPriceWharehouse.SelectedText = "";
            this.tbNewPriceWharehouse.SelectionLength = 0;
            this.tbNewPriceWharehouse.SelectionStart = 0;
            this.tbNewPriceWharehouse.ShortcutsEnabled = true;
            this.tbNewPriceWharehouse.Size = new System.Drawing.Size(130, 23);
            this.tbNewPriceWharehouse.TabIndex = 5;
            this.tbNewPriceWharehouse.UseSelectable = true;
            this.tbNewPriceWharehouse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNewPriceWharehouse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbOldPriceWharehouse
            // 
            this.lbOldPriceWharehouse.AutoSize = true;
            this.lbOldPriceWharehouse.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbOldPriceWharehouse.Location = new System.Drawing.Point(4, 93);
            this.lbOldPriceWharehouse.Name = "lbOldPriceWharehouse";
            this.lbOldPriceWharehouse.Size = new System.Drawing.Size(143, 19);
            this.lbOldPriceWharehouse.TabIndex = 4;
            this.lbOldPriceWharehouse.Text = "old_price_wharehouse";
            // 
            // lbItemDescriptionWharehouse
            // 
            this.lbItemDescriptionWharehouse.AutoSize = true;
            this.lbItemDescriptionWharehouse.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbItemDescriptionWharehouse.Location = new System.Drawing.Point(3, 52);
            this.lbItemDescriptionWharehouse.Name = "lbItemDescriptionWharehouse";
            this.lbItemDescriptionWharehouse.Size = new System.Drawing.Size(189, 19);
            this.lbItemDescriptionWharehouse.TabIndex = 3;
            this.lbItemDescriptionWharehouse.Text = "item_description_wharehouse";
            // 
            // Wharehouse
            // 
            this.Wharehouse.AutoSize = true;
            this.Wharehouse.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Wharehouse.Location = new System.Drawing.Point(4, 18);
            this.Wharehouse.Name = "Wharehouse";
            this.Wharehouse.Size = new System.Drawing.Size(156, 19);
            this.Wharehouse.TabIndex = 2;
            this.Wharehouse.Text = "item_name_wharehouse";
            // 
            // formPricelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 530);
            this.Controls.Add(this.tbPriceListForm);
            this.Controls.Add(this.dgvPriceListWharehouseGrid);
            this.Name = "formPricelist";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceListWharehouseGrid)).EndInit();
            this.tbPriceListForm.ResumeLayout(false);
            this.tbUnderDevelopmentWharehouse.ResumeLayout(false);
            this.tbUnderDevelopmentWharehouse.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private MetroFramework.Controls.MetroGrid dgvPriceListWharehouseGrid;
        private MetroFramework.Controls.MetroTabControl tbPriceListForm;
        private MLTabPage tbPriceListWharehouse;
        private MLTabPage tbUnderDevelopmentWharehouse;
        private Common.Forms.Base.MLLabel lbOldPriceWharehouse;
        private Common.Forms.Base.MLLabel lbItemDescriptionWharehouse;
        private Common.Forms.Base.MLLabel Wharehouse;
        private Common.Forms.Base.MLButton btnSaveNewPriceWharehouse;
        private Common.Forms.Base.MLTextBox tbNewPriceWharehouse;
        private Common.Forms.Base.MLErrorLabel mlErrorPriceListForm;
    }
}