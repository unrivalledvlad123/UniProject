namespace DB3Client.Forms.TrasactionForms
{
    partial class TransactionDetailsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new Common.Forms.Base.MLButton();
            this.mlCustomer = new Common.Forms.Base.MLLabel();
            this.dgvDetailsTransaction = new MetroFramework.Controls.MetroGrid();
            this.mlLabelContractName = new Common.Forms.Base.MLLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mlListWithItems = new Common.Forms.Base.MLLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(494, 414);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 25);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "btn_Close";
            this.btnClose.UseSelectable = true;
            // 
            // mlCustomer
            // 
            this.mlCustomer.AutoSize = true;
            this.mlCustomer.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlCustomer.Location = new System.Drawing.Point(9, 60);
            this.mlCustomer.Name = "mlCustomer";
            this.mlCustomer.Size = new System.Drawing.Size(66, 19);
            this.mlCustomer.TabIndex = 22;
            this.mlCustomer.Text = "customer";
            // 
            // dgvDetailsTransaction
            // 
            this.dgvDetailsTransaction.AllowUserToResizeRows = false;
            this.dgvDetailsTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailsTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDetailsTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetailsTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetailsTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetailsTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetailsTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetailsTransaction.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetailsTransaction.EnableHeadersVisualStyles = false;
            this.dgvDetailsTransaction.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDetailsTransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDetailsTransaction.Location = new System.Drawing.Point(9, 178);
            this.dgvDetailsTransaction.Name = "dgvDetailsTransaction";
            this.dgvDetailsTransaction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetailsTransaction.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetailsTransaction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetailsTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailsTransaction.Size = new System.Drawing.Size(613, 230);
            this.dgvDetailsTransaction.TabIndex = 21;
            // 
            // mlLabelContractName
            // 
            this.mlLabelContractName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mlLabelContractName.AutoSize = true;
            this.mlLabelContractName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabelContractName.Location = new System.Drawing.Point(104, 60);
            this.mlLabelContractName.Name = "mlLabelContractName";
            this.mlLabelContractName.Size = new System.Drawing.Size(64, 19);
            this.mlLabelContractName.TabIndex = 20;
            this.mlLabelContractName.Text = "mlLabel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::DB3Client.Resource.full_shoppingcart;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(437, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 136);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // mlListWithItems
            // 
            this.mlListWithItems.AutoSize = true;
            this.mlListWithItems.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlListWithItems.Location = new System.Drawing.Point(9, 152);
            this.mlListWithItems.Name = "mlListWithItems";
            this.mlListWithItems.Size = new System.Drawing.Size(97, 19);
            this.mlListWithItems.TabIndex = 24;
            this.mlListWithItems.Text = "list_with_items";
            // 
            // TransactionDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 462);
            this.Controls.Add(this.mlListWithItems);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mlCustomer);
            this.Controls.Add(this.dgvDetailsTransaction);
            this.Controls.Add(this.mlLabelContractName);
            this.Controls.Add(this.btnClose);
            this.Name = "TransactionDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Common.Forms.Base.MLButton btnClose;
        private Common.Forms.Base.MLLabel mlCustomer;
        private MetroFramework.Controls.MetroGrid dgvDetailsTransaction;
        private Common.Forms.Base.MLLabel mlLabelContractName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Common.Forms.Base.MLLabel mlListWithItems;
    }
}