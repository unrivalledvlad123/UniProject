﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.Classes;
using Common.Forms.Base;
using DB3Client.Forms;
using DB3Client.Properties;
using DB3Client.ServiceAccess;
using MetroFramework.Drawing;

namespace DB3Client.Controls
{
    public partial class SalesControl : MetroFramework.Controls.MetroUserControl
    {
        public List<CommonItem> AllItems = new List<CommonItem>();
        public List<CommonContract> AllContacts = new List<CommonContract>();
        public List<CommonMol> AllMols = new List<CommonMol>();

        public SalesControl()
        {
            InitializeComponent();
            SetGridColomns();
            LoadDataAsync();
            tabControlSales.SelectedTab = metroTabPage1;
            cbWholesale.Checked = false;
            gbClientInfo.Enabled = false;
            
        }

        #region // < ========= Methods =========> //

        public void SetGridColomns()
        {
            dgvSoldGoods.DataSource = null;
            dgvSoldGoods.Columns.Clear();
            dgvSoldGoods.AutoGenerateColumns = false;
            dgvSoldGoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSoldGoods.RowHeadersVisible = false;


            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "name";
            c1.HeaderText = DataHolder.GetString("item_name");
            c1.DataPropertyName = "Name";
            c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvSoldGoods.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "quantity";
            c2.HeaderText = DataHolder.GetString("quantity");
            c2.DataPropertyName = "Quantity";
            c2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvSoldGoods.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "unit";
            c3.HeaderText = DataHolder.GetString("measurment_unit");
            c3.DataPropertyName = "MeasurmentUnit";
            c3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvSoldGoods.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "priceEach";
            c4.HeaderText = DataHolder.GetString("price_each");
            c4.DataPropertyName = "PriceEach";
            c4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvSoldGoods.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "total";
            c5.HeaderText = DataHolder.GetString("total");
            c5.DataPropertyName = "Total";
            c5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvSoldGoods.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "itemId";
            c6.HeaderText = "itemId";
            c6.DataPropertyName = "ItemId";
            c6.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c6.Visible = false;
            dgvSoldGoods.Columns.Add(c6);

        }

        public async void LoadDataAsync()
        {
            try
            {
                AllItems = await SAItem.GetAllItems(cbSearch.Text);
                cbSearch.DataSource = AllItems;

                cbSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbSearch.DropDownStyle = ComboBoxStyle.DropDown;
                AllContacts = await SAContract.GetAllContracts(cbSearchContract.Text);
                cbSearchContract.DataSource = AllContacts;
                cbSearchContract.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbSearchContract.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbSearchContract.DropDownStyle = ComboBoxStyle.DropDown;
                AllMols = await SAOwner.getAllMols(DataHolder.Owner.OwnerId);
                cbChooseMol.DataSource = AllMols;
                cbChooseMol.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbChooseMol.DropDownStyle = ComboBoxStyle.DropDown;
                cbChooseMol.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, DataHolder.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateTotal()
        {
            float s = 0;
            foreach (DataGridViewRow row in dgvSoldGoods.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    s += (float) row.Cells[4].Value;
                }
            }
            labelTotalAmount.Text = s.ToString();
        }

        private void CalculateChange()
        {
            float s = float.Parse(labelCash.Text) - float.Parse(labelTotalAmount.Text);
            labelChange.Text = s.ToString();
        }

        #endregion

        #region // < ========= Events =========> //

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CommonItem a = ((CommonItem) cbSearch.SelectedItem);
            string name = mlLabel1.Text;
            string quantity = tbQuantity.Text;
            int measurementUnit = a.MeasurmentUnit;
            string price = mlLabel2.Text;
            var vat = 1 + (Settings.Default.VatMultiplier / 100);
            var vatPrice = vat * (decimal) float.Parse(price);
            float totalPrice = float.Parse(quantity) * (float) vatPrice;
            dgvSoldGoods.Rows.Add(name, quantity, measurementUnit, price, totalPrice, a.ItemId);
            UpdateTotal();
        }

        private async void btnFinish_Click(object sender, EventArgs e)
        {

            List<CommonContract> list = await SAContract.GetAllContracts("Direct Sale");
            if (list.Count > 1 || list.Count == 0)
            {
                MessageBox.Show("Can not find direct sale user!");
                return;
            }

            CommonSale s = new CommonSale();
            s.BuyerId = list.First().PartnerId;
            s.SellerId = (DataHolder.Owner.OwnerId);
            s.SoldItems = new List<CommonSoldItem>();

            var vat = 1 + (Settings.Default.VatMultiplier / 100);
            foreach (DataGridViewRow row in dgvSoldGoods.Rows)
            {
                var item = new CommonSoldItem();
                if (row.Cells[5].Value != null)
                {
                    item.Price = vat * decimal.Parse(row.Cells[3].Value.ToString());
                    item.Quantity = int.Parse(row.Cells[1].Value.ToString());
                    item.ItemId = (Guid) row.Cells[5].Value;

                    s.SoldItems.Add(item);
                }
            }

            var sale = await SASale.PostCreateDirectSale(s);
            MessageBox.Show(sale == null ? "Not saved!" : "SAVED!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSoldGoods.SelectedRows.Count == 1 && dgvSoldGoods.SelectedRows[0] != null)
            {
                dgvSoldGoods.SelectedRows.Clear();
            }
        }

        private void btnDetach_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewCompany_Click(object sender, EventArgs e)
        {

        }

        private void cbWholesale_CheckedChanged(object sender, EventArgs e)
        {
            gbClientInfo.Enabled = cbWholesale.Checked;
            btnFinish.Enabled = !cbWholesale.Checked;
        }

        private async void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            CommonSale s = new CommonSale();
            s.BuyerId = ((CommonContract) cbSearchContract.SelectedItem).PartnerId;
            s.SellerId = ((CommonMol) cbChooseMol.SelectedItem).MolId;
            s.SellerId = (DataHolder.Owner.OwnerId);
            s.SoldItems = new List<CommonSoldItem>();

            var vat = 1 + (Settings.Default.VatMultiplier / 100);
            foreach (DataGridViewRow row in dgvSoldGoods.Rows)
            {
                var item = new CommonSoldItem();
                if (row.Cells[5].Value != null)
                {
                    item.Price = vat * decimal.Parse(row.Cells[3].Value.ToString());
                    item.Quantity = int.Parse(row.Cells[1].Value.ToString());
                    item.ItemId = (Guid) row.Cells[5].Value;

                    s.SoldItems.Add(item);
                }
            }

            var sale = await SASale.PostCreateWholeSale(s);
            if (sale == null)
            {
                MessageBox.Show("Sale not saved!");
                return;
            }



            InvoiceTemplateForm form = new InvoiceTemplateForm(sale);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void mlButton1_Click(object sender, EventArgs e)
        {
//            InvoiceTemplateForm form = new InvoiceTemplateForm();
//            if (form.ShowDialog() == DialogResult.OK)
//            {
//
//            }
        }
        private void cbSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mlLabel1.Text = ((CommonItem)cbSearch.SelectedItem).Name;
            mlLabel3.Text = ((CommonItem)cbSearch.SelectedItem).Description;
            mlLabel2.Text = ((CommonItem) cbSearch.SelectedItem).SellingPriceCent.ToString();
        }

        private void tbAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            labelCash.Text = tbAmount.Text;
            CalculateChange();
        }

        private async void cbSearchContract_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mlLabel11.Text = ((CommonContract)cbSearchContract.SelectedItem).CompanyName;
            mlLabel12.Text = ((CommonContract)cbSearchContract.SelectedItem).VatNumber;
            mlLabel14.Text = ((CommonContract)cbSearchContract.SelectedItem).Bulstat;
            mlLabel16.Text = ((CommonContract)cbSearchContract.SelectedItem).Address;
            List<CommonMol> mols = await SAOwner.getAllMols(((CommonContract)cbSearchContract.SelectedItem).PartnerId);
            CommonMol mol = mols.Count == 0 ? new CommonMol() : mols.First();
            mlLabel13.Text = mol.FirstName + " " + mol.LastName;

        }

        #endregion


        private bool isInProgress = false;

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
