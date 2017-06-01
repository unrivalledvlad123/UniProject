using Common.Forms.Base;

namespace DB3Client.Controls
{
    partial class SalesControl
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
            this.tabControlSales = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new Common.Forms.Base.MLTabPage();
            this.gbClientInfo = new Common.Forms.Base.MLGroupBox();
            this.btnAddContractS = new Common.Forms.Base.MLButton();
            this.btnGenerateInvoice = new Common.Forms.Base.MLButton();
            this.mlGroupBox7 = new Common.Forms.Base.MLGroupBox();
            this.mlLabel16 = new Common.Forms.Base.MLLabel();
            this.mlLabel13 = new Common.Forms.Base.MLLabel();
            this.mlLabel11 = new Common.Forms.Base.MLLabel();
            this.mlLabel12 = new Common.Forms.Base.MLLabel();
            this.mlLabel14 = new Common.Forms.Base.MLLabel();
            this.mlGroupBox6 = new Common.Forms.Base.MLGroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbSearchContract = new System.Windows.Forms.ComboBox();
            this.mlLabel10 = new Common.Forms.Base.MLLabel();
            this.mlGroupBox1 = new Common.Forms.Base.MLGroupBox();
            this.mlGroupBox8 = new Common.Forms.Base.MLGroupBox();
            this.errorLabel = new Common.Forms.Base.MLErrorLabel();
            this.btnDetach = new Common.Forms.Base.MLButton();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnDelete = new Common.Forms.Base.MLButton();
            this.mlGroupBox3 = new Common.Forms.Base.MLGroupBox();
            this.mlLabel3 = new Common.Forms.Base.MLLabel();
            this.mlLabel2 = new Common.Forms.Base.MLLabel();
            this.mlLabel1 = new Common.Forms.Base.MLLabel();
            this.mlLabel7 = new Common.Forms.Base.MLLabel();
            this.tbQuantity = new Common.Forms.Base.MLTextBox();
            this.mlLabel8 = new Common.Forms.Base.MLLabel();
            this.btnAdd = new Common.Forms.Base.MLButton();
            this.mlGroupBox4 = new Common.Forms.Base.MLGroupBox();
            this.labelChange = new Common.Forms.Base.MLLabel();
            this.labelCash = new Common.Forms.Base.MLLabel();
            this.labelTotalAmount = new Common.Forms.Base.MLLabel();
            this.mlLabel6 = new Common.Forms.Base.MLLabel();
            this.mlLabel5 = new Common.Forms.Base.MLLabel();
            this.mlLabel4 = new Common.Forms.Base.MLLabel();
            this.btnFinish = new Common.Forms.Base.MLButton();
            this.tbAmount = new Common.Forms.Base.MLTextBox();
            this.mlLabel9 = new Common.Forms.Base.MLLabel();
            this.cbWholesale = new Common.Forms.Base.MLCheckBox();
            this.dgvSoldGoods = new MetroFramework.Controls.MetroGrid();
            this.tabControlSales.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.gbClientInfo.SuspendLayout();
            this.mlGroupBox7.SuspendLayout();
            this.mlGroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mlGroupBox1.SuspendLayout();
            this.mlGroupBox8.SuspendLayout();
            this.mlGroupBox3.SuspendLayout();
            this.mlGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSales
            // 
            this.tabControlSales.Controls.Add(this.metroTabPage1);
            this.tabControlSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSales.Location = new System.Drawing.Point(0, 0);
            this.tabControlSales.Name = "tabControlSales";
            this.tabControlSales.SelectedIndex = 0;
            this.tabControlSales.Size = new System.Drawing.Size(1348, 540);
            this.tabControlSales.TabIndex = 0;
            this.tabControlSales.TabStop = false;
            this.tabControlSales.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.AutoScroll = true;
            this.metroTabPage1.Controls.Add(this.gbClientInfo);
            this.metroTabPage1.Controls.Add(this.mlGroupBox1);
            this.metroTabPage1.Controls.Add(this.dgvSoldGoods);
            this.metroTabPage1.HorizontalScrollbar = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = true;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1340, 498);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "tab_page_direct_sales";
            this.metroTabPage1.VerticalScrollbar = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // gbClientInfo
            // 
            this.gbClientInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbClientInfo.Controls.Add(this.btnAddContractS);
            this.gbClientInfo.Controls.Add(this.btnGenerateInvoice);
            this.gbClientInfo.Controls.Add(this.mlGroupBox7);
            this.gbClientInfo.Controls.Add(this.mlGroupBox6);
            this.gbClientInfo.Location = new System.Drawing.Point(3, 269);
            this.gbClientInfo.Name = "gbClientInfo";
            this.gbClientInfo.Size = new System.Drawing.Size(528, 293);
            this.gbClientInfo.TabIndex = 5;
            this.gbClientInfo.TabStop = false;
            this.gbClientInfo.Text = "client_info";
            this.gbClientInfo.Enter += new System.EventHandler(this.gbClientInfo_Enter);
            // 
            // btnAddContractS
            // 
            this.btnAddContractS.Location = new System.Drawing.Point(13, 264);
            this.btnAddContractS.Name = "btnAddContractS";
            this.btnAddContractS.Size = new System.Drawing.Size(240, 22);
            this.btnAddContractS.TabIndex = 8;
            this.btnAddContractS.Text = "add_contract";
            this.btnAddContractS.UseSelectable = true;
            this.btnAddContractS.Click += new System.EventHandler(this.btnAddContractS_Click);
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.Location = new System.Drawing.Point(271, 263);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(251, 23);
            this.btnGenerateInvoice.TabIndex = 7;
            this.btnGenerateInvoice.Text = "generate_invoice";
            this.btnGenerateInvoice.UseSelectable = true;
            this.btnGenerateInvoice.Click += new System.EventHandler(this.btnGenerateInvoice_Click);
            // 
            // mlGroupBox7
            // 
            this.mlGroupBox7.BackColor = System.Drawing.Color.White;
            this.mlGroupBox7.Controls.Add(this.mlLabel16);
            this.mlGroupBox7.Controls.Add(this.mlLabel13);
            this.mlGroupBox7.Controls.Add(this.mlLabel11);
            this.mlGroupBox7.Controls.Add(this.mlLabel12);
            this.mlGroupBox7.Controls.Add(this.mlLabel14);
            this.mlGroupBox7.Location = new System.Drawing.Point(265, 16);
            this.mlGroupBox7.Name = "mlGroupBox7";
            this.mlGroupBox7.Size = new System.Drawing.Size(257, 242);
            this.mlGroupBox7.TabIndex = 1;
            this.mlGroupBox7.TabStop = false;
            // 
            // mlLabel16
            // 
            this.mlLabel16.AutoSize = true;
            this.mlLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel16.Location = new System.Drawing.Point(6, 139);
            this.mlLabel16.Name = "mlLabel16";
            this.mlLabel16.Size = new System.Drawing.Size(15, 19);
            this.mlLabel16.TabIndex = 4;
            this.mlLabel16.Text = "-";
            // 
            // mlLabel13
            // 
            this.mlLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel13.Location = new System.Drawing.Point(6, 109);
            this.mlLabel13.Name = "mlLabel13";
            this.mlLabel13.Size = new System.Drawing.Size(245, 23);
            this.mlLabel13.TabIndex = 3;
            this.mlLabel13.Text = "-";
            // 
            // mlLabel11
            // 
            this.mlLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel11.Location = new System.Drawing.Point(6, 13);
            this.mlLabel11.Name = "mlLabel11";
            this.mlLabel11.Size = new System.Drawing.Size(245, 23);
            this.mlLabel11.TabIndex = 0;
            this.mlLabel11.Text = "-";
            // 
            // mlLabel12
            // 
            this.mlLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel12.Location = new System.Drawing.Point(6, 45);
            this.mlLabel12.Name = "mlLabel12";
            this.mlLabel12.Size = new System.Drawing.Size(245, 23);
            this.mlLabel12.TabIndex = 1;
            this.mlLabel12.Text = "-";
            // 
            // mlLabel14
            // 
            this.mlLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel14.Location = new System.Drawing.Point(6, 77);
            this.mlLabel14.Name = "mlLabel14";
            this.mlLabel14.Size = new System.Drawing.Size(245, 23);
            this.mlLabel14.TabIndex = 2;
            this.mlLabel14.Text = "-";
            // 
            // mlGroupBox6
            // 
            this.mlGroupBox6.BackColor = System.Drawing.Color.White;
            this.mlGroupBox6.Controls.Add(this.pictureBox1);
            this.mlGroupBox6.Controls.Add(this.cbSearchContract);
            this.mlGroupBox6.Controls.Add(this.mlLabel10);
            this.mlGroupBox6.Location = new System.Drawing.Point(6, 16);
            this.mlGroupBox6.Name = "mlGroupBox6";
            this.mlGroupBox6.Size = new System.Drawing.Size(253, 242);
            this.mlGroupBox6.TabIndex = 0;
            this.mlGroupBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DB3Client.Resource.invoice;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 170);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // cbSearchContract
            // 
            this.cbSearchContract.FormattingEnabled = true;
            this.cbSearchContract.Location = new System.Drawing.Point(7, 35);
            this.cbSearchContract.Name = "cbSearchContract";
            this.cbSearchContract.Size = new System.Drawing.Size(240, 21);
            this.cbSearchContract.TabIndex = 9;
            this.cbSearchContract.SelectionChangeCommitted += new System.EventHandler(this.cbSearchContract_SelectionChangeCommitted);
            // 
            // mlLabel10
            // 
            this.mlLabel10.AutoSize = true;
            this.mlLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel10.Location = new System.Drawing.Point(6, 13);
            this.mlLabel10.Name = "mlLabel10";
            this.mlLabel10.Size = new System.Drawing.Size(150, 19);
            this.mlLabel10.TabIndex = 1;
            this.mlLabel10.Text = "search_company_name";
            // 
            // mlGroupBox1
            // 
            this.mlGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.mlGroupBox1.Controls.Add(this.mlGroupBox8);
            this.mlGroupBox1.Controls.Add(this.mlGroupBox4);
            this.mlGroupBox1.Controls.Add(this.btnFinish);
            this.mlGroupBox1.Controls.Add(this.tbAmount);
            this.mlGroupBox1.Controls.Add(this.mlLabel9);
            this.mlGroupBox1.Controls.Add(this.cbWholesale);
            this.mlGroupBox1.Location = new System.Drawing.Point(4, 4);
            this.mlGroupBox1.Name = "mlGroupBox1";
            this.mlGroupBox1.Size = new System.Drawing.Size(525, 259);
            this.mlGroupBox1.TabIndex = 3;
            this.mlGroupBox1.TabStop = false;
            this.mlGroupBox1.Text = "product_info";
            // 
            // mlGroupBox8
            // 
            this.mlGroupBox8.BackColor = System.Drawing.Color.White;
            this.mlGroupBox8.Controls.Add(this.errorLabel);
            this.mlGroupBox8.Controls.Add(this.btnDetach);
            this.mlGroupBox8.Controls.Add(this.cbSearch);
            this.mlGroupBox8.Controls.Add(this.btnDelete);
            this.mlGroupBox8.Controls.Add(this.mlGroupBox3);
            this.mlGroupBox8.Controls.Add(this.mlLabel7);
            this.mlGroupBox8.Controls.Add(this.tbQuantity);
            this.mlGroupBox8.Controls.Add(this.mlLabel8);
            this.mlGroupBox8.Controls.Add(this.btnAdd);
            this.mlGroupBox8.Location = new System.Drawing.Point(6, 13);
            this.mlGroupBox8.Name = "mlGroupBox8";
            this.mlGroupBox8.Size = new System.Drawing.Size(333, 207);
            this.mlGroupBox8.TabIndex = 9;
            this.mlGroupBox8.TabStop = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(6, 203);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 12;
            // 
            // btnDetach
            // 
            this.btnDetach.Location = new System.Drawing.Point(183, 173);
            this.btnDetach.Name = "btnDetach";
            this.btnDetach.Size = new System.Drawing.Size(144, 23);
            this.btnDetach.TabIndex = 2;
            this.btnDetach.Text = "att_detach";
            this.btnDetach.UseSelectable = true;
            this.btnDetach.Click += new System.EventHandler(this.btnDetach_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(6, 38);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(321, 21);
            this.cbSearch.TabIndex = 11;
            this.cbSearch.SelectionChangeCommitted += new System.EventHandler(this.cbSearch_SelectionChangeCommitted);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(183, 144);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mlGroupBox3
            // 
            this.mlGroupBox3.BackColor = System.Drawing.Color.White;
            this.mlGroupBox3.Controls.Add(this.mlLabel3);
            this.mlGroupBox3.Controls.Add(this.mlLabel2);
            this.mlGroupBox3.Controls.Add(this.mlLabel1);
            this.mlGroupBox3.Location = new System.Drawing.Point(4, 64);
            this.mlGroupBox3.Name = "mlGroupBox3";
            this.mlGroupBox3.Size = new System.Drawing.Size(172, 132);
            this.mlGroupBox3.TabIndex = 0;
            this.mlGroupBox3.TabStop = false;
            // 
            // mlLabel3
            // 
            this.mlLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel3.Location = new System.Drawing.Point(7, 80);
            this.mlLabel3.Name = "mlLabel3";
            this.mlLabel3.Size = new System.Drawing.Size(146, 45);
            this.mlLabel3.TabIndex = 2;
            this.mlLabel3.Text = "-";
            // 
            // mlLabel2
            // 
            this.mlLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel2.Location = new System.Drawing.Point(7, 51);
            this.mlLabel2.Name = "mlLabel2";
            this.mlLabel2.Size = new System.Drawing.Size(146, 38);
            this.mlLabel2.TabIndex = 1;
            this.mlLabel2.Text = "-";
            // 
            // mlLabel1
            // 
            this.mlLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel1.Location = new System.Drawing.Point(7, 13);
            this.mlLabel1.Name = "mlLabel1";
            this.mlLabel1.Size = new System.Drawing.Size(146, 38);
            this.mlLabel1.TabIndex = 0;
            this.mlLabel1.Text = "-";
            // 
            // mlLabel7
            // 
            this.mlLabel7.AutoSize = true;
            this.mlLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel7.Location = new System.Drawing.Point(4, 16);
            this.mlLabel7.Name = "mlLabel7";
            this.mlLabel7.Size = new System.Drawing.Size(77, 19);
            this.mlLabel7.TabIndex = 6;
            this.mlLabel7.Text = "search_info";
            // 
            // tbQuantity
            // 
            // 
            // 
            // 
            this.tbQuantity.CustomButton.Image = null;
            this.tbQuantity.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.tbQuantity.CustomButton.Name = "";
            this.tbQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbQuantity.CustomButton.TabIndex = 1;
            this.tbQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbQuantity.CustomButton.UseSelectable = true;
            this.tbQuantity.CustomButton.Visible = false;
            this.tbQuantity.Lines = new string[0];
            this.tbQuantity.Location = new System.Drawing.Point(182, 86);
            this.tbQuantity.MaxLength = 32767;
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.PasswordChar = '\0';
            this.tbQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbQuantity.SelectedText = "";
            this.tbQuantity.SelectionLength = 0;
            this.tbQuantity.SelectionStart = 0;
            this.tbQuantity.ShortcutsEnabled = true;
            this.tbQuantity.Size = new System.Drawing.Size(145, 23);
            this.tbQuantity.TabIndex = 1;
            this.tbQuantity.UseSelectable = true;
            this.tbQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantity_KeyPress);
            // 
            // mlLabel8
            // 
            this.mlLabel8.AutoSize = true;
            this.mlLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel8.Location = new System.Drawing.Point(182, 64);
            this.mlLabel8.Name = "mlLabel8";
            this.mlLabel8.Size = new System.Drawing.Size(60, 19);
            this.mlLabel8.TabIndex = 7;
            this.mlLabel8.Text = "quantity";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(183, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mlGroupBox4
            // 
            this.mlGroupBox4.BackColor = System.Drawing.Color.White;
            this.mlGroupBox4.Controls.Add(this.labelChange);
            this.mlGroupBox4.Controls.Add(this.labelCash);
            this.mlGroupBox4.Controls.Add(this.labelTotalAmount);
            this.mlGroupBox4.Controls.Add(this.mlLabel6);
            this.mlGroupBox4.Controls.Add(this.mlLabel5);
            this.mlGroupBox4.Controls.Add(this.mlLabel4);
            this.mlGroupBox4.Location = new System.Drawing.Point(345, 81);
            this.mlGroupBox4.Name = "mlGroupBox4";
            this.mlGroupBox4.Size = new System.Drawing.Size(174, 139);
            this.mlGroupBox4.TabIndex = 1;
            this.mlGroupBox4.TabStop = false;
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelChange.Location = new System.Drawing.Point(141, 89);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(17, 19);
            this.labelChange.TabIndex = 5;
            this.labelChange.Text = "0";
            // 
            // labelCash
            // 
            this.labelCash.AutoSize = true;
            this.labelCash.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelCash.Location = new System.Drawing.Point(141, 51);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(17, 19);
            this.labelCash.TabIndex = 4;
            this.labelCash.Text = "0";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelTotalAmount.Location = new System.Drawing.Point(141, 16);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(17, 19);
            this.labelTotalAmount.TabIndex = 3;
            this.labelTotalAmount.Text = "0";
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
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(264, 226);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(245, 23);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "finish";
            this.btnFinish.UseSelectable = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // tbAmount
            // 
            // 
            // 
            // 
            this.tbAmount.CustomButton.Image = null;
            this.tbAmount.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.tbAmount.CustomButton.Name = "";
            this.tbAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAmount.CustomButton.TabIndex = 1;
            this.tbAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAmount.CustomButton.UseSelectable = true;
            this.tbAmount.CustomButton.Visible = false;
            this.tbAmount.Lines = new string[0];
            this.tbAmount.Location = new System.Drawing.Point(345, 49);
            this.tbAmount.MaxLength = 32767;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.PasswordChar = '\0';
            this.tbAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAmount.SelectedText = "";
            this.tbAmount.SelectionLength = 0;
            this.tbAmount.SelectionStart = 0;
            this.tbAmount.ShortcutsEnabled = true;
            this.tbAmount.Size = new System.Drawing.Size(174, 23);
            this.tbAmount.TabIndex = 4;
            this.tbAmount.UseSelectable = true;
            this.tbAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAmount_KeyDown);
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress_1);
            // 
            // mlLabel9
            // 
            this.mlLabel9.AutoSize = true;
            this.mlLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel9.Location = new System.Drawing.Point(345, 27);
            this.mlLabel9.Name = "mlLabel9";
            this.mlLabel9.Size = new System.Drawing.Size(36, 19);
            this.mlLabel9.TabIndex = 8;
            this.mlLabel9.Text = "cash";
            // 
            // cbWholesale
            // 
            this.cbWholesale.AutoSize = true;
            this.cbWholesale.Location = new System.Drawing.Point(10, 232);
            this.cbWholesale.Name = "cbWholesale";
            this.cbWholesale.Size = new System.Drawing.Size(75, 15);
            this.cbWholesale.TabIndex = 9;
            this.cbWholesale.Text = "wholesale";
            this.cbWholesale.UseSelectable = true;
            this.cbWholesale.CheckedChanged += new System.EventHandler(this.cbWholesale_CheckedChanged);
            // 
            // dgvSoldGoods
            // 
            this.dgvSoldGoods.AllowUserToAddRows = false;
            this.dgvSoldGoods.AllowUserToResizeRows = false;
            this.dgvSoldGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSoldGoods.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSoldGoods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSoldGoods.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSoldGoods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoldGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSoldGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoldGoods.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSoldGoods.EnableHeadersVisualStyles = false;
            this.dgvSoldGoods.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSoldGoods.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSoldGoods.Location = new System.Drawing.Point(535, 4);
            this.dgvSoldGoods.Name = "dgvSoldGoods";
            this.dgvSoldGoods.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoldGoods.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSoldGoods.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSoldGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSoldGoods.Size = new System.Drawing.Size(785, 814);
            this.dgvSoldGoods.TabIndex = 2;
            this.dgvSoldGoods.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoldGoods_CellValueChanged);
            // 
            // SalesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlSales);
            this.Name = "SalesControl";
            this.Size = new System.Drawing.Size(1348, 540);
            this.tabControlSales.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.gbClientInfo.ResumeLayout(false);
            this.mlGroupBox7.ResumeLayout(false);
            this.mlGroupBox7.PerformLayout();
            this.mlGroupBox6.ResumeLayout(false);
            this.mlGroupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mlGroupBox1.ResumeLayout(false);
            this.mlGroupBox1.PerformLayout();
            this.mlGroupBox8.ResumeLayout(false);
            this.mlGroupBox8.PerformLayout();
            this.mlGroupBox3.ResumeLayout(false);
            this.mlGroupBox4.ResumeLayout(false);
            this.mlGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControlSales;
        private MLTabPage metroTabPage1;
        private MetroFramework.Controls.MetroGrid dgvSoldGoods;
        private MLGroupBox mlGroupBox4;
        private MLGroupBox mlGroupBox3;
        private MLGroupBox mlGroupBox1;
        private MLButton btnDetach;
        private MLButton btnFinish;
        private MLTextBox tbAmount;
        private MLButton btnDelete;
        private MLButton btnAdd;
        private MLTextBox tbQuantity;
        private MLLabel mlLabel6;
        private MLLabel mlLabel5;
        private MLLabel mlLabel4;
        private MLLabel mlLabel3;
        private MLLabel mlLabel2;
        private MLLabel mlLabel1;
        private MLLabel labelChange;
        private MLLabel labelCash;
        private MLLabel labelTotalAmount;
        private MLLabel mlLabel7;
        private MLLabel mlLabel8;
        private MLLabel mlLabel9;
        private MLGroupBox gbClientInfo;
        private MLCheckBox cbWholesale;
        private MLLabel mlLabel10;
        private MLGroupBox mlGroupBox7;
        private MLGroupBox mlGroupBox6;
        private MLGroupBox mlGroupBox8;
        private MLLabel mlLabel13;
        private MLLabel mlLabel11;
        private MLLabel mlLabel12;
        private MLLabel mlLabel14;
        private MLButton btnGenerateInvoice;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.ComboBox cbSearchContract;
        private MLLabel mlLabel16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MLButton btnAddContractS;
        private MLErrorLabel errorLabel;
    }
}
