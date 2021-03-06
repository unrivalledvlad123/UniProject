﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Common;
using Common.Classes;
using Common.Forms.Base;
using DB3Client.Forms;
using DB3Client.Forms.ContractsForms;
using DB3Client.Forms.SalesForms;
using DB3Client.Properties;
using DB3Client.ServiceAccess;
using MetroFramework.Drawing;
using Org.BouncyCastle.Bcpg;

namespace DB3Client.Controls
{
    [Permission(PermissionId = "0EA27560-DEBC-454D-A06B-53582888472D", PermissionName = "add", PermissionLocation = "tab_page_direct_sales", PermissionControlRoot = "sales")]
    [Permission(PermissionId = "D59CC3F4-0ABE-4429-B8CB-19716C0C135E", PermissionName = "delete", PermissionLocation = "tab_page_direct_sales", PermissionControlRoot = "sales")]
    [Permission(PermissionId = "1AB76F10-0655-4EDC-8B4D-5BCC23A24C0B", PermissionName = "att_detach", PermissionLocation = "tab_page_direct_sales", PermissionControlRoot = "sales")]
    [Permission(PermissionId = "F3775EF1-ABFA-488A-B87A-BDD3C9A47818", PermissionName = "finish", PermissionLocation = "tab_page_direct_sales", PermissionControlRoot = "sales")]
    [Permission(PermissionId = "C94D8A03-0D9C-4CC5-AEE0-2365B4A6439B", PermissionName = "add_contract", PermissionLocation = "tab_page_direct_sales", PermissionControlRoot = "sales")]
    [Permission(PermissionId = "35BB373E-FD2F-4E2E-AF40-958566D919DD", PermissionName = "generate_invoice", PermissionLocation = "tab_page_direct_sales", PermissionControlRoot = "sales")]


    public partial class SalesControl : MetroFramework.Controls.MetroUserControl
    {
        public List<CommonItem> AllItems = new List<CommonItem>();
        public List<CommonContract> AllContacts = new List<CommonContract>();
        public List<CommonMol> AllMols = new List<CommonMol>();
        public bool trigger = false;

        SalesClientForm f = new SalesClientForm();
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
            c1.ReadOnly = true;
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
            c3.ReadOnly = true;
            dgvSoldGoods.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "priceEach";
            c4.HeaderText = DataHolder.GetString("price_each");
            c4.DataPropertyName = "PriceEach";
            c4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c4.ReadOnly = true;
            dgvSoldGoods.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "total";
            c5.HeaderText = DataHolder.GetString("total");
            c5.DataPropertyName = "Total";
            c5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c5.ReadOnly = true;
            dgvSoldGoods.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "itemId";
            c6.HeaderText = "itemId";
            c6.DataPropertyName = "ItemId";
            c6.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c6.Visible = false;
            dgvSoldGoods.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Name = "type";
            c7.HeaderText = "type";
            c7.DataPropertyName = "Type";
            c7.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c7.Visible = false;
            dgvSoldGoods.Columns.Add(c7);

            f.dgvSoldGoodsClient.DataSource = dgvSoldGoods.DataSource;
        }

        public async void LoadDataAsync()
        {
           // cbSearch.SelectedIndex = -1;
            try
            {
                AllItems = await SAItem.GetAllItems(cbSearch.Text);
                List<CommonItem> k = new List<CommonItem>();
                foreach (CommonItem Item in AllItems)
                {

                    decimal temp = Item.SellingPriceCent;
                    Item.ParcePrice = temp / 100;
                    
                }

                cbSearch.DataSource = AllItems;
                cbSearch.SelectedIndex = -1;
                cbSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbSearch.DropDownStyle = ComboBoxStyle.DropDown;
                AllContacts = await SAContract.GetAllContracts(cbSearchContract.Text);
                cbSearchContract.DataSource = AllContacts;
                cbSearchContract.SelectedIndex = -1;
                cbSearchContract.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbSearchContract.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbSearchContract.DropDownStyle = ComboBoxStyle.DropDown;
              // AllMols = await SAOwner.getAllMols(DataHolder.Owner.OwnerId);
                CommonMol primeryMol = DataHolder.PrimeryMol;


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
                    s += (float)row.Cells[4].Value;
                }
            }
            labelTotalAmount.Text = s.ToString();
            f.labelTotalAmountClient.Text = labelTotalAmount.Text;
        }

        private void CalculateChange()
        {
            float s = float.Parse(labelCash.Text) - float.Parse(labelTotalAmount.Text);
            labelChange.Text = s.ToString();
            f.labelChangeClient.Text = labelChange.Text;
            f.labelCashClient.Text = labelCash.Text;
        }

        #endregion

        #region // < ========= Events =========> //
        List<CommonItem> k = new List<CommonItem>();
        private void ClearSelection()
        {
            mlLabel1.Text = "-";
            tbQuantity.Text = "";
            mlLabel2.Text = "-";
            mlLabel3.Text = "-";
            cbSearch.SelectedIndex = -1;
        }

        private void ClearAll()
        {
            ClearSelection();
            dgvSoldGoods.Rows.Clear();
           f.dgvSoldGoodsClient.Rows.Clear();
            cbSearchContract.SelectedIndex = -1;
            labelTotalAmount.Text = "0";
            labelCash.Text = "0";
            labelChange.Text = "0";
            f.labelTotalAmountClient.Text = "0";
            f.labelCashClient.Text = "0";
            f.labelChangeClient.Text = "0";
            mlLabel11.Text = "";
            mlLabel12.Text = "";
            mlLabel14.Text = "";
            mlLabel13.Text = "";
            mlLabel16.Text = "";
            tbAmount.Text = "";
            errorLabel.Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbQuantity.Text))
            {
                CommonItem a = ((CommonItem) cbSearch.SelectedItem);
                KeyValuePair<int,decimal> temp = DataHolder.Settings.VatSettingsByGroup.FirstOrDefault(p => p.Key == a.Type);
                string name = mlLabel1.Text;
                
                string quantity = tbQuantity.Text;
                int measurementUnit = a.MeasurmentUnit;
                //if (DataHolder.UserCulture.TwoLetterISOLanguageName == "bg")
                //{
                //    Enums.UnitTypesBg types = (Enums.UnitTypesBg) a.MeasurmentUnit;
                //    a. = types.ToString();
                //}
                //else
                //{
                //    Enums.UnitTypes types = (Enums.UnitTypes)a.MeasurmentUnit;
                //    a.UnitString = types.ToString();
                //}
                string price = mlLabel2.Text;
                var vat = 1 + temp.Value;
                var vatPrice = vat * (decimal) float.Parse(price);
                float totalPrice = float.Parse(quantity) * (float) vatPrice;
                f.dgvSoldGoodsClient.Rows.Add(name, quantity, measurementUnit, price, totalPrice);
                dgvSoldGoods.Rows.Add(name, quantity, measurementUnit, price, totalPrice, a.ItemId, a.Type);
              
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Fill quantity!!!");
               
            }
            ClearSelection();

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


            foreach (DataGridViewRow row in dgvSoldGoods.Rows)
            {
                var index = (int) row.Cells[6].Value;
                KeyValuePair<int, decimal> pair = DataHolder.Settings.VatSettingsByGroup.FirstOrDefault(p => p.Key == index);
                var item = new CommonSoldItem();
                if (row.Cells[5].Value != null)
                {
                    item.Price = (1 + pair.Value) * decimal.Parse(row.Cells[3].Value.ToString());
                    item.Quantity = int.Parse(row.Cells[1].Value.ToString());
                    item.ItemId = (Guid) row.Cells[5].Value;

                    s.SoldItems.Add(item);
                }
            }

            var sale = await SASale.PostCreateDirectSale(s);
            if (sale == null)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "not_enough_quantity";
            }
            else
            {
                ClearAll();
            }

            SalesReceiptForm form = new SalesReceiptForm(sale);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSoldGoods.SelectedRows.Count == 1 && dgvSoldGoods.SelectedRows[0] != null)
            {
                int index = dgvSoldGoods.SelectedRows[0].Index;
                dgvSoldGoods.Rows.RemoveAt(index);
                f.dgvSoldGoodsClient.Rows.RemoveAt(index);
                UpdateTotal();
            }
            
        }


        private void btnDetach_Click(object sender, EventArgs e)
        {
            if (!trigger)
            {
                trigger = true;
                f.Show();
            }
            else
            {
                trigger = false;
                f.Hide();
            }
        }



        private void cbWholesale_CheckedChanged(object sender, EventArgs e)
        {
            gbClientInfo.Enabled = cbWholesale.Checked;
            btnFinish.Enabled = !cbWholesale.Checked;
        }

        private async void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            //cbSearchContract.SelectedIndex = -1;
            CommonSale s = new CommonSale();
            s.BuyerId = ((CommonContract) cbSearchContract.SelectedItem).PartnerId;
            s.SellerId = DataHolder.PrimeryMol.MolId;//remove
            s.SellerId = (DataHolder.Owner.OwnerId);
            s.SoldItems = new List<CommonSoldItem>();

            foreach (DataGridViewRow row in dgvSoldGoods.Rows)
            {
                var index = (int) row.Cells[6].Value;
                KeyValuePair<int, decimal> pair = DataHolder.Settings.VatSettingsByGroup.FirstOrDefault(p => p.Key == index);
                var item = new CommonSoldItem();
                if (row.Cells[5].Value != null)
                {
                    item.Price = (1 + pair.Value) * decimal.Parse(row.Cells[3].Value.ToString());
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
            ClearAll();



            InvoiceTemplateForm form = new InvoiceTemplateForm(sale);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

       
        private void cbSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mlLabel1.Text = ((CommonItem)cbSearch.SelectedItem).Name;
            mlLabel3.Text = ((CommonItem)cbSearch.SelectedItem).Description;
            mlLabel2.Text = ((CommonItem) cbSearch.SelectedItem).ParcePrice.ToString();
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

        private void tbAmount_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void gbClientInfo_Enter(object sender, EventArgs e)
        {

        }

        private async void btnAddContractS_Click(object sender, EventArgs e)
        {
            AddEditContractForm editForm = new AddEditContractForm(new CommonContract(), new CommonMol());

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                AllContacts = await SAContract.GetAllContracts(cbSearchContract.Text);
                cbSearchContract.DataSource = AllContacts;
                cbSearchContract.SelectedIndex = -1;
            }
        }


        private void dgvSoldGoods_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
              
         
            var v = dgvSoldGoods.CurrentRow;
           int index = dgvSoldGoods.Rows.IndexOf(v);
               
                float totalPrice = float.Parse(v.Cells[1].Value.ToString()) * float.Parse(v.Cells[3].Value.ToString());

            v.Cells[4].Value = totalPrice;

            f.dgvSoldGoodsClient.Rows[index].Cells[1].Value = v.Cells[1].Value;
            f.dgvSoldGoodsClient.Rows[index].Cells[4].Value = v.Cells[4].Value;

            // f.dgvSoldGoodsClient.Rows.Add(name, quantity, measurementUnit, price, totalPrice);
            //dgvSoldGoods.Rows.Add(name, quantity, measurementUnit, price, totalPrice, a.ItemId, a.Type);
            UpdateTotal();
            
            
        }
    }
}
