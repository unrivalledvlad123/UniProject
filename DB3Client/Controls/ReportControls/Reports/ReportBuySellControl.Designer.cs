﻿namespace DB3Client.Controls.ReportControls.Reports
{
    partial class ReportBuySellControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mlGroupBox2 = new Common.Forms.Base.MLGroupBox();
            this.btnExport = new Common.Forms.Base.MLButton();
            this.labelError = new Common.Forms.Base.MLErrorLabel();
            this.rbItemType = new Common.Forms.Base.MLRadioButton();
            this.cbItemType = new Common.Forms.Base.MLComboBox();
            this.rbSpecificItem = new Common.Forms.Base.MLRadioButton();
            this.btnGenerate = new Common.Forms.Base.MLButton();
            this.tbSpecificItem = new Common.Forms.Base.MLTextBox();
            this.dgvResults = new MetroFramework.Controls.MetroGrid();
            this.mlLabel3 = new Common.Forms.Base.MLLabel();
            this.mlLabel2 = new Common.Forms.Base.MLLabel();
            this.dtTo = new MetroFramework.Controls.MetroDateTime();
            this.dtFrom = new MetroFramework.Controls.MetroDateTime();
            this.mlLabel1 = new Common.Forms.Base.MLLabel();
            this.cbReportType = new Common.Forms.Base.MLComboBox();
            this.mlGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // mlGroupBox2
            // 
            this.mlGroupBox2.BackColor = System.Drawing.Color.White;
            this.mlGroupBox2.Controls.Add(this.btnExport);
            this.mlGroupBox2.Controls.Add(this.labelError);
            this.mlGroupBox2.Controls.Add(this.rbItemType);
            this.mlGroupBox2.Controls.Add(this.cbItemType);
            this.mlGroupBox2.Controls.Add(this.rbSpecificItem);
            this.mlGroupBox2.Controls.Add(this.btnGenerate);
            this.mlGroupBox2.Controls.Add(this.tbSpecificItem);
            this.mlGroupBox2.Controls.Add(this.dgvResults);
            this.mlGroupBox2.Controls.Add(this.mlLabel3);
            this.mlGroupBox2.Controls.Add(this.mlLabel2);
            this.mlGroupBox2.Controls.Add(this.dtTo);
            this.mlGroupBox2.Controls.Add(this.dtFrom);
            this.mlGroupBox2.Controls.Add(this.mlLabel1);
            this.mlGroupBox2.Controls.Add(this.cbReportType);
            this.mlGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.mlGroupBox2.Name = "mlGroupBox2";
            this.mlGroupBox2.Size = new System.Drawing.Size(1082, 491);
            this.mlGroupBox2.TabIndex = 6;
            this.mlGroupBox2.TabStop = false;
            this.mlGroupBox2.Text = "sales_report";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(359, 239);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(101, 23);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "export_to_csv";
            this.btnExport.UseSelectable = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(10, 205);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(64, 13);
            this.labelError.TabIndex = 11;
            this.labelError.Text = "invalid_data";
            this.labelError.Visible = false;
            // 
            // rbItemType
            // 
            this.rbItemType.AutoSize = true;
            this.rbItemType.Location = new System.Drawing.Point(318, 88);
            this.rbItemType.Name = "rbItemType";
            this.rbItemType.Size = new System.Drawing.Size(75, 15);
            this.rbItemType.TabIndex = 1;
            this.rbItemType.Text = "item_type";
            this.rbItemType.UseSelectable = true;
            this.rbItemType.CheckedChanged += new System.EventHandler(this.rbItemType_CheckedChanged_1);
            // 
            // cbItemType
            // 
            this.cbItemType.FormattingEnabled = true;
            this.cbItemType.ItemHeight = 23;
            this.cbItemType.Location = new System.Drawing.Point(318, 109);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(250, 29);
            this.cbItemType.TabIndex = 3;
            this.cbItemType.UseSelectable = true;
            // 
            // rbSpecificItem
            // 
            this.rbSpecificItem.AutoSize = true;
            this.rbSpecificItem.Location = new System.Drawing.Point(13, 88);
            this.rbSpecificItem.Name = "rbSpecificItem";
            this.rbSpecificItem.Size = new System.Drawing.Size(92, 15);
            this.rbSpecificItem.TabIndex = 0;
            this.rbSpecificItem.Text = "specific_item";
            this.rbSpecificItem.UseSelectable = true;
            this.rbSpecificItem.CheckedChanged += new System.EventHandler(this.rbSpecificItem_CheckedChanged_1);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(466, 239);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(101, 23);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "generate";
            this.btnGenerate.UseSelectable = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click_1);
            // 
            // tbSpecificItem
            // 
            // 
            // 
            // 
            this.tbSpecificItem.CustomButton.Image = null;
            this.tbSpecificItem.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.tbSpecificItem.CustomButton.Name = "";
            this.tbSpecificItem.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbSpecificItem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSpecificItem.CustomButton.TabIndex = 1;
            this.tbSpecificItem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSpecificItem.CustomButton.UseSelectable = true;
            this.tbSpecificItem.CustomButton.Visible = false;
            this.tbSpecificItem.Lines = new string[0];
            this.tbSpecificItem.Location = new System.Drawing.Point(13, 109);
            this.tbSpecificItem.MaxLength = 32767;
            this.tbSpecificItem.Name = "tbSpecificItem";
            this.tbSpecificItem.PasswordChar = '\0';
            this.tbSpecificItem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSpecificItem.SelectedText = "";
            this.tbSpecificItem.SelectionLength = 0;
            this.tbSpecificItem.SelectionStart = 0;
            this.tbSpecificItem.ShortcutsEnabled = true;
            this.tbSpecificItem.Size = new System.Drawing.Size(250, 29);
            this.tbSpecificItem.TabIndex = 2;
            this.tbSpecificItem.UseSelectable = true;
            this.tbSpecificItem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSpecificItem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToResizeRows = false;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvResults.Location = new System.Drawing.Point(6, 268);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(1070, 217);
            this.dgvResults.TabIndex = 9;
            // 
            // mlLabel3
            // 
            this.mlLabel3.AutoSize = true;
            this.mlLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel3.Location = new System.Drawing.Point(318, 151);
            this.mlLabel3.Name = "mlLabel3";
            this.mlLabel3.Size = new System.Drawing.Size(55, 19);
            this.mlLabel3.TabIndex = 8;
            this.mlLabel3.Text = "to_date";
            // 
            // mlLabel2
            // 
            this.mlLabel2.AutoSize = true;
            this.mlLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel2.Location = new System.Drawing.Point(13, 151);
            this.mlLabel2.Name = "mlLabel2";
            this.mlLabel2.Size = new System.Drawing.Size(71, 19);
            this.mlLabel2.TabIndex = 7;
            this.mlLabel2.Text = "from_date";
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(318, 173);
            this.dtTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(249, 29);
            this.dtTo.TabIndex = 6;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(12, 173);
            this.dtFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(250, 29);
            this.dtFrom.TabIndex = 5;
            // 
            // mlLabel1
            // 
            this.mlLabel1.AutoSize = true;
            this.mlLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel1.Location = new System.Drawing.Point(12, 16);
            this.mlLabel1.Name = "mlLabel1";
            this.mlLabel1.Size = new System.Drawing.Size(70, 19);
            this.mlLabel1.TabIndex = 3;
            this.mlLabel1.Text = "report_for";
            // 
            // cbReportType
            // 
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.ItemHeight = 23;
            this.cbReportType.Location = new System.Drawing.Point(13, 42);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(249, 29);
            this.cbReportType.TabIndex = 2;
            this.cbReportType.UseSelectable = true;
            // 
            // ReportBuySellControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mlGroupBox2);
            this.Name = "ReportBuySellControl";
            this.Size = new System.Drawing.Size(1082, 491);
            this.mlGroupBox2.ResumeLayout(false);
            this.mlGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Forms.Base.MLGroupBox mlGroupBox2;
        private Common.Forms.Base.MLButton btnExport;
        private Common.Forms.Base.MLErrorLabel labelError;
        private Common.Forms.Base.MLRadioButton rbItemType;
        private Common.Forms.Base.MLComboBox cbItemType;
        private Common.Forms.Base.MLRadioButton rbSpecificItem;
        private Common.Forms.Base.MLButton btnGenerate;
        private Common.Forms.Base.MLTextBox tbSpecificItem;
        private MetroFramework.Controls.MetroGrid dgvResults;
        private Common.Forms.Base.MLLabel mlLabel3;
        private Common.Forms.Base.MLLabel mlLabel2;
        private MetroFramework.Controls.MetroDateTime dtTo;
        private MetroFramework.Controls.MetroDateTime dtFrom;
        private Common.Forms.Base.MLLabel mlLabel1;
        private Common.Forms.Base.MLComboBox cbReportType;
    }
}
