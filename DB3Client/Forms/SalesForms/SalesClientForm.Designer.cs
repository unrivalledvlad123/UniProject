namespace DB3Client.Forms.SalesForms
{
    partial class SalesClientForm
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
            this.mlLabel6 = new Common.Forms.Base.MLLabel();
            this.mlLabel5 = new Common.Forms.Base.MLLabel();
            this.mlLabel4 = new Common.Forms.Base.MLLabel();
            this.mlGroupBox4 = new Common.Forms.Base.MLGroupBox();
            this.labelChangeClient = new Common.Forms.Base.MLLabel();
            this.labelCashClient = new Common.Forms.Base.MLLabel();
            this.labelTotalAmountClient = new Common.Forms.Base.MLLabel();
            this.dgvSoldGoodsClient = new MetroFramework.Controls.MetroGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mlGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldGoodsClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mlLabel6
            // 
            this.mlLabel6.AutoSize = true;
            this.mlLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel6.Location = new System.Drawing.Point(7, 89);
            this.mlLabel6.Name = "mlLabel6";
            this.mlLabel6.Size = new System.Drawing.Size(53, 19);
            this.mlLabel6.TabIndex = 2;
            this.mlLabel6.Text = "change";
            // 
            // mlLabel5
            // 
            this.mlLabel5.AutoSize = true;
            this.mlLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel5.Location = new System.Drawing.Point(7, 51);
            this.mlLabel5.Name = "mlLabel5";
            this.mlLabel5.Size = new System.Drawing.Size(36, 19);
            this.mlLabel5.TabIndex = 1;
            this.mlLabel5.Text = "cash";
            // 
            // mlLabel4
            // 
            this.mlLabel4.AutoSize = true;
            this.mlLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel4.Location = new System.Drawing.Point(7, 11);
            this.mlLabel4.Name = "mlLabel4";
            this.mlLabel4.Size = new System.Drawing.Size(91, 19);
            this.mlLabel4.TabIndex = 0;
            this.mlLabel4.Text = "total_amount";
            // 
            // mlGroupBox4
            // 
            this.mlGroupBox4.BackColor = System.Drawing.Color.White;
            this.mlGroupBox4.Controls.Add(this.labelChangeClient);
            this.mlGroupBox4.Controls.Add(this.labelCashClient);
            this.mlGroupBox4.Controls.Add(this.labelTotalAmountClient);
            this.mlGroupBox4.Controls.Add(this.mlLabel6);
            this.mlGroupBox4.Controls.Add(this.mlLabel5);
            this.mlGroupBox4.Controls.Add(this.mlLabel4);
            this.mlGroupBox4.Location = new System.Drawing.Point(7, 11);
            this.mlGroupBox4.Name = "mlGroupBox4";
            this.mlGroupBox4.Size = new System.Drawing.Size(220, 172);
            this.mlGroupBox4.TabIndex = 2;
            this.mlGroupBox4.TabStop = false;
            // 
            // labelChangeClient
            // 
            this.labelChangeClient.AutoSize = true;
            this.labelChangeClient.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelChangeClient.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelChangeClient.Location = new System.Drawing.Point(136, 89);
            this.labelChangeClient.Name = "labelChangeClient";
            this.labelChangeClient.Size = new System.Drawing.Size(22, 25);
            this.labelChangeClient.TabIndex = 5;
            this.labelChangeClient.Text = "0";
            // 
            // labelCashClient
            // 
            this.labelCashClient.AutoSize = true;
            this.labelCashClient.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelCashClient.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelCashClient.Location = new System.Drawing.Point(136, 51);
            this.labelCashClient.Name = "labelCashClient";
            this.labelCashClient.Size = new System.Drawing.Size(22, 25);
            this.labelCashClient.TabIndex = 4;
            this.labelCashClient.Text = "0";
            // 
            // labelTotalAmountClient
            // 
            this.labelTotalAmountClient.AutoSize = true;
            this.labelTotalAmountClient.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelTotalAmountClient.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelTotalAmountClient.Location = new System.Drawing.Point(136, 10);
            this.labelTotalAmountClient.Name = "labelTotalAmountClient";
            this.labelTotalAmountClient.Size = new System.Drawing.Size(22, 25);
            this.labelTotalAmountClient.TabIndex = 3;
            this.labelTotalAmountClient.Text = "0";
            // 
            // dgvSoldGoodsClient
            // 
            this.dgvSoldGoodsClient.AllowUserToAddRows = false;
            this.dgvSoldGoodsClient.AllowUserToResizeRows = false;
            this.dgvSoldGoodsClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSoldGoodsClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSoldGoodsClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSoldGoodsClient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSoldGoodsClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoldGoodsClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSoldGoodsClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoldGoodsClient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSoldGoodsClient.EnableHeadersVisualStyles = false;
            this.dgvSoldGoodsClient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSoldGoodsClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSoldGoodsClient.Location = new System.Drawing.Point(7, 189);
            this.dgvSoldGoodsClient.Name = "dgvSoldGoodsClient";
            this.dgvSoldGoodsClient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoldGoodsClient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSoldGoodsClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSoldGoodsClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSoldGoodsClient.Size = new System.Drawing.Size(582, 309);
            this.dgvSoldGoodsClient.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::DB3Client.Resource.emptyBasket1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(233, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 172);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SalesClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvSoldGoodsClient);
            this.Controls.Add(this.mlGroupBox4);
            this.Name = "SalesClientForm";
            this.Load += new System.EventHandler(this.SalesClientForm_Load);
            this.mlGroupBox4.ResumeLayout(false);
            this.mlGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldGoodsClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Common.Forms.Base.MLLabel mlLabel6;
        public Common.Forms.Base.MLLabel mlLabel5;
        public Common.Forms.Base.MLLabel mlLabel4;
        public Common.Forms.Base.MLGroupBox mlGroupBox4;
        public Common.Forms.Base.MLLabel labelChangeClient;
        public Common.Forms.Base.MLLabel labelCashClient;
        public Common.Forms.Base.MLLabel labelTotalAmountClient;
        public MetroFramework.Controls.MetroGrid dgvSoldGoodsClient;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}