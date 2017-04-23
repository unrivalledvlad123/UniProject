﻿using Common.Forms.Base;

namespace DB3Client.Forms.TrasactionForms
{
    partial class ViewTransactionForm
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
            this.tbSearchTransactions = new MLTextBox();
            this.btnSearchTransactions = new MLButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MLLabel();
            this.lbCountTransactions = new MLLabel();
            this.btnViewTransactionDetails = new MLButton();
            this.metroLabel3 = new MLLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearchTransactions
            // 
            // 
            // 
            // 
            this.tbSearchTransactions.CustomButton.Image = null;
            this.tbSearchTransactions.CustomButton.Location = new System.Drawing.Point(373, 1);
            this.tbSearchTransactions.CustomButton.Name = "";
            this.tbSearchTransactions.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbSearchTransactions.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearchTransactions.CustomButton.TabIndex = 1;
            this.tbSearchTransactions.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearchTransactions.CustomButton.UseSelectable = true;
            this.tbSearchTransactions.CustomButton.Visible = false;
            this.tbSearchTransactions.Lines = new string[0];
            this.tbSearchTransactions.Location = new System.Drawing.Point(10, 71);
            this.tbSearchTransactions.MaxLength = 32767;
            this.tbSearchTransactions.Name = "tbSearchTransactions";
            this.tbSearchTransactions.PasswordChar = '\0';
            this.tbSearchTransactions.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearchTransactions.SelectedText = "";
            this.tbSearchTransactions.SelectionLength = 0;
            this.tbSearchTransactions.SelectionStart = 0;
            this.tbSearchTransactions.ShortcutsEnabled = true;
            this.tbSearchTransactions.Size = new System.Drawing.Size(397, 25);
            this.tbSearchTransactions.TabIndex = 3;
            this.tbSearchTransactions.UseSelectable = true;
            this.tbSearchTransactions.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearchTransactions.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearchTransactions
            // 
            this.btnSearchTransactions.Location = new System.Drawing.Point(413, 73);
            this.btnSearchTransactions.Name = "btnSearchTransactions";
            this.btnSearchTransactions.Size = new System.Drawing.Size(131, 23);
            this.btnSearchTransactions.TabIndex = 4;
            this.btnSearchTransactions.Text = "search_transactions";
            this.btnSearchTransactions.UseSelectable = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(10, 182);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(534, 356);
            this.metroGrid1.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(355, 157);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "total_transactions";
            // 
            // lbCountTransactions
            // 
            this.lbCountTransactions.AutoSize = true;
            this.lbCountTransactions.Location = new System.Drawing.Point(470, 157);
            this.lbCountTransactions.Name = "lbCountTransactions";
            this.lbCountTransactions.Size = new System.Drawing.Size(41, 19);
            this.lbCountTransactions.TabIndex = 7;
            this.lbCountTransactions.Text = "count";
            // 
            // btnViewTransactionDetails
            // 
            this.btnViewTransactionDetails.Location = new System.Drawing.Point(10, 141);
            this.btnViewTransactionDetails.Name = "btnViewTransactionDetails";
            this.btnViewTransactionDetails.Size = new System.Drawing.Size(196, 23);
            this.btnViewTransactionDetails.TabIndex = 8;
            this.btnViewTransactionDetails.Text = "view_transaction_details";
            this.btnViewTransactionDetails.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(10, 49);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(129, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "search_by_invoice_id";
            // 
            // ViewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 573);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnViewTransactionDetails);
            this.Controls.Add(this.lbCountTransactions);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btnSearchTransactions);
            this.Controls.Add(this.tbSearchTransactions);
            this.Name = "ViewTransactionForm";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MLTextBox tbSearchTransactions;
        private MLButton btnSearchTransactions;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MLLabel metroLabel1;
        private MLLabel lbCountTransactions;
        private MLButton btnViewTransactionDetails;
        private MLLabel metroLabel3;
    }
}