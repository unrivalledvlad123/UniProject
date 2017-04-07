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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLink1 = new Common.Forms.Base.MLLink();
            this.labelTime = new Common.Forms.Base.MLLabel();
            this.labelLogedAs = new Common.Forms.Base.MLLabel();
            this.labelCurrentServer = new Common.Forms.Base.MLLabel();
            this.metroTile6 = new Common.Forms.Base.MLTile();
            this.mtAdmin = new Common.Forms.Base.MLTile();
            this.mtWerehouse = new Common.Forms.Base.MLTile();
            this.mtContacts = new Common.Forms.Base.MLTile();
            this.mtOrders = new Common.Forms.Base.MLTile();
            this.mtSales = new Common.Forms.Base.MLTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.mpContainer.Location = new System.Drawing.Point(179, 128);
            this.mpContainer.Name = "mpContainer";
            this.mpContainer.Size = new System.Drawing.Size(989, 591);
            this.mpContainer.TabIndex = 0;
            this.mpContainer.VerticalScrollbarBarColor = true;
            this.mpContainer.VerticalScrollbarHighlightOnWheel = false;
            this.mpContainer.VerticalScrollbarSize = 10;
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
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(23, 618);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(144, 92);
            this.metroTile6.TabIndex = 12;
            this.metroTile6.Text = "under devolopments";
            this.metroTile6.UseSelectable = true;
            // 
            // mtAdmin
            // 
            this.mtAdmin.ActiveControl = null;
            this.mtAdmin.Location = new System.Drawing.Point(23, 520);
            this.mtAdmin.Name = "mtAdmin";
            this.mtAdmin.Size = new System.Drawing.Size(144, 92);
            this.mtAdmin.TabIndex = 11;
            this.mtAdmin.Text = "administration";
            this.mtAdmin.UseSelectable = true;
            this.mtAdmin.Click += new System.EventHandler(this.mtAdmin_Click);
            // 
            // mtWerehouse
            // 
            this.mtWerehouse.ActiveControl = null;
            this.mtWerehouse.Location = new System.Drawing.Point(23, 422);
            this.mtWerehouse.Name = "mtWerehouse";
            this.mtWerehouse.Size = new System.Drawing.Size(144, 92);
            this.mtWerehouse.TabIndex = 10;
            this.mtWerehouse.Text = "werehouse";
            this.mtWerehouse.UseSelectable = true;
            this.mtWerehouse.Click += new System.EventHandler(this.mtWerehouse_Click);
            // 
            // mtContacts
            // 
            this.mtContacts.ActiveControl = null;
            this.mtContacts.Location = new System.Drawing.Point(23, 324);
            this.mtContacts.Name = "mtContacts";
            this.mtContacts.Size = new System.Drawing.Size(144, 92);
            this.mtContacts.TabIndex = 9;
            this.mtContacts.Text = "contacts";
            this.mtContacts.UseSelectable = true;
            this.mtContacts.Click += new System.EventHandler(this.mtContacts_Click);
            // 
            // mtOrders
            // 
            this.mtOrders.ActiveControl = null;
            this.mtOrders.Location = new System.Drawing.Point(23, 226);
            this.mtOrders.Name = "mtOrders";
            this.mtOrders.Size = new System.Drawing.Size(144, 92);
            this.mtOrders.TabIndex = 8;
            this.mtOrders.Text = "orders";
            this.mtOrders.UseSelectable = true;
            this.mtOrders.Click += new System.EventHandler(this.mtOrders_Click);
            // 
            // mtSales
            // 
            this.mtSales.ActiveControl = null;
            this.mtSales.Location = new System.Drawing.Point(23, 128);
            this.mtSales.Name = "mtSales";
            this.mtSales.Size = new System.Drawing.Size(144, 92);
            this.mtSales.TabIndex = 7;
            this.mtSales.Text = "sales";
            this.mtSales.UseSelectable = true;
            this.mtSales.Click += new System.EventHandler(this.mtSales_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 742);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.mtAdmin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mtWerehouse);
            this.Controls.Add(this.mtContacts);
            this.Controls.Add(this.mtOrders);
            this.Controls.Add(this.mtSales);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mpContainer);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Common.Forms.Base.MLTile metroTile6;
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
    }
}