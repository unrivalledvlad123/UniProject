using Common;

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
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.mtAdmin = new MetroFramework.Controls.MetroTile();
            this.mtWerehouse = new MetroFramework.Controls.MetroTile();
            this.mtContacts = new MetroFramework.Controls.MetroTile();
            this.mtOrders = new MetroFramework.Controls.MetroTile();
            this.mtSales = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.labelTime = new MetroFramework.Controls.MetroLabel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
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
            this.mpContainer.Location = new System.Drawing.Point(179, 98);
            this.mpContainer.Name = "mpContainer";
            this.mpContainer.Size = new System.Drawing.Size(989, 589);
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
            this.pictureBox1.Size = new System.Drawing.Size(304, 69);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(23, 588);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(144, 92);
            this.metroTile6.TabIndex = 12;
            this.metroTile6.Text = "under devolopments";
            this.metroTile6.UseSelectable = true;
            // 
            // mtAdmin
            // 
            this.mtAdmin.ActiveControl = null;
            this.mtAdmin.Location = new System.Drawing.Point(23, 490);
            this.mtAdmin.Name = "mtAdmin";
            this.mtAdmin.Size = new System.Drawing.Size(144, 92);
            this.mtAdmin.TabIndex = 11;
            this.mtAdmin.Text = DataHolder.GetString("administration");
            this.mtAdmin.UseSelectable = true;
            this.mtAdmin.Click += new System.EventHandler(this.mtAdmin_Click);
            // 
            // mtWerehouse
            // 
            this.mtWerehouse.ActiveControl = null;
            this.mtWerehouse.Location = new System.Drawing.Point(23, 392);
            this.mtWerehouse.Name = "mtWerehouse";
            this.mtWerehouse.Size = new System.Drawing.Size(144, 92);
            this.mtWerehouse.TabIndex = 10;
            this.mtWerehouse.Text = DataHolder.GetString("werehouse");
            this.mtWerehouse.UseSelectable = true;
            this.mtWerehouse.Click += new System.EventHandler(this.mtWerehouse_Click);
            // 
            // mtContacts
            // 
            this.mtContacts.ActiveControl = null;
            this.mtContacts.Location = new System.Drawing.Point(23, 294);
            this.mtContacts.Name = "mtContacts";
            this.mtContacts.Size = new System.Drawing.Size(144, 92);
            this.mtContacts.TabIndex = 9;
            this.mtContacts.Text = DataHolder.GetString("contacts");
            this.mtContacts.UseSelectable = true;
            this.mtContacts.Click += new System.EventHandler(this.mtContacts_Click);
            // 
            // mtOrders
            // 
            this.mtOrders.ActiveControl = null;
            this.mtOrders.Location = new System.Drawing.Point(23, 196);
            this.mtOrders.Name = "mtOrders";
            this.mtOrders.Size = new System.Drawing.Size(144, 92);
            this.mtOrders.TabIndex = 8;
            this.mtOrders.Text = DataHolder.GetString("orders");
            this.mtOrders.UseSelectable = true;
            this.mtOrders.Click += new System.EventHandler(this.mtOrders_Click);
            // 
            // mtSales
            // 
            this.mtSales.ActiveControl = null;
            this.mtSales.Location = new System.Drawing.Point(23, 98);
            this.mtSales.Name = "mtSales";
            this.mtSales.Size = new System.Drawing.Size(144, 92);
            this.mtSales.TabIndex = 7;
            this.mtSales.Text = DataHolder.GetString("sales");
            this.mtSales.UseSelectable = true;
            this.mtSales.Click += new System.EventHandler(this.mtSales_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(869, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(226, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = DataHolder.GetString("logged_as_current_user");
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink1.Location = new System.Drawing.Point(1101, 23);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(67, 23);
            this.metroLink1.TabIndex = 14;
            this.metroLink1.Text = DataHolder.GetString("logout");
            this.metroLink1.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(931, 42);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(237, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = DataHolder.GetString("connected_to_server");
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(1017, 61);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(146, 19);
            this.labelTime.TabIndex = 16;
            this.labelTime.Text = "24 xxxxx 2017 33;33;44";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 710);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.mtAdmin);
            this.Controls.Add(this.mtWerehouse);
            this.Controls.Add(this.mtContacts);
            this.Controls.Add(this.mtOrders);
            this.Controls.Add(this.mtSales);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mpContainer);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile mtAdmin;
        private MetroFramework.Controls.MetroTile mtWerehouse;
        private MetroFramework.Controls.MetroTile mtContacts;
        private MetroFramework.Controls.MetroTile mtOrders;
        private MetroFramework.Controls.MetroTile mtSales;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel labelTime;
        private System.Windows.Forms.Timer timerClock;
    }
}