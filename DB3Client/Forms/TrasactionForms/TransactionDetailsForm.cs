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
using DB3Client.ServiceAccess;

namespace DB3Client.Forms.TrasactionForms
{
    public partial class TransactionDetailsForm : MLForm
    {
        protected CommonSale sale;
        
        public TransactionDetailsForm(CommonSale sale)
        {

            InitializeComponent();
            SetGridColumnsItems();
            this.sale = sale;
            LoadData();
        }

        public async void LoadData()
        {
            foreach (var soldItem in sale.SoldItems)
            {
                var item = await SAItem.GetItemsById(soldItem.ItemId.ToString());
                string name = item.ToString();
                string quantity = soldItem.Quantity.ToString();
                int measurementUnit = item.MeasurmentUnit;
                string price = soldItem.Price.ToString();

                var vatPrice = soldItem.Price;

                float totalPrice = float.Parse(quantity) * (float)vatPrice;

                dgvDetailsTransaction.Rows.Add(name, quantity, measurementUnit, price, totalPrice);



            }
            mlLabelContractName.Text = sale.BuyerCompanyName;
        }

        public void SetGridColumnsItems()
        {
            dgvDetailsTransaction.DataSource = null;
            dgvDetailsTransaction.Columns.Clear();
            dgvDetailsTransaction.AutoGenerateColumns = false;
            dgvDetailsTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetailsTransaction.RowHeadersVisible = false;


            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "productName";
            c1.HeaderText = DataHolder.GetString("name");
            c1.DataPropertyName = "productName";
            c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvDetailsTransaction.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "quantity";
            c2.HeaderText = DataHolder.GetString("quantity");
            c2.DataPropertyName = "quantity";
            c2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvDetailsTransaction.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "MeasurementUnit";
            c3.HeaderText = DataHolder.GetString("measurementUnit");
            c3.DataPropertyName = "MeasuremnetUnit";
            c3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvDetailsTransaction.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Price";
            c4.HeaderText = DataHolder.GetString("price");
            c4.DataPropertyName = "Price";
            c4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvDetailsTransaction.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "TotalPrice";
            c5.HeaderText = DataHolder.GetString("total_price");
            c5.DataPropertyName = "Price";
            c5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvDetailsTransaction.Columns.Add(c5);



        }

    }

}
