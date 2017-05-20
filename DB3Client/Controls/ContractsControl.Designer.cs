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
            this.tabControlContracts = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new Common.Forms.Base.MLTabPage();
            this.tbSearchContracts = new Common.Forms.Base.MLTextBox();
            this.btnViewTransactions = new Common.Forms.Base.MLButton();
            this.btnEditContract = new Common.Forms.Base.MLButton();
            this.btnAddContract = new Common.Forms.Base.MLButton();
            this.dgvContracts = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage2 = new Common.Forms.Base.MLTabPage();
            this.metroTabPage3 = new Common.Forms.Base.MLTabPage();
            this.tabControlContracts.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
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
            this.tabControlContracts.SelectedIndex = 2;
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
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1056, 418);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
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
    }
}
