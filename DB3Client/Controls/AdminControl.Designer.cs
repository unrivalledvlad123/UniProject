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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlAdmin = new Common.Forms.Base.MLTabControl();
            this.metroTabPage1 = new Common.Forms.Base.MLTabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUsers = new MetroFramework.Controls.MetroGrid();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.treeViewPermissions = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSavePermissions = new Common.Forms.Base.MLButton();
            this.labelError = new Common.Forms.Base.MLErrorLabel();
            this.tbSearchUser = new Common.Forms.Base.MLTextBox();
            this.btnAddNewUser = new Common.Forms.Base.MLButton();
            this.btnEditUser = new Common.Forms.Base.MLButton();
            this.btnDeleteUser = new Common.Forms.Base.MLButton();
            this.metroTabPage2 = new Common.Forms.Base.MLTabPage();
            this.mlGroupBox1 = new Common.Forms.Base.MLGroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.mlGroupBox2 = new Common.Forms.Base.MLGroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMol = new MetroFramework.Controls.MetroGrid();
            this.dgvPrimaryMol = new MetroFramework.Controls.MetroGrid();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.mlLabel8 = new Common.Forms.Base.MLLabel();
            this.mlLabel9 = new Common.Forms.Base.MLLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditInfo = new Common.Forms.Base.MLButton();
            this.btnDeleteMol = new Common.Forms.Base.MLButton();
            this.btnAddMol = new Common.Forms.Base.MLButton();
            this.btnEditMol = new Common.Forms.Base.MLButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new Common.Forms.Base.MLGroupBox();
            this.labelIban = new Common.Forms.Base.MLLabel();
            this.mlLabel5 = new Common.Forms.Base.MLLabel();
            this.labelBank = new Common.Forms.Base.MLLabel();
            this.mlLabel7 = new Common.Forms.Base.MLLabel();
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
            this.metroTabPage3 = new Common.Forms.Base.MLTabPage();
            this.mlLabel1 = new Common.Forms.Base.MLLabel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDirectorySettings = new Common.Forms.Base.MLButton();
            this.btnVatSettings = new Common.Forms.Base.MLButton();
            this.mlButton1 = new Common.Forms.Base.MLButton();
            this.btnGenerealSettings = new Common.Forms.Base.MLButton();
            this.panelSettings = new MetroFramework.Controls.MetroPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new Common.Forms.Base.MLToolTp();
            this.tabControlAdmin.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.mlGroupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.mlGroupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimaryMol)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.tabControlAdmin.SelectedIndex = 1;
            this.tabControlAdmin.Size = new System.Drawing.Size(932, 560);
            this.tabControlAdmin.TabIndex = 0;
            this.tabControlAdmin.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.tableLayoutPanel8);
            this.metroTabPage1.Controls.Add(this.tbSearchUser);
            this.metroTabPage1.Controls.Add(this.btnAddNewUser);
            this.metroTabPage1.Controls.Add(this.btnEditUser);
            this.metroTabPage1.Controls.Add(this.btnDeleteUser);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(924, 518);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "manage_users";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel8.Controls.Add(this.dgvUsers, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(921, 469);
            this.tableLayoutPanel8.TabIndex = 8;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUsers.Location = new System.Drawing.Point(3, 3);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(638, 463);
            this.dgvUsers.TabIndex = 4;
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
            this.dgvUsers.Click += new System.EventHandler(this.dgvUsers_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.treeViewPermissions, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(647, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(271, 463);
            this.tableLayoutPanel9.TabIndex = 5;
            // 
            // treeViewPermissions
            // 
            this.treeViewPermissions.CheckBoxes = true;
            this.treeViewPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewPermissions.Location = new System.Drawing.Point(3, 3);
            this.treeViewPermissions.Name = "treeViewPermissions";
            this.treeViewPermissions.Size = new System.Drawing.Size(265, 422);
            this.treeViewPermissions.TabIndex = 5;
            this.treeViewPermissions.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPermissions_AfterCheck);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.btnSavePermissions, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.labelError, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 431);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(265, 29);
            this.tableLayoutPanel10.TabIndex = 6;
            // 
            // btnSavePermissions
            // 
            this.btnSavePermissions.Location = new System.Drawing.Point(3, 3);
            this.btnSavePermissions.Name = "btnSavePermissions";
            this.btnSavePermissions.Size = new System.Drawing.Size(93, 23);
            this.btnSavePermissions.TabIndex = 0;
            this.btnSavePermissions.Text = "save";
            this.btnSavePermissions.UseSelectable = true;
            this.btnSavePermissions.Click += new System.EventHandler(this.btnSavePermissions_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(102, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 1;
            this.labelError.Visible = false;
            // 
            // tbSearchUser
            // 
            // 
            // 
            // 
            this.tbSearchUser.CustomButton.Image = null;
            this.tbSearchUser.CustomButton.Location = new System.Drawing.Point(275, 1);
            this.tbSearchUser.CustomButton.Name = "";
            this.tbSearchUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSearchUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearchUser.CustomButton.TabIndex = 1;
            this.tbSearchUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearchUser.CustomButton.UseSelectable = true;
            this.tbSearchUser.CustomButton.Visible = false;
            this.tbSearchUser.Lines = new string[0];
            this.tbSearchUser.Location = new System.Drawing.Point(3, 17);
            this.tbSearchUser.MaxLength = 32767;
            this.tbSearchUser.Name = "tbSearchUser";
            this.tbSearchUser.PasswordChar = '\0';
            this.tbSearchUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearchUser.SelectedText = "";
            this.tbSearchUser.SelectionLength = 0;
            this.tbSearchUser.SelectionStart = 0;
            this.tbSearchUser.ShortcutsEnabled = true;
            this.tbSearchUser.Size = new System.Drawing.Size(297, 23);
            this.tbSearchUser.TabIndex = 7;
            this.tbSearchUser.UseSelectable = true;
            this.tbSearchUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearchUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbSearchUser.TextChanged += new System.EventHandler(this.tbSearchUser_TextChanged);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(306, 17);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(95, 23);
            this.btnAddNewUser.TabIndex = 3;
            this.btnAddNewUser.Tag = "B762587D-D868-456A-BB05-547D7C292DD5";
            this.btnAddNewUser.Text = "add_new_user";
            this.toolTip1.SetToolTip(this.btnAddNewUser, "add_new_user");
            this.btnAddNewUser.UseSelectable = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(407, 17);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(95, 23);
            this.btnEditUser.TabIndex = 5;
            this.btnEditUser.Tag = "AEE0DF0D-94AE-488D-8F50-E5185BF56499";
            this.btnEditUser.Text = "edit_user";
            this.toolTip1.SetToolTip(this.btnEditUser, "edit_user");
            this.btnEditUser.UseSelectable = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(508, 17);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(95, 23);
            this.btnDeleteUser.TabIndex = 6;
            this.btnDeleteUser.Tag = "99CEE3E2-6AD4-4A3C-8722-3363F98218A9";
            this.btnDeleteUser.Text = "delete_user";
            this.toolTip1.SetToolTip(this.btnDeleteUser, "delete_user");
            this.btnDeleteUser.UseSelectable = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.mlGroupBox1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(924, 518);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "manage_company";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // mlGroupBox1
            // 
            this.mlGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlGroupBox1.BackColor = System.Drawing.Color.White;
            this.mlGroupBox1.Controls.Add(this.tableLayoutPanel3);
            this.mlGroupBox1.Controls.Add(this.groupBox1);
            this.mlGroupBox1.Location = new System.Drawing.Point(4, 4);
            this.mlGroupBox1.Name = "mlGroupBox1";
            this.mlGroupBox1.Size = new System.Drawing.Size(917, 514);
            this.mlGroupBox1.TabIndex = 7;
            this.mlGroupBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.mlGroupBox2, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 190);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(905, 318);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // mlGroupBox2
            // 
            this.mlGroupBox2.BackColor = System.Drawing.Color.White;
            this.mlGroupBox2.Controls.Add(this.tableLayoutPanel5);
            this.mlGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlGroupBox2.Location = new System.Drawing.Point(3, 3);
            this.mlGroupBox2.Name = "mlGroupBox2";
            this.mlGroupBox2.Size = new System.Drawing.Size(899, 312);
            this.mlGroupBox2.TabIndex = 1;
            this.mlGroupBox2.TabStop = false;
            this.mlGroupBox2.Text = "manage_mol";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(893, 293);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvMol, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvPrimaryMol, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mlLabel8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mlLabel9, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(887, 242);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // dgvMol
            // 
            this.dgvMol.AllowUserToResizeRows = false;
            this.dgvMol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvMol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMol.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgvMol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMol.EnableHeadersVisualStyles = false;
            this.dgvMol.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvMol.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMol.Location = new System.Drawing.Point(468, 28);
            this.dgvMol.Name = "dgvMol";
            this.dgvMol.ReadOnly = true;
            this.dgvMol.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMol.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvMol.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMol.Size = new System.Drawing.Size(416, 211);
            this.dgvMol.TabIndex = 6;
            this.dgvMol.SelectionChanged += new System.EventHandler(this.dgvMol_SelectionChanged);
            // 
            // dgvPrimaryMol
            // 
            this.dgvPrimaryMol.AllowUserToAddRows = false;
            this.dgvPrimaryMol.AllowUserToResizeRows = false;
            this.dgvPrimaryMol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPrimaryMol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrimaryMol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPrimaryMol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrimaryMol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvPrimaryMol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrimaryMol.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgvPrimaryMol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrimaryMol.EnableHeadersVisualStyles = false;
            this.dgvPrimaryMol.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPrimaryMol.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrimaryMol.Location = new System.Drawing.Point(3, 28);
            this.dgvPrimaryMol.Name = "dgvPrimaryMol";
            this.dgvPrimaryMol.ReadOnly = true;
            this.dgvPrimaryMol.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrimaryMol.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvPrimaryMol.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrimaryMol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrimaryMol.Size = new System.Drawing.Size(415, 211);
            this.dgvPrimaryMol.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxRed, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxGreen, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(424, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(38, 211);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.BackgroundImage = global::DB3Client.Resource.nav_right_red;
            this.pictureBoxRed.Location = new System.Drawing.Point(3, 108);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(32, 30);
            this.pictureBoxRed.TabIndex = 16;
            this.pictureBoxRed.TabStop = false;
            this.pictureBoxRed.Tag = "3374E66E-031E-4C5A-A42E-4ECE01E0B439";
            this.toolTip1.SetToolTip(this.pictureBoxRed, "remove_primery");
            this.pictureBoxRed.Click += new System.EventHandler(this.pictureBoxRed_Click);
            this.pictureBoxRed.MouseEnter += new System.EventHandler(this.pictureBoxRed_MouseEnter);
            this.pictureBoxRed.MouseLeave += new System.EventHandler(this.pictureBoxRed_MouseLeave);
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.BackgroundImage = global::DB3Client.Resource.nav_left_green;
            this.pictureBoxGreen.Location = new System.Drawing.Point(3, 72);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(32, 30);
            this.pictureBoxGreen.TabIndex = 11;
            this.pictureBoxGreen.TabStop = false;
            this.pictureBoxGreen.Tag = "E008B27F-52FA-4D1A-8C35-1570F1EBE6DC";
            this.toolTip1.SetToolTip(this.pictureBoxGreen, "make_primery");
            this.pictureBoxGreen.Click += new System.EventHandler(this.pictureBoxGreen_Click);
            this.pictureBoxGreen.MouseEnter += new System.EventHandler(this.pictureBoxGreen_MouseEnter);
            this.pictureBoxGreen.MouseLeave += new System.EventHandler(this.pictureBoxGreen_MouseLeave);
            // 
            // mlLabel8
            // 
            this.mlLabel8.AutoSize = true;
            this.mlLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel8.Location = new System.Drawing.Point(3, 0);
            this.mlLabel8.Name = "mlLabel8";
            this.mlLabel8.Size = new System.Drawing.Size(93, 19);
            this.mlLabel8.TabIndex = 9;
            this.mlLabel8.Text = "primery_MOL";
            // 
            // mlLabel9
            // 
            this.mlLabel9.AutoSize = true;
            this.mlLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel9.Location = new System.Drawing.Point(468, 0);
            this.mlLabel9.Name = "mlLabel9";
            this.mlLabel9.Size = new System.Drawing.Size(124, 19);
            this.mlLabel9.TabIndex = 10;
            this.mlLabel9.Text = "all_available_MOLS";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.btnEditInfo, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnDeleteMol, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAddMol, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnEditMol, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(887, 30);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditInfo.Location = new System.Drawing.Point(3, 3);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(94, 23);
            this.btnEditInfo.TabIndex = 3;
            this.btnEditInfo.Tag = "6A1D1F0D-7742-4AC7-901F-D1ED22F05DD7";
            this.btnEditInfo.Text = "edit_company_info";
            this.toolTip1.SetToolTip(this.btnEditInfo, "edit_company_info");
            this.btnEditInfo.UseSelectable = true;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // btnDeleteMol
            // 
            this.btnDeleteMol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMol.Location = new System.Drawing.Point(303, 3);
            this.btnDeleteMol.Name = "btnDeleteMol";
            this.btnDeleteMol.Size = new System.Drawing.Size(94, 23);
            this.btnDeleteMol.TabIndex = 7;
            this.btnDeleteMol.Tag = "E8962FA8-C653-49BB-AAA7-8ACA9D3E1A11";
            this.btnDeleteMol.Text = "delete_mol";
            this.toolTip1.SetToolTip(this.btnDeleteMol, "delete_mol");
            this.btnDeleteMol.UseSelectable = true;
            this.btnDeleteMol.Click += new System.EventHandler(this.btnDeleteMol_Click);
            // 
            // btnAddMol
            // 
            this.btnAddMol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMol.Location = new System.Drawing.Point(103, 3);
            this.btnAddMol.Name = "btnAddMol";
            this.btnAddMol.Size = new System.Drawing.Size(94, 23);
            this.btnAddMol.TabIndex = 4;
            this.btnAddMol.Tag = "2A1F186A-1CC5-4830-BDE9-4E489753C297";
            this.btnAddMol.Text = "add_mol";
            this.toolTip1.SetToolTip(this.btnAddMol, "add_mol");
            this.btnAddMol.UseSelectable = true;
            this.btnAddMol.Click += new System.EventHandler(this.btnAddMol_Click);
            // 
            // btnEditMol
            // 
            this.btnEditMol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditMol.Location = new System.Drawing.Point(203, 3);
            this.btnEditMol.Name = "btnEditMol";
            this.btnEditMol.Size = new System.Drawing.Size(94, 23);
            this.btnEditMol.TabIndex = 5;
            this.btnEditMol.Tag = "79DC9C51-F2F9-4FA6-90B5-B762CAFE2A15";
            this.btnEditMol.Text = "edit_mol";
            this.toolTip1.SetToolTip(this.btnEditMol, "edit_mol");
            this.btnEditMol.UseSelectable = true;
            this.btnEditMol.Click += new System.EventHandler(this.btnEditMol_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::DB3Client.Resource.blueLine;
            this.pictureBox1.Location = new System.Drawing.Point(3, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(887, 3);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelIban);
            this.groupBox1.Controls.Add(this.mlLabel5);
            this.groupBox1.Controls.Add(this.labelBank);
            this.groupBox1.Controls.Add(this.mlLabel7);
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
            this.groupBox1.Size = new System.Drawing.Size(905, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "company_info";
            // 
            // labelIban
            // 
            this.labelIban.AutoSize = true;
            this.labelIban.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelIban.Location = new System.Drawing.Point(572, 104);
            this.labelIban.Name = "labelIban";
            this.labelIban.Size = new System.Drawing.Size(81, 19);
            this.labelIban.TabIndex = 15;
            this.labelIban.Text = "160160160";
            // 
            // mlLabel5
            // 
            this.mlLabel5.AutoSize = true;
            this.mlLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel5.Location = new System.Drawing.Point(402, 104);
            this.mlLabel5.Name = "mlLabel5";
            this.mlLabel5.Size = new System.Drawing.Size(35, 19);
            this.mlLabel5.TabIndex = 14;
            this.mlLabel5.Text = "iban";
            // 
            // labelBank
            // 
            this.labelBank.AutoSize = true;
            this.labelBank.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelBank.Location = new System.Drawing.Point(572, 76);
            this.labelBank.Name = "labelBank";
            this.labelBank.Size = new System.Drawing.Size(82, 19);
            this.labelBank.TabIndex = 13;
            this.labelBank.Text = "randomVAT";
            // 
            // mlLabel7
            // 
            this.mlLabel7.AutoSize = true;
            this.mlLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel7.Location = new System.Drawing.Point(402, 76);
            this.mlLabel7.Name = "mlLabel7";
            this.mlLabel7.Size = new System.Drawing.Size(39, 19);
            this.mlLabel7.TabIndex = 12;
            this.mlLabel7.Text = "bank";
            // 
            // labelBulstat
            // 
            this.labelBulstat.AutoSize = true;
            this.labelBulstat.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelBulstat.Location = new System.Drawing.Point(572, 48);
            this.labelBulstat.Name = "labelBulstat";
            this.labelBulstat.Size = new System.Drawing.Size(81, 19);
            this.labelBulstat.TabIndex = 11;
            this.labelBulstat.Text = "160160160";
            // 
            // mlLabel2
            // 
            this.mlLabel2.AutoSize = true;
            this.mlLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel2.Location = new System.Drawing.Point(402, 48);
            this.mlLabel2.Name = "mlLabel2";
            this.mlLabel2.Size = new System.Drawing.Size(105, 19);
            this.mlLabel2.TabIndex = 10;
            this.mlLabel2.Text = "bulstat_number";
            // 
            // labelVAT
            // 
            this.labelVAT.AutoSize = true;
            this.labelVAT.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelVAT.Location = new System.Drawing.Point(572, 20);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(82, 19);
            this.labelVAT.TabIndex = 9;
            this.labelVAT.Text = "randomVAT";
            // 
            // mlLabel4
            // 
            this.mlLabel4.AutoSize = true;
            this.mlLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel4.Location = new System.Drawing.Point(402, 20);
            this.mlLabel4.Name = "mlLabel4";
            this.mlLabel4.Size = new System.Drawing.Size(82, 19);
            this.mlLabel4.TabIndex = 8;
            this.mlLabel4.Text = "vat_number";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelEmail.Location = new System.Drawing.Point(177, 104);
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
            this.labelPhone.AutoSize = true;
            this.labelPhone.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelPhone.Location = new System.Drawing.Point(177, 76);
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
            this.labelAddress.AutoSize = true;
            this.labelAddress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelAddress.Location = new System.Drawing.Point(177, 48);
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
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelCompanyName.Location = new System.Drawing.Point(177, 20);
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
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.mlLabel1);
            this.metroTabPage3.Controls.Add(this.tableLayoutPanel6);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(924, 518);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "settings_tab";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // mlLabel1
            // 
            this.mlLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel1.Location = new System.Drawing.Point(3, 0);
            this.mlLabel1.MinimumSize = new System.Drawing.Size(100, 10);
            this.mlLabel1.Name = "mlLabel1";
            this.mlLabel1.Size = new System.Drawing.Size(100, 10);
            this.mlLabel1.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.panelSettings, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 13);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(924, 505);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.btnDirectorySettings, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnVatSettings, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.mlButton1, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.btnGenerealSettings, 0, 3);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(268, 512);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // btnDirectorySettings
            // 
            this.btnDirectorySettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDirectorySettings.Location = new System.Drawing.Point(6, 39);
            this.btnDirectorySettings.Name = "btnDirectorySettings";
            this.btnDirectorySettings.Size = new System.Drawing.Size(256, 24);
            this.btnDirectorySettings.TabIndex = 1;
            this.btnDirectorySettings.Tag = "B5EA5576-4597-47CD-AA49-F8C83ADFED04";
            this.btnDirectorySettings.Text = "directory_settings";
            this.btnDirectorySettings.UseSelectable = true;
            this.btnDirectorySettings.Click += new System.EventHandler(this.btnDirectorySettings_Click);
            // 
            // btnVatSettings
            // 
            this.btnVatSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVatSettings.Location = new System.Drawing.Point(6, 6);
            this.btnVatSettings.Name = "btnVatSettings";
            this.btnVatSettings.Size = new System.Drawing.Size(256, 24);
            this.btnVatSettings.TabIndex = 0;
            this.btnVatSettings.Tag = "B97FE6B2-CFD4-4656-91FB-FAC579798A93";
            this.btnVatSettings.Text = "vat_settings";
            this.btnVatSettings.UseSelectable = true;
            this.btnVatSettings.Click += new System.EventHandler(this.btnVatSettings_Click);
            // 
            // mlButton1
            // 
            this.mlButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlButton1.Location = new System.Drawing.Point(6, 72);
            this.mlButton1.Name = "mlButton1";
            this.mlButton1.Size = new System.Drawing.Size(256, 24);
            this.mlButton1.TabIndex = 2;
            this.mlButton1.Tag = "E395707A-7A50-4E82-801D-6CBB8931A8A2";
            this.mlButton1.Text = "promotion_settings";
            this.mlButton1.UseSelectable = true;
            this.mlButton1.Click += new System.EventHandler(this.mlButton1_Click);
            // 
            // btnGenerealSettings
            // 
            this.btnGenerealSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerealSettings.Location = new System.Drawing.Point(6, 105);
            this.btnGenerealSettings.Name = "btnGenerealSettings";
            this.btnGenerealSettings.Size = new System.Drawing.Size(256, 24);
            this.btnGenerealSettings.TabIndex = 3;
            this.btnGenerealSettings.Tag = "3DBBFE0B-F340-4709-BB76-C60E0871032A";
            this.btnGenerealSettings.Text = "general_settings";
            this.btnGenerealSettings.UseSelectable = true;
            this.btnGenerealSettings.Click += new System.EventHandler(this.btnGenerealSettings_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.HorizontalScrollbarBarColor = true;
            this.panelSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.panelSettings.HorizontalScrollbarSize = 10;
            this.panelSettings.Location = new System.Drawing.Point(286, 3);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(635, 512);
            this.panelSettings.TabIndex = 4;
            this.panelSettings.VerticalScrollbarBarColor = true;
            this.panelSettings.VerticalScrollbarHighlightOnWheel = false;
            this.panelSettings.VerticalScrollbarSize = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DB3Client.Resource.blueLineUp;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(277, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(3, 512);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(932, 560);
            this.tabControlAdmin.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.mlGroupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.mlGroupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimaryMol)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private MLLabel labelBulstat;
        private MLLabel mlLabel2;
        private MLLabel labelVAT;
        private MLLabel mlLabel4;
        private MLLabel labelIban;
        private MLLabel mlLabel5;
        private MLLabel labelBank;
        private MLLabel mlLabel7;
        private TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroGrid dgvPrimaryMol;
        private TableLayoutPanel tableLayoutPanel2;
        private MLLabel mlLabel8;
        private MLLabel mlLabel9;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBoxGreen;
        private PictureBox pictureBoxRed;
        private MLGroupBox mlGroupBox2;
        private TableLayoutPanel tableLayoutPanel5;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private MLButton btnVatSettings;
        private MLButton btnDirectorySettings;
        private MetroFramework.Controls.MetroPanel panelSettings;
        private PictureBox pictureBox2;
        private MLButton mlButton1;
        private MLLabel mlLabel1;
        private MLTextBox tbSearchUser;
        private MLToolTp toolTip1;
        private MLButton btnGenerealSettings;
        private TableLayoutPanel tableLayoutPanel8;
        private TreeView treeViewPermissions;
        private TableLayoutPanel tableLayoutPanel9;
        private MLButton btnSavePermissions;
        private TableLayoutPanel tableLayoutPanel10;
        private MLErrorLabel labelError;
    }
}
