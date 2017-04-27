using System;
using System.Windows.Forms;
using Common;
using Common.Forms.Base;

namespace DB3Client.Controls
{
    partial class AdminControl
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
            this.tabControlAdmin = new Common.Forms.Base.MLTabControl();
            this.metroTabPage1 = new Common.Forms.Base.MLTabPage();
            this.dgvUsers = new MetroFramework.Controls.MetroGrid();
            this.btnAddNewUser = new Common.Forms.Base.MLButton();
            this.btnEditUser = new Common.Forms.Base.MLButton();
            this.btnDeleteUser = new Common.Forms.Base.MLButton();
            this.metroTabPage2 = new Common.Forms.Base.MLTabPage();
            this.mlGroupBox2 = new Common.Forms.Base.MLGroupBox();
            this.mlGroupBox1 = new Common.Forms.Base.MLGroupBox();
            this.btnDeleteMol = new Common.Forms.Base.MLButton();
            this.groupBox1 = new Common.Forms.Base.MLGroupBox();
            this.labelBulstat = new Common.Forms.Base.MLLabel();
            this.mlLabel2 = new Common.Forms.Base.MLLabel();
            this.labelVAT = new Common.Forms.Base.MLLabel();
            this.mlLabel4 = new Common.Forms.Base.MLLabel();
            this.labelEmail = new Common.Forms.Base.MLLabel();
            this.metroLabel8 = new Common.Forms.Base.MLLabel();
            this.labelPhone = new Common.Forms.Base.MLLabel();
            this.metroLabel6 = new Common.Forms.Base.MLLabel();
            this.labelAddress = new Common.Forms.Base.MLLabel();
            this.metroLabel4 = new Common.Forms.Base.MLLabel();
            this.labelCompanyName = new Common.Forms.Base.MLLabel();
            this.metroLabel1 = new Common.Forms.Base.MLLabel();
            this.btnEditInfo = new Common.Forms.Base.MLButton();
            this.btnAddMol = new Common.Forms.Base.MLButton();
            this.dgvMol = new MetroFramework.Controls.MetroGrid();
            this.btnEditMol = new Common.Forms.Base.MLButton();
            this.metroTabPage3 = new Common.Forms.Base.MLTabPage();
            this.mlGroupBox3 = new Common.Forms.Base.MLGroupBox();
            this.tbVatMultiplier = new System.Windows.Forms.NumericUpDown();
            this.labelErrorSettings = new Common.Forms.Base.MLErrorLabel();
            this.btnSaveSettings = new Common.Forms.Base.MLButton();
            this.tbPdfSaveLocation = new Common.Forms.Base.MLTextBox();
            this.ff = new Common.Forms.Base.MLLabel();
            this.mlLabel1 = new Common.Forms.Base.MLLabel();
            this.tabControlAdmin.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.mlGroupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMol)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.mlGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVatMultiplier)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.metroTabPage1);
            this.tabControlAdmin.Controls.Add(this.metroTabPage2);
            this.tabControlAdmin.Controls.Add(this.metroTabPage3);
            this.tabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 2;
            this.tabControlAdmin.Size = new System.Drawing.Size(933, 560);
            this.tabControlAdmin.TabIndex = 0;
            this.tabControlAdmin.UseSelectable = true;
            this.tabControlAdmin.SelectedIndexChanged += new System.EventHandler(this.tabControlAdmin_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.dgvUsers);
            this.metroTabPage1.Controls.Add(this.btnAddNewUser);
            this.metroTabPage1.Controls.Add(this.btnEditUser);
            this.metroTabPage1.Controls.Add(this.btnDeleteUser);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(925, 518);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "manage_users";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUsers.Location = new System.Drawing.Point(3, 224);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(919, 294);
            this.dgvUsers.TabIndex = 4;
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(3, 195);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(95, 23);
            this.btnAddNewUser.TabIndex = 3;
            this.btnAddNewUser.Text = "add_new_user";
            this.btnAddNewUser.UseSelectable = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(104, 195);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(95, 23);
            this.btnEditUser.TabIndex = 5;
            this.btnEditUser.Text = "edit_user";
            this.btnEditUser.UseSelectable = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(205, 195);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(95, 23);
            this.btnDeleteUser.TabIndex = 6;
            this.btnDeleteUser.Text = "delete_user";
            this.btnDeleteUser.UseSelectable = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.mlGroupBox2);
            this.metroTabPage2.Controls.Add(this.mlGroupBox1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(925, 518);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "manage_company";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // mlGroupBox2
            // 
            this.mlGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mlGroupBox2.BackColor = System.Drawing.Color.White;
            this.mlGroupBox2.Location = new System.Drawing.Point(447, 4);
            this.mlGroupBox2.Name = "mlGroupBox2";
            this.mlGroupBox2.Size = new System.Drawing.Size(437, 514);
            this.mlGroupBox2.TabIndex = 8;
            this.mlGroupBox2.TabStop = false;
            // 
            // mlGroupBox1
            // 
            this.mlGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mlGroupBox1.BackColor = System.Drawing.Color.White;
            this.mlGroupBox1.Controls.Add(this.btnDeleteMol);
            this.mlGroupBox1.Controls.Add(this.groupBox1);
            this.mlGroupBox1.Controls.Add(this.btnEditInfo);
            this.mlGroupBox1.Controls.Add(this.btnAddMol);
            this.mlGroupBox1.Controls.Add(this.dgvMol);
            this.mlGroupBox1.Controls.Add(this.btnEditMol);
            this.mlGroupBox1.Location = new System.Drawing.Point(4, 4);
            this.mlGroupBox1.Name = "mlGroupBox1";
            this.mlGroupBox1.Size = new System.Drawing.Size(437, 514);
            this.mlGroupBox1.TabIndex = 7;
            this.mlGroupBox1.TabStop = false;
            // 
            // btnDeleteMol
            // 
            this.btnDeleteMol.Location = new System.Drawing.Point(330, 226);
            this.btnDeleteMol.Name = "btnDeleteMol";
            this.btnDeleteMol.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteMol.TabIndex = 7;
            this.btnDeleteMol.Text = "delete_mol";
            this.btnDeleteMol.UseSelectable = true;
            this.btnDeleteMol.Click += new System.EventHandler(this.btnDeleteMol_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelBulstat);
            this.groupBox1.Controls.Add(this.mlLabel2);
            this.groupBox1.Controls.Add(this.labelVAT);
            this.groupBox1.Controls.Add(this.mlLabel4);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.labelAddress);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.labelCompanyName);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 201);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "company_info";
            // 
            // labelBulstat
            // 
            this.labelBulstat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBulstat.AutoSize = true;
            this.labelBulstat.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelBulstat.Location = new System.Drawing.Point(169, 160);
            this.labelBulstat.Name = "labelBulstat";
            this.labelBulstat.Size = new System.Drawing.Size(81, 19);
            this.labelBulstat.TabIndex = 11;
            this.labelBulstat.Text = "160160160";
            // 
            // mlLabel2
            // 
            this.mlLabel2.AutoSize = true;
            this.mlLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel2.Location = new System.Drawing.Point(7, 160);
            this.mlLabel2.Name = "mlLabel2";
            this.mlLabel2.Size = new System.Drawing.Size(105, 19);
            this.mlLabel2.TabIndex = 10;
            this.mlLabel2.Text = "bulstat_number";
            // 
            // labelVAT
            // 
            this.labelVAT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelVAT.AutoSize = true;
            this.labelVAT.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelVAT.Location = new System.Drawing.Point(169, 132);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(80, 19);
            this.labelVAT.TabIndex = 9;
            this.labelVAT.Text = "randomVAT";
            // 
            // mlLabel4
            // 
            this.mlLabel4.AutoSize = true;
            this.mlLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel4.Location = new System.Drawing.Point(7, 132);
            this.mlLabel4.Name = "mlLabel4";
            this.mlLabel4.Size = new System.Drawing.Size(82, 19);
            this.mlLabel4.TabIndex = 8;
            this.mlLabel4.Text = "vat_number";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEmail.AutoSize = true;
            this.labelEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelEmail.Location = new System.Drawing.Point(169, 104);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(142, 19);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "random@random.rng";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(7, 104);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(41, 19);
            this.metroLabel8.TabIndex = 6;
            this.metroLabel8.Text = "email";
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPhone.AutoSize = true;
            this.labelPhone.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelPhone.Location = new System.Drawing.Point(169, 76);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(96, 19);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "randomPhone";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(7, 76);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(48, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "phone";
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAddress.AutoSize = true;
            this.labelAddress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelAddress.Location = new System.Drawing.Point(169, 48);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(98, 19);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "randomAdress";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(7, 48);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "address";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelCompanyName.Location = new System.Drawing.Point(169, 20);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(93, 19);
            this.labelCompanyName.TabIndex = 1;
            this.labelCompanyName.Text = "randomName";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(7, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "company_name";
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Location = new System.Drawing.Point(6, 226);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(102, 23);
            this.btnEditInfo.TabIndex = 3;
            this.btnEditInfo.Text = "edit_company_info";
            this.btnEditInfo.UseSelectable = true;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // btnAddMol
            // 
            this.btnAddMol.Location = new System.Drawing.Point(114, 226);
            this.btnAddMol.Name = "btnAddMol";
            this.btnAddMol.Size = new System.Drawing.Size(102, 23);
            this.btnAddMol.TabIndex = 4;
            this.btnAddMol.Text = "add_mol";
            this.btnAddMol.UseSelectable = true;
            this.btnAddMol.Click += new System.EventHandler(this.btnAddMol_Click);
            // 
            // dgvMol
            // 
            this.dgvMol.AllowUserToResizeRows = false;
            this.dgvMol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMol.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMol.EnableHeadersVisualStyles = false;
            this.dgvMol.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvMol.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMol.Location = new System.Drawing.Point(6, 255);
            this.dgvMol.Name = "dgvMol";
            this.dgvMol.ReadOnly = true;
            this.dgvMol.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMol.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMol.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMol.Size = new System.Drawing.Size(426, 253);
            this.dgvMol.TabIndex = 6;
            this.dgvMol.SelectionChanged += new System.EventHandler(this.dgvMol_SelectionChanged);
            // 
            // btnEditMol
            // 
            this.btnEditMol.Location = new System.Drawing.Point(222, 226);
            this.btnEditMol.Name = "btnEditMol";
            this.btnEditMol.Size = new System.Drawing.Size(102, 23);
            this.btnEditMol.TabIndex = 5;
            this.btnEditMol.Text = "edit_mol";
            this.btnEditMol.UseSelectable = true;
            this.btnEditMol.Click += new System.EventHandler(this.btnEditMol_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.mlGroupBox3);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(925, 518);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "settings_tab";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // mlGroupBox3
            // 
            this.mlGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mlGroupBox3.BackColor = System.Drawing.Color.White;
            this.mlGroupBox3.Controls.Add(this.tbVatMultiplier);
            this.mlGroupBox3.Controls.Add(this.labelErrorSettings);
            this.mlGroupBox3.Controls.Add(this.btnSaveSettings);
            this.mlGroupBox3.Controls.Add(this.tbPdfSaveLocation);
            this.mlGroupBox3.Controls.Add(this.ff);
            this.mlGroupBox3.Controls.Add(this.mlLabel1);
            this.mlGroupBox3.Location = new System.Drawing.Point(4, 4);
            this.mlGroupBox3.Name = "mlGroupBox3";
            this.mlGroupBox3.Size = new System.Drawing.Size(319, 511);
            this.mlGroupBox3.TabIndex = 2;
            this.mlGroupBox3.TabStop = false;
            this.mlGroupBox3.Text = "settings";
            // 
            // tbVatMultiplier
            // 
            this.tbVatMultiplier.Location = new System.Drawing.Point(10, 42);
            this.tbVatMultiplier.Name = "tbVatMultiplier";
            this.tbVatMultiplier.Size = new System.Drawing.Size(120, 20);
            this.tbVatMultiplier.TabIndex = 7;
            // 
            // labelErrorSettings
            // 
            this.labelErrorSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelErrorSettings.AutoSize = true;
            this.labelErrorSettings.ForeColor = System.Drawing.Color.Red;
            this.labelErrorSettings.Location = new System.Drawing.Point(7, 418);
            this.labelErrorSettings.MaximumSize = new System.Drawing.Size(306, 61);
            this.labelErrorSettings.Name = "labelErrorSettings";
            this.labelErrorSettings.Size = new System.Drawing.Size(0, 13);
            this.labelErrorSettings.TabIndex = 6;
            this.labelErrorSettings.Visible = false;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveSettings.Location = new System.Drawing.Point(238, 482);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 5;
            this.btnSaveSettings.Text = "save";
            this.btnSaveSettings.UseSelectable = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // tbPdfSaveLocation
            // 
            // 
            // 
            // 
            this.tbPdfSaveLocation.CustomButton.Image = null;
            this.tbPdfSaveLocation.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.tbPdfSaveLocation.CustomButton.Name = "";
            this.tbPdfSaveLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPdfSaveLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPdfSaveLocation.CustomButton.TabIndex = 1;
            this.tbPdfSaveLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPdfSaveLocation.CustomButton.UseSelectable = true;
            this.tbPdfSaveLocation.CustomButton.Visible = false;
            this.tbPdfSaveLocation.Lines = new string[0];
            this.tbPdfSaveLocation.Location = new System.Drawing.Point(7, 91);
            this.tbPdfSaveLocation.MaxLength = 32767;
            this.tbPdfSaveLocation.Name = "tbPdfSaveLocation";
            this.tbPdfSaveLocation.PasswordChar = '\0';
            this.tbPdfSaveLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPdfSaveLocation.SelectedText = "";
            this.tbPdfSaveLocation.SelectionLength = 0;
            this.tbPdfSaveLocation.SelectionStart = 0;
            this.tbPdfSaveLocation.ShortcutsEnabled = true;
            this.tbPdfSaveLocation.Size = new System.Drawing.Size(306, 23);
            this.tbPdfSaveLocation.TabIndex = 4;
            this.tbPdfSaveLocation.UseSelectable = true;
            this.tbPdfSaveLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPdfSaveLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ff
            // 
            this.ff.AutoSize = true;
            this.ff.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ff.Location = new System.Drawing.Point(7, 69);
            this.ff.Name = "ff";
            this.ff.Size = new System.Drawing.Size(116, 19);
            this.ff.TabIndex = 2;
            this.ff.Text = "pdf_save_location";
            // 
            // mlLabel1
            // 
            this.mlLabel1.AutoSize = true;
            this.mlLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel1.Location = new System.Drawing.Point(7, 20);
            this.mlLabel1.Name = "mlLabel1";
            this.mlLabel1.Size = new System.Drawing.Size(91, 19);
            this.mlLabel1.TabIndex = 0;
            this.mlLabel1.Text = "vat_multiplier";
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(933, 560);
            this.tabControlAdmin.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.mlGroupBox1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMol)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.mlGroupBox3.ResumeLayout(false);
            this.mlGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVatMultiplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MLTabControl tabControlAdmin;
        private MLTabPage metroTabPage1;
        private MLTabPage metroTabPage2;
        private MLTabPage metroTabPage3;
        private MLButton btnAddNewUser;
        private MetroFramework.Controls.MetroGrid dgvUsers;
        private MLGroupBox groupBox1;
        private MLLabel labelEmail;
        private MLLabel metroLabel8;
        private MLLabel labelPhone;
        private MLLabel metroLabel6;
        private MLLabel labelAddress;
        private MLLabel metroLabel4;
        private MLLabel labelCompanyName;
        private MLLabel metroLabel1;
        private MLButton btnEditInfo;
        private MLButton btnEditMol;
        private MLButton btnAddMol;
        private MetroFramework.Controls.MetroGrid dgvMol;
        private MLGroupBox mlGroupBox1;
        private MLButton btnDeleteMol;
        private MLButton btnEditUser;
        private MLButton btnDeleteUser;
        private MLGroupBox mlGroupBox2;
        private MLLabel labelBulstat;
        private MLLabel mlLabel2;
        private MLLabel labelVAT;
        private MLLabel mlLabel4;
        private MLGroupBox mlGroupBox3;
        private MLTextBox tbPdfSaveLocation;
        private MLLabel ff;
        private MLLabel mlLabel1;
        private MLButton btnSaveSettings;
        private MLErrorLabel labelErrorSettings;
        private NumericUpDown tbVatMultiplier;
    }
}
