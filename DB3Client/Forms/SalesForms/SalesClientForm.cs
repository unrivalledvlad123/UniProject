using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.Classes;
using Common.Forms.Base;
using DB3Client.Controls;
using DB3Client.Properties;

namespace DB3Client.Forms.SalesForms
{
    public partial class SalesClientForm : MLForm
    {
        public SalesClientForm()
        {
            InitializeComponent();
            SetGridColomns();
        }

        public void SetGridColomns()
        {
            dgvSoldGoodsClient.DataSource = null;
            dgvSoldGoodsClient.Columns.Clear();
            dgvSoldGoodsClient.AutoGenerateColumns = false;
            dgvSoldGoodsClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSoldGoodsClient.RowHeadersVisible = false;


            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "name";
            c1.HeaderText = DataHolder.GetString("item_name");
            c1.DataPropertyName = "Name";
            c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvSoldGoodsClient.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "quantity";
            c2.HeaderText = DataHolder.GetString("quantity");
            c2.DataPropertyName = "Quantity";
            c2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvSoldGoodsClient.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "unit";
            c3.HeaderText = DataHolder.GetString("measurment_unit");
            c3.DataPropertyName = "MeasurmentUnit";
            c3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvSoldGoodsClient.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "priceEach";
            c4.HeaderText = DataHolder.GetString("price_each");
            c4.DataPropertyName = "PriceEach";
            c4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvSoldGoodsClient.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "total";
            c5.HeaderText = DataHolder.GetString("total");
            c5.DataPropertyName = "Total";
            c5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvSoldGoodsClient.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "itemId";
            c6.HeaderText = "itemId";
            c6.DataPropertyName = "ItemId";
            c6.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c6.Visible = false;
            dgvSoldGoodsClient.Columns.Add(c6);

        }
       
        private void SalesClientForm_Load(object sender, EventArgs e)
        {
      
        }
    }
}
