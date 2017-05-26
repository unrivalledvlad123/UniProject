using System;
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
using DB3Client.Forms.ContractsForms;
using DB3Client.ServiceAccess;

namespace DB3Client.Controls
{
    public partial class OrdersControl : UserControl
    {
        public List<CommonContract> AllContacts = new List<CommonContract>();
        public List<CommonItem> AllItems = new List<CommonItem>();
        public bool trigger = false;
        public MLLabel LbBulstatHidden
        {
            get { return lbBulstatHidden; }
            set { lbBulstatHidden = value; }
        }
        public OrdersControl()
        {
            InitializeComponent();
            SetGridColomns();
            LoadData();
            LoadDataAsync();
            UpdateTotal();
        }

        public void SetGridColomns()
        {
            dgvPurchase.DataSource = null;
            dgvPurchase.Columns.Clear();
            dgvPurchase.AutoGenerateColumns = false;
            dgvPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPurchase.RowHeadersVisible = false;

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "name";
            c1.HeaderText = DataHolder.GetString("item_name");
            c1.DataPropertyName = "Name";
            c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvPurchase.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "quantity";
            c2.HeaderText = DataHolder.GetString("quantity");
            c2.DataPropertyName = "Quantity";
            c2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvPurchase.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "unit";
            c3.HeaderText = DataHolder.GetString("measurment_unit");
            c3.DataPropertyName = "MeasurmentUnitString";
            c3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvPurchase.Columns.Add(c3);

           

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "priceEach";
            c4.HeaderText = DataHolder.GetString("price_each");
            c4.DataPropertyName = "ParcePrice";
            c4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvPurchase.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "total";
            c5.HeaderText = DataHolder.GetString("total");
            c5.DataPropertyName = "Total";
            c5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvPurchase.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "itemId";
            c6.HeaderText = "itemId";
            c6.DataPropertyName = "ItemId";
            c6.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c6.Visible = false;
            dgvPurchase.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Name = "unitHidden";
            c7.HeaderText = "unitHidden";
            c7.DataPropertyName = "MeasurmentUnit";
            c7.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c7.Visible = false;
            dgvPurchase.Columns.Add(c7);

        }

        public async void LoadData()
        {
            try
            {
                AllContacts = await SAContract.GetAllContracts(cbSearchOrders.Text);
                cbSearchOrders.DataSource = AllContacts;
                cbSearchOrders.DropDownStyle = ComboBoxStyle.DropDown;
                cbSearchOrders.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbSearchOrders.AutoCompleteSource = AutoCompleteSource.ListItems;
                

            }
            catch (Exception e)
            {
            }
        }

        private async void cbSearchOrders_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (trigger)
            {
                companyNameHidden.Text = ((CommonContract) cbSearchOrders.SelectedItem).CompanyName;
                lbVatHidden.Text = ((CommonContract) cbSearchOrders.SelectedItem).VatNumber;
                lbBulstatHidden.Text = ((CommonContract) cbSearchOrders.SelectedItem).Bulstat;
                lbAddressHidden.Text = ((CommonContract) cbSearchOrders.SelectedItem).Address;
                List<CommonMol> mols = await SAOwner.getAllMols(((CommonContract) cbSearchOrders.SelectedItem).PartnerId);
                CommonMol mol = mols.Count == 0 ? new CommonMol() : mols.First();
                lbMolHidden.Text = mol.FirstName + " " + mol.LastName;
            }
            else
            {
                trigger = true;
                //cbSearchOrders.SelectedIndex = -1;

            }



        }

        private void btnAddParthners_Click(object sender, EventArgs e)
        {
            AddEditContractForm editForm = new AddEditContractForm(new CommonContract(), new CommonMol());

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                //LoadDataContracts();
            }
        }

        public async void LoadDataAsync()
        {
            try
            {
                AllItems = await SAItem.GetAllItems(cbSearchGoodsOrders.Text);
                List<CommonItem> k = new List<CommonItem>();
            
                foreach (CommonItem Item in AllItems)
                {

                    decimal temp = Item.SellingPriceCent;
                    Item.ParcePrice = temp / 100;
                    if (DataHolder.UserCulture.TwoLetterISOLanguageName == "bg")
                    {
                        Enums.UnitTypesBg types = (Enums.UnitTypesBg) Item.MeasurmentUnit;
                        Item.MeasurmentUnitString = types.ToString();
                    }
                    else
                    {
                        Enums.UnitTypes types = (Enums.UnitTypes)Item.MeasurmentUnit;
                        Item.MeasurmentUnitString = types.ToString();
                    }
                        

                }

                cbSearchGoodsOrders.DataSource = AllItems;
                cbSearchGoodsOrders.SelectedIndex = -1;

                cbSearchGoodsOrders.DropDownStyle = ComboBoxStyle.DropDown;
                cbSearchGoodsOrders.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbSearchGoodsOrders.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, DataHolder.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAddItemsOrders_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAmountOrders.Text) && cbSearchOrders.SelectedItem != null)
            {
                CommonItem a = ((CommonItem)cbSearchGoodsOrders.SelectedItem);
                KeyValuePair<int, decimal> temp = DataHolder.Settings.VatSettingsByGroup.FirstOrDefault(p => p.Key == a.Type);
                string name = a.Name;
                string quantity = tbAmountOrders.Text;
                int measurementUnit = a.MeasurmentUnit;
                string price = a.ParcePrice.ToString();
                var vat = 1 + temp.Value;
                var vatPrice = vat * (decimal)float.Parse(price);
                float totalPrice = float.Parse(quantity) * (float)vatPrice;
                dgvPurchase.Rows.Add(name, quantity, a.MeasurmentUnitString, price, totalPrice, a.ItemId, a.Type, measurementUnit);

                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Fill quantity!!!");

            }
            ClearSelection();

        }
        private void ClearSelection()
        {
            companyNameHidden.Text = "-";
            lbVatHidden.Text = "";
            lbBulstatHidden.Text = "-";
            lbAddressHidden.Text = "-";
            lbTotalOrders.Text = "0";
            cbSearchGoodsOrders.SelectedIndex = -1;
        }
        private void UpdateTotal()
        {
            float s = 0;
            foreach (DataGridViewRow row in dgvPurchase.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    s += (float)row.Cells[4].Value;
                }
            }
            lbTotalOrders.Text = s.ToString();
           
        }

        private void btnDeleteOrders_Click(object sender, EventArgs e)
        {
            if (dgvPurchase.SelectedRows.Count == 1 && dgvPurchase.SelectedRows[0] != null)
            {
                int index = dgvPurchase.SelectedRows[0].Index;
                dgvPurchase.Rows.RemoveAt(index);
                UpdateTotal();
            }
        }
    }
}
