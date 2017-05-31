using Common;
using Common.Forms.Base;

namespace DB3Client.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mpContainer = new MetroFramework.Controls.MetroPanel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLink1 = new Common.Forms.Base.MLLink();
            this.labelTime = new Common.Forms.Base.MLLabel();
            this.labelLogedAs = new Common.Forms.Base.MLLabel();
            this.labelCurrentServer = new Common.Forms.Base.MLLabel();
            this.mlGroupBox1 = new Common.Forms.Base.MLGroupBox();
            this.mtReports = new Common.Forms.Base.MLTile();
            this.mtSales = new Common.Forms.Base.MLTile();
            this.mtWerehouse = new Common.Forms.Base.MLTile();
            this.mtAdmin = new Common.Forms.Base.MLTile();
            this.mtContacts = new Common.Forms.Base.MLTile();
            this.mtOrders = new Common.Forms.Base.MLTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.mlGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mpContainer
            // 
            this.mpContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpContainer.HorizontalScrollbarBarColor = true;
            this.mpContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.mpContainer.HorizontalScrollbarSize = 10;
            this.mpContainer.Location = new System.Drawing.Point(191, 128);
            this.mpContainer.Name = "mpContainer";
            this.mpContainer.Size = new System.Drawing.Size(977, 602);
            this.mpContainer.TabIndex = 0;
            this.mpContainer.VerticalScrollbarBarColor = true;
            this.mpContainer.VerticalScrollbarHighlightOnWheel = false;
            this.mpContainer.VerticalScrollbarSize = 10;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.metroLink1);
            this.groupBox1.Controls.Add(this.labelTime);
            this.groupBox1.Controls.Add(this.labelLogedAs);
            this.groupBox1.Controls.Add(this.labelCurrentServer);
            this.groupBox1.Location = new System.Drawing.Point(796, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 99);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink1.Location = new System.Drawing.Point(299, 70);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(67, 23);
            this.metroLink1.TabIndex = 14;
            this.metroLink1.Text = "logout";
            this.metroLink1.UseSelectable = true;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelTime.Location = new System.Drawing.Point(6, 54);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(153, 19);
            this.labelTime.TabIndex = 16;
            this.labelTime.Text = "24 xxxxx 2017 33;33;44";
            // 
            // labelLogedAs
            // 
            this.labelLogedAs.AutoSize = true;
            this.labelLogedAs.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelLogedAs.Location = new System.Drawing.Point(6, 16);
            this.labelLogedAs.Name = "labelLogedAs";
            this.labelLogedAs.Size = new System.Drawing.Size(152, 19);
            this.labelLogedAs.TabIndex = 13;
            this.labelLogedAs.Text = "logged_as_current_user";
            // 
            // labelCurrentServer
            // 
            this.labelCurrentServer.AutoSize = true;
            this.labelCurrentServer.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelCurrentServer.Location = new System.Drawing.Point(6, 35);
            this.labelCurrentServer.Name = "labelCurrentServer";
            this.labelCurrentServer.Size = new System.Drawing.Size(134, 19);
            this.labelCurrentServer.TabIndex = 15;
            this.labelCurrentServer.Text = "connected_to_server";
            // 
            // mlGroupBox1
            // 
            this.mlGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mlGroupBox1.BackColor = System.Drawing.Color.White;
            this.mlGroupBox1.Controls.Add(this.mtReports);
            this.mlGroupBox1.Controls.Add(this.mtSales);
            this.mlGroupBox1.Controls.Add(this.mtWerehouse);
            this.mlGroupBox1.Controls.Add(this.mtAdmin);
            this.mlGroupBox1.Controls.Add(this.mtContacts);
            this.mlGroupBox1.Controls.Add(this.mtOrders);
            this.mlGroupBox1.Location = new System.Drawing.Point(23, 128);
            this.mlGroupBox1.Name = "mlGroupBox1";
            this.mlGroupBox1.Size = new System.Drawing.Size(162, 602);
            this.mlGroupBox1.TabIndex = 2;
            this.mlGroupBox1.TabStop = false;
            this.mlGroupBox1.Text = "main_navigation";
            // 
            // mtReports
            // 
            this.mtReports.ActiveControl = null;
            this.mtReports.Location = new System.Drawing.Point(6, 410);
            this.mtReports.Name = "mtReports";
            this.mtReports.Size = new System.Drawing.Size(150, 88);
            this.mtReports.TabIndex = 12;
            this.mtReports.Text = "reports";
            this.mtReports.TileImage = global::DB3Client.Resource.reports;
            this.mtReports.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtReports.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtReports.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtReports.UseSelectable = true;
            this.mtReports.UseTileImage = true;
            this.mtReports.Click += new System.EventHandler(this.mtReports_Click);
            // 
            // mtSales
            // 
            this.mtSales.ActiveControl = null;
            this.mtSales.Location = new System.Drawing.Point(6, 19);
            this.mtSales.Name = "mtSales";
            this.mtSales.PaintTileCount = false;
            this.mtSales.Size = new System.Drawing.Size(150, 92);
            this.mtSales.TabIndex = 7;
            this.mtSales.Text = "sales";
            this.mtSales.TileImage = global::DB3Client.Resource.cash_register90;
            this.mtSales.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtSales.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSales.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtSales.UseSelectable = true;
            this.mtSales.UseTileImage = true;
            this.mtSales.Click += new System.EventHandler(this.mtSales_Click);
            // 
            // mtWerehouse
            // 
            this.mtWerehouse.ActiveControl = null;
            this.mtWerehouse.BackColor = System.Drawing.Color.White;
            this.mtWerehouse.ForeColor = System.Drawing.Color.Black;
            this.mtWerehouse.Location = new System.Drawing.Point(6, 117);
            this.mtWerehouse.Name = "mtWerehouse";
            this.mtWerehouse.Size = new System.Drawing.Size(150, 92);
            this.mtWerehouse.TabIndex = 10;
            this.mtWerehouse.Text = "werehouse";
            this.mtWerehouse.TileImage = global::DB3Client.Resource.warehouse_90;
            this.mtWerehouse.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtWerehouse.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtWerehouse.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtWerehouse.UseSelectable = true;
            this.mtWerehouse.UseTileImage = true;
            this.mtWerehouse.Click += new System.EventHandler(this.mtWerehouse_Click);
            // 
            // mtAdmin
            // 
            this.mtAdmin.ActiveControl = null;
            this.mtAdmin.Location = new System.Drawing.Point(6, 504);
            this.mtAdmin.Name = "mtAdmin";
            this.mtAdmin.Size = new System.Drawing.Size(150, 92);
            this.mtAdmin.TabIndex = 11;
            this.mtAdmin.Text = "administration";
            this.mtAdmin.TileImage = global::DB3Client.Resource.admin_icon90;
            this.mtAdmin.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtAdmin.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAdmin.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtAdmin.UseSelectable = true;
            this.mtAdmin.UseTileImage = true;
            this.mtAdmin.Click += new System.EventHandler(this.mtAdmin_Click);
            // 
            // mtContacts
            // 
            this.mtContacts.ActiveControl = null;
            this.mtContacts.Location = new System.Drawing.Point(6, 214);
            this.mtContacts.Name = "mtContacts";
            this.mtContacts.Size = new System.Drawing.Size(150, 92);
            this.mtContacts.TabIndex = 9;
            this.mtContacts.Text = "contacts";
            this.mtContacts.TileImage = global::DB3Client.Resource.partners_icon90;
            this.mtContacts.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtContacts.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtContacts.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtContacts.UseSelectable = true;
            this.mtContacts.UseTileImage = true;
            this.mtContacts.Click += new System.EventHandler(this.mtContacts_Click);
            // 
            // mtOrders
            // 
            this.mtOrders.ActiveControl = null;
            this.mtOrders.Location = new System.Drawing.Point(6, 312);
            this.mtOrders.Name = "mtOrders";
            this.mtOrders.Size = new System.Drawing.Size(150, 92);
            this.mtOrders.TabIndex = 8;
            this.mtOrders.Text = "orders";
            this.mtOrders.TileImage = global::DB3Client.Resource.orders90;
            this.mtOrders.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtOrders.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtOrders.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtOrders.UseSelectable = true;
            this.mtOrders.UseTileImage = true;
            this.mtOrders.Click += new System.EventHandler(this.mtOrders_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 99);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 742);
            this.Controls.Add(this.mlGroupBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mpContainer);
            this.Name = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mlGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Common.Forms.Base.MLTile mtReports;
        private Common.Forms.Base.MLTile mtAdmin;
        private Common.Forms.Base.MLTile mtWerehouse;
        private Common.Forms.Base.MLTile mtContacts;
        private Common.Forms.Base.MLTile mtOrders;
        private Common.Forms.Base.MLTile mtSales;
        private System.Windows.Forms.Timer timerClock;
        private MLLabel labelCurrentServer;
        private MLLabel labelLogedAs;
        private MLLabel labelTime;
        private MLLink metroLink1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MLGroupBox mlGroupBox1;
    }
}