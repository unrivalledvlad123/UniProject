using Common.Forms.Base;

namespace DB3Client.Controls
{
    partial class OrdersControl
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
            this.tabControlOrders = new MetroFramework.Controls.MetroTabControl();
            this.btnAddGoodOrders = new Common.Forms.Base.MLTabPage();
            this.tbAmountOrders = new Common.Forms.Base.MLTextBox();
            this.btnSaveItemOrders = new Common.Forms.Base.MLButton();
            this.btnDeleteOrders = new Common.Forms.Base.MLButton();
            this.btnAddItemsOrders = new Common.Forms.Base.MLButton();
            this.dgvPurchase = new MetroFramework.Controls.MetroGrid();
            this.gbItemOrder = new Common.Forms.Base.MLGroupBox();
            this.cbSearchItemNameCode = new Common.Forms.Base.MLComboBox();
            this.search_item_order = new Common.Forms.Base.MLLabel();
            this.mlGroupBox2 = new Common.Forms.Base.MLGroupBox();
            this.tbWarehouseReceiptOrders = new Common.Forms.Base.MLTextBox();
            this.mlLabel5 = new Common.Forms.Base.MLLabel();
            this.tbInvoiceNumberOrders = new Common.Forms.Base.MLTextBox();
            this.invoice_order = new Common.Forms.Base.MLLabel();
            this.dtDatePurchase = new MetroFramework.Controls.MetroDateTime();
            this.purchase_date = new Common.Forms.Base.MLLabel();
            this.mlGroupBox1 = new Common.Forms.Base.MLGroupBox();
            this.btnAddParthners = new Common.Forms.Base.MLButton();
            this.lbBulstatHidden = new Common.Forms.Base.MLLabel();
            this.lbVatHidden = new Common.Forms.Base.MLLabel();
            this.lbMolHidden = new Common.Forms.Base.MLLabel();
            this.lbAddressHidden = new Common.Forms.Base.MLLabel();
            this.companyNameHidden = new Common.Forms.Base.MLLabel();
            this.search_info_order = new Common.Forms.Base.MLLabel();
            this.metroTabPage2 = new Common.Forms.Base.MLTabPage();
            this.metroTabPage3 = new Common.Forms.Base.MLTabPage();
            this.metroTabPage4 = new Common.Forms.Base.MLTabPage();
            this.cbSearchGoodsOrders = new System.Windows.Forms.ComboBox();
            this.cbSearchOrders = new System.Windows.Forms.ComboBox();
            this.tabControlOrders.SuspendLayout();
            this.btnAddGoodOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            this.gbItemOrder.SuspendLayout();
            this.mlGroupBox2.SuspendLayout();
            this.mlGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOrders
            // 
            this.tabControlOrders.Controls.Add(this.btnAddGoodOrders);
            this.tabControlOrders.Controls.Add(this.metroTabPage2);
            this.tabControlOrders.Controls.Add(this.metroTabPage3);
            this.tabControlOrders.Controls.Add(this.metroTabPage4);
            this.tabControlOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOrders.Location = new System.Drawing.Point(0, 0);
            this.tabControlOrders.Name = "tabControlOrders";
            this.tabControlOrders.SelectedIndex = 0;
            this.tabControlOrders.Size = new System.Drawing.Size(1072, 541);
            this.tabControlOrders.TabIndex = 0;
            this.tabControlOrders.UseSelectable = true;
            // 
            // btnAddGoodOrders
            // 
            this.btnAddGoodOrders.Controls.Add(this.cbSearchGoodsOrders);
            this.btnAddGoodOrders.Controls.Add(this.tbAmountOrders);
            this.btnAddGoodOrders.Controls.Add(this.btnSaveItemOrders);
            this.btnAddGoodOrders.Controls.Add(this.btnDeleteOrders);
            this.btnAddGoodOrders.Controls.Add(this.btnAddItemsOrders);
            this.btnAddGoodOrders.Controls.Add(this.dgvPurchase);
            this.btnAddGoodOrders.Controls.Add(this.gbItemOrder);
            this.btnAddGoodOrders.Controls.Add(this.mlGroupBox2);
            this.btnAddGoodOrders.Controls.Add(this.mlGroupBox1);
            this.btnAddGoodOrders.HorizontalScrollbarBarColor = true;
            this.btnAddGoodOrders.HorizontalScrollbarHighlightOnWheel = false;
            this.btnAddGoodOrders.HorizontalScrollbarSize = 10;
            this.btnAddGoodOrders.Location = new System.Drawing.Point(4, 38);
            this.btnAddGoodOrders.Name = "btnAddGoodOrders";
            this.btnAddGoodOrders.Size = new System.Drawing.Size(1064, 499);
            this.btnAddGoodOrders.TabIndex = 0;
            this.btnAddGoodOrders.Text = "add";
            this.btnAddGoodOrders.VerticalScrollbarBarColor = true;
            this.btnAddGoodOrders.VerticalScrollbarHighlightOnWheel = false;
            this.btnAddGoodOrders.VerticalScrollbarSize = 10;
            // 
            // tbAmountOrders
            // 
            // 
            // 
            // 
            this.tbAmountOrders.CustomButton.Image = null;
            this.tbAmountOrders.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.tbAmountOrders.CustomButton.Name = "";
            this.tbAmountOrders.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbAmountOrders.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAmountOrders.CustomButton.TabIndex = 1;
            this.tbAmountOrders.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAmountOrders.CustomButton.UseSelectable = true;
            this.tbAmountOrders.CustomButton.Visible = false;
            this.tbAmountOrders.Lines = new string[0];
            this.tbAmountOrders.Location = new System.Drawing.Point(651, 237);
            this.tbAmountOrders.MaxLength = 32767;
            this.tbAmountOrders.Name = "tbAmountOrders";
            this.tbAmountOrders.PasswordChar = '\0';
            this.tbAmountOrders.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAmountOrders.SelectedText = "";
            this.tbAmountOrders.SelectionLength = 0;
            this.tbAmountOrders.SelectionStart = 0;
            this.tbAmountOrders.ShortcutsEnabled = true;
            this.tbAmountOrders.Size = new System.Drawing.Size(159, 29);
            this.tbAmountOrders.TabIndex = 10;
            this.tbAmountOrders.UseSelectable = true;
            this.tbAmountOrders.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAmountOrders.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSaveItemOrders
            // 
            this.btnSaveItemOrders.Location = new System.Drawing.Point(978, 237);
            this.btnSaveItemOrders.Name = "btnSaveItemOrders";
            this.btnSaveItemOrders.Size = new System.Drawing.Size(75, 29);
            this.btnSaveItemOrders.TabIndex = 9;
            this.btnSaveItemOrders.Text = "save";
            this.btnSaveItemOrders.UseSelectable = true;
            // 
            // btnDeleteOrders
            // 
            this.btnDeleteOrders.Location = new System.Drawing.Point(897, 237);
            this.btnDeleteOrders.Name = "btnDeleteOrders";
            this.btnDeleteOrders.Size = new System.Drawing.Size(75, 29);
            this.btnDeleteOrders.TabIndex = 8;
            this.btnDeleteOrders.Text = "delete";
            this.btnDeleteOrders.UseSelectable = true;
            // 
            // btnAddItemsOrders
            // 
            this.btnAddItemsOrders.Location = new System.Drawing.Point(816, 237);
            this.btnAddItemsOrders.Name = "btnAddItemsOrders";
            this.btnAddItemsOrders.Size = new System.Drawing.Size(75, 29);
            this.btnAddItemsOrders.TabIndex = 7;
            this.btnAddItemsOrders.Text = "add";
            this.btnAddItemsOrders.UseSelectable = true;
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.AllowUserToResizeRows = false;
            this.dgvPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPurchase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPurchase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPurchase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchase.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchase.EnableHeadersVisualStyles = false;
            this.dgvPurchase.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPurchase.GridColor = System.Drawing.Color.White;
            this.dgvPurchase.Location = new System.Drawing.Point(3, 274);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchase.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPurchase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchase.Size = new System.Drawing.Size(1050, 226);
            this.dgvPurchase.TabIndex = 5;
            // 
            // gbItemOrder
            // 
            this.gbItemOrder.BackColor = System.Drawing.Color.White;
            this.gbItemOrder.Controls.Add(this.cbSearchItemNameCode);
            this.gbItemOrder.Controls.Add(this.search_item_order);
            this.gbItemOrder.Location = new System.Drawing.Point(645, 4);
            this.gbItemOrder.Name = "gbItemOrder";
            this.gbItemOrder.Size = new System.Drawing.Size(408, 228);
            this.gbItemOrder.TabIndex = 4;
            this.gbItemOrder.TabStop = false;
            this.gbItemOrder.Text = "item_info_order";
            // 
            // cbSearchItemNameCode
            // 
            this.cbSearchItemNameCode.FormattingEnabled = true;
            this.cbSearchItemNameCode.ItemHeight = 23;
            this.cbSearchItemNameCode.Location = new System.Drawing.Point(6, 38);
            this.cbSearchItemNameCode.Name = "cbSearchItemNameCode";
            this.cbSearchItemNameCode.Size = new System.Drawing.Size(228, 29);
            this.cbSearchItemNameCode.TabIndex = 1;
            this.cbSearchItemNameCode.UseSelectable = true;
            // 
            // search_item_order
            // 
            this.search_item_order.AutoSize = true;
            this.search_item_order.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.search_item_order.Location = new System.Drawing.Point(6, 16);
            this.search_item_order.Name = "search_item_order";
            this.search_item_order.Size = new System.Drawing.Size(120, 19);
            this.search_item_order.TabIndex = 0;
            this.search_item_order.Text = "search_item_order";
            // 
            // mlGroupBox2
            // 
            this.mlGroupBox2.BackColor = System.Drawing.Color.White;
            this.mlGroupBox2.Controls.Add(this.tbWarehouseReceiptOrders);
            this.mlGroupBox2.Controls.Add(this.mlLabel5);
            this.mlGroupBox2.Controls.Add(this.tbInvoiceNumberOrders);
            this.mlGroupBox2.Controls.Add(this.invoice_order);
            this.mlGroupBox2.Controls.Add(this.dtDatePurchase);
            this.mlGroupBox2.Controls.Add(this.purchase_date);
            this.mlGroupBox2.Location = new System.Drawing.Point(322, 4);
            this.mlGroupBox2.Name = "mlGroupBox2";
            this.mlGroupBox2.Size = new System.Drawing.Size(317, 228);
            this.mlGroupBox2.TabIndex = 3;
            this.mlGroupBox2.TabStop = false;
            this.mlGroupBox2.Text = "purchase_data_order";
            // 
            // tbWarehouseReceiptOrders
            // 
            // 
            // 
            // 
            this.tbWarehouseReceiptOrders.CustomButton.Image = null;
            this.tbWarehouseReceiptOrders.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.tbWarehouseReceiptOrders.CustomButton.Name = "";
            this.tbWarehouseReceiptOrders.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbWarehouseReceiptOrders.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbWarehouseReceiptOrders.CustomButton.TabIndex = 1;
            this.tbWarehouseReceiptOrders.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbWarehouseReceiptOrders.CustomButton.UseSelectable = true;
            this.tbWarehouseReceiptOrders.CustomButton.Visible = false;
            this.tbWarehouseReceiptOrders.Lines = new string[0];
            this.tbWarehouseReceiptOrders.Location = new System.Drawing.Point(7, 137);
            this.tbWarehouseReceiptOrders.MaxLength = 32767;
            this.tbWarehouseReceiptOrders.Name = "tbWarehouseReceiptOrders";
            this.tbWarehouseReceiptOrders.PasswordChar = '\0';
            this.tbWarehouseReceiptOrders.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbWarehouseReceiptOrders.SelectedText = "";
            this.tbWarehouseReceiptOrders.SelectionLength = 0;
            this.tbWarehouseReceiptOrders.SelectionStart = 0;
            this.tbWarehouseReceiptOrders.ShortcutsEnabled = true;
            this.tbWarehouseReceiptOrders.Size = new System.Drawing.Size(255, 23);
            this.tbWarehouseReceiptOrders.TabIndex = 5;
            this.tbWarehouseReceiptOrders.UseSelectable = true;
            this.tbWarehouseReceiptOrders.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbWarehouseReceiptOrders.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlLabel5
            // 
            this.mlLabel5.AutoSize = true;
            this.mlLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel5.Location = new System.Drawing.Point(7, 115);
            this.mlLabel5.Name = "mlLabel5";
            this.mlLabel5.Size = new System.Drawing.Size(161, 19);
            this.mlLabel5.TabIndex = 4;
            this.mlLabel5.Text = "warehouse_recepit_order";
            // 
            // tbInvoiceNumberOrders
            // 
            // 
            // 
            // 
            this.tbInvoiceNumberOrders.CustomButton.Image = null;
            this.tbInvoiceNumberOrders.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.tbInvoiceNumberOrders.CustomButton.Name = "";
            this.tbInvoiceNumberOrders.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbInvoiceNumberOrders.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbInvoiceNumberOrders.CustomButton.TabIndex = 1;
            this.tbInvoiceNumberOrders.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbInvoiceNumberOrders.CustomButton.UseSelectable = true;
            this.tbInvoiceNumberOrders.CustomButton.Visible = false;
            this.tbInvoiceNumberOrders.Lines = new string[0];
            this.tbInvoiceNumberOrders.Location = new System.Drawing.Point(7, 89);
            this.tbInvoiceNumberOrders.MaxLength = 32767;
            this.tbInvoiceNumberOrders.Name = "tbInvoiceNumberOrders";
            this.tbInvoiceNumberOrders.PasswordChar = '\0';
            this.tbInvoiceNumberOrders.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbInvoiceNumberOrders.SelectedText = "";
            this.tbInvoiceNumberOrders.SelectionLength = 0;
            this.tbInvoiceNumberOrders.SelectionStart = 0;
            this.tbInvoiceNumberOrders.ShortcutsEnabled = true;
            this.tbInvoiceNumberOrders.Size = new System.Drawing.Size(255, 23);
            this.tbInvoiceNumberOrders.TabIndex = 3;
            this.tbInvoiceNumberOrders.UseSelectable = true;
            this.tbInvoiceNumberOrders.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbInvoiceNumberOrders.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // invoice_order
            // 
            this.invoice_order.AutoSize = true;
            this.invoice_order.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.invoice_order.Location = new System.Drawing.Point(7, 70);
            this.invoice_order.Name = "invoice_order";
            this.invoice_order.Size = new System.Drawing.Size(90, 19);
            this.invoice_order.TabIndex = 2;
            this.invoice_order.Text = "invoice_order";
            // 
            // dtDatePurchase
            // 
            this.dtDatePurchase.Location = new System.Drawing.Point(7, 38);
            this.dtDatePurchase.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDatePurchase.Name = "dtDatePurchase";
            this.dtDatePurchase.Size = new System.Drawing.Size(255, 29);
            this.dtDatePurchase.TabIndex = 1;
            // 
            // purchase_date
            // 
            this.purchase_date.AutoSize = true;
            this.purchase_date.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.purchase_date.Location = new System.Drawing.Point(6, 16);
            this.purchase_date.Name = "purchase_date";
            this.purchase_date.Size = new System.Drawing.Size(144, 19);
            this.purchase_date.TabIndex = 0;
            this.purchase_date.Text = "purchased_date_order";
            // 
            // mlGroupBox1
            // 
            this.mlGroupBox1.BackColor = System.Drawing.Color.White;
            this.mlGroupBox1.Controls.Add(this.cbSearchOrders);
            this.mlGroupBox1.Controls.Add(this.btnAddParthners);
            this.mlGroupBox1.Controls.Add(this.lbBulstatHidden);
            this.mlGroupBox1.Controls.Add(this.lbVatHidden);
            this.mlGroupBox1.Controls.Add(this.lbMolHidden);
            this.mlGroupBox1.Controls.Add(this.lbAddressHidden);
            this.mlGroupBox1.Controls.Add(this.companyNameHidden);
            this.mlGroupBox1.Controls.Add(this.search_info_order);
            this.mlGroupBox1.Location = new System.Drawing.Point(4, 4);
            this.mlGroupBox1.Name = "mlGroupBox1";
            this.mlGroupBox1.Size = new System.Drawing.Size(312, 228);
            this.mlGroupBox1.TabIndex = 2;
            this.mlGroupBox1.TabStop = false;
            this.mlGroupBox1.Text = "purchase_info";
            // 
            // btnAddParthners
            // 
            this.btnAddParthners.Location = new System.Drawing.Point(231, 38);
            this.btnAddParthners.Name = "btnAddParthners";
            this.btnAddParthners.Size = new System.Drawing.Size(75, 29);
            this.btnAddParthners.TabIndex = 8;
            this.btnAddParthners.Text = "add_parthners";
            this.btnAddParthners.UseSelectable = true;
            this.btnAddParthners.Click += new System.EventHandler(this.btnAddParthners_Click);
            // 
            // lbBulstatHidden
            // 
            this.lbBulstatHidden.AutoSize = true;
            this.lbBulstatHidden.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbBulstatHidden.Location = new System.Drawing.Point(7, 146);
            this.lbBulstatHidden.Name = "lbBulstatHidden";
            this.lbBulstatHidden.Size = new System.Drawing.Size(15, 19);
            this.lbBulstatHidden.TabIndex = 7;
            this.lbBulstatHidden.Text = "-";
            // 
            // lbVatHidden
            // 
            this.lbVatHidden.AutoSize = true;
            this.lbVatHidden.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbVatHidden.Location = new System.Drawing.Point(6, 127);
            this.lbVatHidden.Name = "lbVatHidden";
            this.lbVatHidden.Size = new System.Drawing.Size(15, 19);
            this.lbVatHidden.TabIndex = 6;
            this.lbVatHidden.Text = "-";
            // 
            // lbMolHidden
            // 
            this.lbMolHidden.AutoSize = true;
            this.lbMolHidden.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbMolHidden.Location = new System.Drawing.Point(6, 108);
            this.lbMolHidden.Name = "lbMolHidden";
            this.lbMolHidden.Size = new System.Drawing.Size(15, 19);
            this.lbMolHidden.TabIndex = 4;
            this.lbMolHidden.Text = "-";
            // 
            // lbAddressHidden
            // 
            this.lbAddressHidden.AutoSize = true;
            this.lbAddressHidden.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbAddressHidden.Location = new System.Drawing.Point(6, 89);
            this.lbAddressHidden.Name = "lbAddressHidden";
            this.lbAddressHidden.Size = new System.Drawing.Size(15, 19);
            this.lbAddressHidden.TabIndex = 3;
            this.lbAddressHidden.Text = "-";
            // 
            // companyNameHidden
            // 
            this.companyNameHidden.AutoSize = true;
            this.companyNameHidden.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.companyNameHidden.Location = new System.Drawing.Point(7, 70);
            this.companyNameHidden.Name = "companyNameHidden";
            this.companyNameHidden.Size = new System.Drawing.Size(15, 19);
            this.companyNameHidden.TabIndex = 2;
            this.companyNameHidden.Text = "-";
            this.companyNameHidden.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // search_info_order
            // 
            this.search_info_order.AutoSize = true;
            this.search_info_order.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.search_info_order.Location = new System.Drawing.Point(6, 16);
            this.search_info_order.Name = "search_info_order";
            this.search_info_order.Size = new System.Drawing.Size(116, 19);
            this.search_info_order.TabIndex = 0;
            this.search_info_order.Text = "search_info_order";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1064, 499);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage1";
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
            this.metroTabPage3.Size = new System.Drawing.Size(1064, 499);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "metroTabPage3";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1064, 499);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "metroTabPage4";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // cbSearchGoodsOrders
            // 
            this.cbSearchGoodsOrders.FormattingEnabled = true;
            this.cbSearchGoodsOrders.Location = new System.Drawing.Point(11, 239);
            this.cbSearchGoodsOrders.Name = "cbSearchGoodsOrders";
            this.cbSearchGoodsOrders.Size = new System.Drawing.Size(628, 21);
            this.cbSearchGoodsOrders.TabIndex = 11;
            // 
            // cbSearchOrders
            // 
            this.cbSearchOrders.FormattingEnabled = true;
            this.cbSearchOrders.Location = new System.Drawing.Point(7, 38);
            this.cbSearchOrders.Name = "cbSearchOrders";
            this.cbSearchOrders.Size = new System.Drawing.Size(218, 21);
            this.cbSearchOrders.TabIndex = 9;
            // 
            // OrdersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlOrders);
            this.Name = "OrdersControl";
            this.Size = new System.Drawing.Size(1072, 541);
            this.tabControlOrders.ResumeLayout(false);
            this.btnAddGoodOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            this.gbItemOrder.ResumeLayout(false);
            this.gbItemOrder.PerformLayout();
            this.mlGroupBox2.ResumeLayout(false);
            this.mlGroupBox2.PerformLayout();
            this.mlGroupBox1.ResumeLayout(false);
            this.mlGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControlOrders;
        private MLTabPage btnAddGoodOrders;
        private MLTabPage metroTabPage2;
        private MLTabPage metroTabPage3;
        private MLTabPage metroTabPage4;
        private MLGroupBox mlGroupBox1;
        private MLLabel search_info_order;
        private MLLabel companyNameHidden;
        private MLLabel lbAddressHidden;
        private MLLabel lbMolHidden;
        private MLLabel lbVatHidden;
        private MLLabel lbBulstatHidden;
        private MLGroupBox mlGroupBox2;
        private MLLabel purchase_date;
        private MetroFramework.Controls.MetroDateTime dtDatePurchase;
        private MLLabel invoice_order;
        private MLTextBox tbInvoiceNumberOrders;
        private MLLabel mlLabel5;
        private MLTextBox tbWarehouseReceiptOrders;
        private MLGroupBox gbItemOrder;
        private MLLabel search_item_order;
        private MLComboBox cbSearchItemNameCode;
        private MetroFramework.Controls.MetroGrid dgvPurchase;
        private MLButton btnAddItemsOrders;
        private MLButton btnAddParthners;
        private MLButton btnDeleteOrders;
        private MLButton btnSaveItemOrders;
        private MLTextBox tbAmountOrders;
        private System.Windows.Forms.ComboBox cbSearchGoodsOrders;
        private System.Windows.Forms.ComboBox cbSearchOrders;
    }
}
