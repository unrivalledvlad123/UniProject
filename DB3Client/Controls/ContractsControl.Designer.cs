using Common.Forms.Base;

namespace DB3Client.Controls
{
    partial class ContractsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlContracts = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new Common.Forms.Base.MLTabPage();
            this.cbContractType1 = new Common.Forms.Base.MLComboBox();
            this.mlLabel2 = new Common.Forms.Base.MLLabel();
            this.mlLabel1 = new Common.Forms.Base.MLLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbSearchContracts = new Common.Forms.Base.MLTextBox();
            this.btnEditContract = new Common.Forms.Base.MLButton();
            this.btnAddContract = new Common.Forms.Base.MLButton();
            this.dgvContracts = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage2 = new Common.Forms.Base.MLTabPage();
            this.btnViewInvoice = new Common.Forms.Base.MLButton();
            this.metroLabel3 = new Common.Forms.Base.MLLabel();
            this.btnViewTransactionDetails = new Common.Forms.Base.MLButton();
            this.dgvTransactions = new MetroFramework.Controls.MetroGrid();
            this.tbSearchTransactions = new Common.Forms.Base.MLTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlContracts.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlContracts
            // 
            this.tabControlContracts.Controls.Add(this.metroTabPage1);
            this.tabControlContracts.Controls.Add(this.metroTabPage2);
            this.tabControlContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlContracts.Location = new System.Drawing.Point(0, 0);
            this.tabControlContracts.Name = "tabControlContracts";
            this.tabControlContracts.SelectedIndex = 0;
            this.tabControlContracts.Size = new System.Drawing.Size(1064, 460);
            this.tabControlContracts.TabIndex = 0;
            this.tabControlContracts.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.cbContractType1);
            this.metroTabPage1.Controls.Add(this.mlLabel2);
            this.metroTabPage1.Controls.Add(this.mlLabel1);
            this.metroTabPage1.Controls.Add(this.pictureBox2);
            this.metroTabPage1.Controls.Add(this.tbSearchContracts);
            this.metroTabPage1.Controls.Add(this.btnEditContract);
            this.metroTabPage1.Controls.Add(this.btnAddContract);
            this.metroTabPage1.Controls.Add(this.dgvContracts);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1056, 418);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "contracts";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // cbContractType1
            // 
            this.cbContractType1.DisplayMember = "(none)";
            this.cbContractType1.FormattingEnabled = true;
            this.cbContractType1.ItemHeight = 23;
            this.cbContractType1.Location = new System.Drawing.Point(408, 107);
            this.cbContractType1.MaxDropDownItems = 5;
            this.cbContractType1.Name = "cbContractType1";
            this.cbContractType1.Size = new System.Drawing.Size(170, 29);
            this.cbContractType1.TabIndex = 11;
            this.cbContractType1.UseSelectable = true;
            this.cbContractType1.DropDown += new System.EventHandler(this.cbContractType1_DropDown);
            // 
            // mlLabel2
            // 
            this.mlLabel2.AutoSize = true;
            this.mlLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel2.Location = new System.Drawing.Point(408, 82);
            this.mlLabel2.Name = "mlLabel2";
            this.mlLabel2.Size = new System.Drawing.Size(108, 19);
            this.mlLabel2.TabIndex = 10;
            this.mlLabel2.Text = "contract_groups";
            // 
            // mlLabel1
            // 
            this.mlLabel1.AutoSize = true;
            this.mlLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel1.Location = new System.Drawing.Point(4, 82);
            this.mlLabel1.Name = "mlLabel1";
            this.mlLabel1.Size = new System.Drawing.Size(104, 19);
            this.mlLabel1.TabIndex = 9;
            this.mlLabel1.Text = "search_contract";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::DB3Client.Resource.agree;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(750, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(303, 182);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // tbSearchContracts
            // 
            // 
            // 
            // 
            this.tbSearchContracts.CustomButton.Image = null;
            this.tbSearchContracts.CustomButton.Location = new System.Drawing.Point(372, 2);
            this.tbSearchContracts.CustomButton.Name = "";
            this.tbSearchContracts.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbSearchContracts.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearchContracts.CustomButton.TabIndex = 1;
            this.tbSearchContracts.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearchContracts.CustomButton.UseSelectable = true;
            this.tbSearchContracts.CustomButton.Visible = false;
            this.tbSearchContracts.Lines = new string[0];
            this.tbSearchContracts.Location = new System.Drawing.Point(3, 107);
            this.tbSearchContracts.MaxLength = 32767;
            this.tbSearchContracts.Name = "tbSearchContracts";
            this.tbSearchContracts.PasswordChar = '\0';
            this.tbSearchContracts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearchContracts.SelectedText = "";
            this.tbSearchContracts.SelectionLength = 0;
            this.tbSearchContracts.SelectionStart = 0;
            this.tbSearchContracts.ShortcutsEnabled = true;
            this.tbSearchContracts.Size = new System.Drawing.Size(398, 28);
            this.tbSearchContracts.TabIndex = 6;
            this.tbSearchContracts.UseSelectable = true;
            this.tbSearchContracts.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearchContracts.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbSearchContracts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchContracts_KeyDown);
            // 
            // btnEditContract
            // 
            this.btnEditContract.Location = new System.Drawing.Point(199, 155);
            this.btnEditContract.Name = "btnEditContract";
            this.btnEditContract.Size = new System.Drawing.Size(202, 23);
            this.btnEditContract.TabIndex = 4;
            this.btnEditContract.Text = "edit_contract";
            this.btnEditContract.UseSelectable = true;
            this.btnEditContract.Click += new System.EventHandler(this.btnEditContract_Click);
            // 
            // btnAddContract
            // 
            this.btnAddContract.Location = new System.Drawing.Point(3, 155);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(190, 23);
            this.btnAddContract.TabIndex = 3;
            this.btnAddContract.Text = "add_contract";
            this.btnAddContract.UseSelectable = true;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // dgvContracts
            // 
            this.dgvContracts.AllowUserToResizeRows = false;
            this.dgvContracts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContracts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvContracts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContracts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvContracts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContracts.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvContracts.EnableHeadersVisualStyles = false;
            this.dgvContracts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvContracts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvContracts.Location = new System.Drawing.Point(3, 191);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracts.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvContracts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContracts.Size = new System.Drawing.Size(1050, 224);
            this.dgvContracts.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroTabPage2.Controls.Add(this.btnViewInvoice);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.btnViewTransactionDetails);
            this.metroTabPage2.Controls.Add(this.dgvTransactions);
            this.metroTabPage2.Controls.Add(this.tbSearchTransactions);
            this.metroTabPage2.Controls.Add(this.pictureBox1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1056, 418);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "tansactions";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnViewInvoice
            // 
            this.btnViewInvoice.Location = new System.Drawing.Point(205, 69);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Size = new System.Drawing.Size(195, 23);
            this.btnViewInvoice.TabIndex = 18;
            this.btnViewInvoice.Text = "view_invoice";
            this.btnViewInvoice.UseSelectable = true;
            this.btnViewInvoice.Click += new System.EventHandler(this.btnViewInvoice_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(3, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(165, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "search_by_contract_name";
            // 
            // btnViewTransactionDetails
            // 
            this.btnViewTransactionDetails.Location = new System.Drawing.Point(3, 69);
            this.btnViewTransactionDetails.Name = "btnViewTransactionDetails";
            this.btnViewTransactionDetails.Size = new System.Drawing.Size(196, 23);
            this.btnViewTransactionDetails.TabIndex = 15;
            this.btnViewTransactionDetails.Text = "view_transaction_details";
            this.btnViewTransactionDetails.UseSelectable = true;
            this.btnViewTransactionDetails.Click += new System.EventHandler(this.btnViewTransactionDetails_Click);
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToResizeRows = false;
            this.dgvTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvTransactions.EnableHeadersVisualStyles = false;
            this.dgvTransactions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTransactions.Location = new System.Drawing.Point(3, 124);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(1050, 291);
            this.dgvTransactions.TabIndex = 12;
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
            this.tbSearchTransactions.Location = new System.Drawing.Point(3, 38);
            this.tbSearchTransactions.MaxLength = 32767;
            this.tbSearchTransactions.Name = "tbSearchTransactions";
            this.tbSearchTransactions.PasswordChar = '\0';
            this.tbSearchTransactions.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearchTransactions.SelectedText = "";
            this.tbSearchTransactions.SelectionLength = 0;
            this.tbSearchTransactions.SelectionStart = 0;
            this.tbSearchTransactions.ShortcutsEnabled = true;
            this.tbSearchTransactions.Size = new System.Drawing.Size(397, 25);
            this.tbSearchTransactions.TabIndex = 10;
            this.tbSearchTransactions.UseSelectable = true;
            this.tbSearchTransactions.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearchTransactions.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbSearchTransactions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchTransactions_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DB3Client.Resource.Search2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(860, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 115);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ContractsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlContracts);
            this.Name = "ContractsControl";
            this.Size = new System.Drawing.Size(1064, 460);
            this.tabControlContracts.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControlContracts;
        private MLTabPage metroTabPage1;
        private MLTabPage metroTabPage2;
        private MLTextBox tbSearchContracts;
        private MLButton btnEditContract;
        private MLButton btnAddContract;
        private MetroFramework.Controls.MetroGrid dgvContracts;
        private MLLabel metroLabel3;
        private MLButton btnViewTransactionDetails;
        private MetroFramework.Controls.MetroGrid dgvTransactions;
        private MLTextBox tbSearchTransactions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MLButton btnViewInvoice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MLLabel mlLabel2;
        private MLLabel mlLabel1;
        private string cbContractType;
        private MLComboBox cbContractType1;
    }
}
