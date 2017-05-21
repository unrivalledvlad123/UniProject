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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlContracts = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new Common.Forms.Base.MLTabPage();
            this.tbSearchContracts = new Common.Forms.Base.MLTextBox();
            this.btnViewTransactions = new Common.Forms.Base.MLButton();
            this.btnEditContract = new Common.Forms.Base.MLButton();
            this.btnAddContract = new Common.Forms.Base.MLButton();
            this.dgvContracts = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage2 = new Common.Forms.Base.MLTabPage();
            this.metroLabel3 = new Common.Forms.Base.MLLabel();
            this.btnViewTransactionDetails = new Common.Forms.Base.MLButton();
            this.dgvTransactions = new MetroFramework.Controls.MetroGrid();
            this.tbSearchTransactions = new Common.Forms.Base.MLTextBox();
            this.metroTabPage3 = new Common.Forms.Base.MLTabPage();
            this.tabControlContracts.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlContracts
            // 
            this.tabControlContracts.Controls.Add(this.metroTabPage1);
            this.tabControlContracts.Controls.Add(this.metroTabPage2);
            this.tabControlContracts.Controls.Add(this.metroTabPage3);
            this.tabControlContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlContracts.Location = new System.Drawing.Point(0, 0);
            this.tabControlContracts.Name = "tabControlContracts";
            this.tabControlContracts.SelectedIndex = 1;
            this.tabControlContracts.Size = new System.Drawing.Size(1064, 460);
            this.tabControlContracts.TabIndex = 0;
            this.tabControlContracts.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.tbSearchContracts);
            this.metroTabPage1.Controls.Add(this.btnViewTransactions);
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
            // btnViewTransactions
            // 
            this.btnViewTransactions.Location = new System.Drawing.Point(273, 155);
            this.btnViewTransactions.Name = "btnViewTransactions";
            this.btnViewTransactions.Size = new System.Drawing.Size(129, 23);
            this.btnViewTransactions.TabIndex = 5;
            this.btnViewTransactions.Text = "view_transactions";
            this.btnViewTransactions.UseSelectable = true;
            // 
            // btnEditContract
            // 
            this.btnEditContract.Location = new System.Drawing.Point(138, 155);
            this.btnEditContract.Name = "btnEditContract";
            this.btnEditContract.Size = new System.Drawing.Size(129, 23);
            this.btnEditContract.TabIndex = 4;
            this.btnEditContract.Text = "edit_contract";
            this.btnEditContract.UseSelectable = true;
            this.btnEditContract.Click += new System.EventHandler(this.btnEditContract_Click);
            // 
            // btnAddContract
            // 
            this.btnAddContract.Location = new System.Drawing.Point(3, 155);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(129, 23);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContracts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContracts.EnableHeadersVisualStyles = false;
            this.dgvContracts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvContracts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvContracts.Location = new System.Drawing.Point(3, 191);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContracts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContracts.Size = new System.Drawing.Size(1050, 224);
            this.dgvContracts.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.btnViewTransactionDetails);
            this.metroTabPage2.Controls.Add(this.dgvTransactions);
            this.metroTabPage2.Controls.Add(this.tbSearchTransactions);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTransactions.EnableHeadersVisualStyles = false;
            this.dgvTransactions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTransactions.Location = new System.Drawing.Point(3, 98);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(1050, 317);
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
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1056, 418);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "metroTabPage3";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControlContracts;
        private MLTabPage metroTabPage1;
        private MLTabPage metroTabPage2;
        private MLTabPage metroTabPage3;
        private MLTextBox tbSearchContracts;
        private MLButton btnViewTransactions;
        private MLButton btnEditContract;
        private MLButton btnAddContract;
        private MetroFramework.Controls.MetroGrid dgvContracts;
        private MLLabel metroLabel3;
        private MLButton btnViewTransactionDetails;
        private MetroFramework.Controls.MetroGrid dgvTransactions;
        private MLTextBox tbSearchTransactions;
    }
}
