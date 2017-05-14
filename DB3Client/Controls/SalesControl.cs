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
using DB3Client.Forms;
using DB3Client.ServiceAccess;
using MetroFramework.Drawing;

namespace DB3Client.Controls
{
    public partial class SalesControl : MetroFramework.Controls.MetroUserControl
    {
        public SalesControl()
        {
            InitializeComponent();
            LoadMolList();
            SetGridColomns();
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



        #endregion

        #region // < ========= Events =========> //

        private void btnAdd_Click(object sender, EventArgs e)
        {
          CommonItem a = ((CommonItem) cbSearch.SelectedItem);
            string name = mlLabel1.Text;
            
            string quantity = tbQuantity.Text;
            string price = mlLabel2.Text;
            float totalPrice = float.Parse(quantity) * float.Parse(price);
            dgvSoldGoods.Rows.Add(name, quantity, price, totalPrice);
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            float s = 0;
            foreach (DataGridViewRow row in dgvSoldGoods.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    s += (float)row.Cells[3].Value;
                }
               
            }
            labelTotalAmount.Text = s.ToString();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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
           // gbClientInfo.Enabled = !cbWholesale.Checked;
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            InvoiceTemplateForm form = new InvoiceTemplateForm();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        #endregion

        private void mlButton1_Click(object sender, EventArgs e)
        {
            InvoiceTemplateForm form = new InvoiceTemplateForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private bool isInProgress = false;

       

        

        private async void cbSearch_TextChanged(object sender, EventArgs e)
        {
           
            List<CommonItem> list = await SAItem.GetAllItems(cbSearch.Text);
            cbSearch.Items.Clear();


                        foreach (CommonItem item in list)
                        {
                          
                            cbSearch.Items.Add(item);
                        }



            
            cbSearch.DroppedDown = true;

        }

        private void cbSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            mlLabel1.Text = ((CommonItem) cbSearch.SelectedItem).Name;
            mlLabel3.Text = ((CommonItem) cbSearch.SelectedItem).Description;
            mlLabel2.Text = "10";
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

        private void CalculateChange()
        {
            float s = float.Parse(labelCash.Text) - float.Parse(labelTotalAmount.Text);
            labelChange.Text = s.ToString();
        }

        private async void cbSearchContract_TextChanged(object sender, EventArgs e)
        {
            List<CommonContract> list1 = await SAContract.GetAllContracts(cbSearchContract.Text);
            cbSearchContract.Items.Clear();


            foreach (CommonContract contract in list1)
            {

                cbSearchContract.Items.Add(contract);
            }




            cbSearchContract.DroppedDown = true;
        }

        private async void cbSearchContract_SelectedValueChanged(object sender, EventArgs e)
        {
            mlLabel11.Text = ((CommonContract)cbSearchContract.SelectedItem).CompanyName;
            mlLabel12.Text = ((CommonContract)cbSearchContract.SelectedItem).VatNumber;
            mlLabel14.Text = ((CommonContract)cbSearchContract.SelectedItem).Bulstat;
            mlLabel16.Text = ((CommonContract)cbSearchContract.SelectedItem).Address;

            List<CommonMol> mols = await SAOwner.getAllMols(((CommonContract)cbSearchContract.SelectedItem).PartnerId);
            CommonMol mol = mols.Count == 0 ? new CommonMol() : mols.First();
            mlLabel13.Text = mol.FirstName + " " + mol.LastName;

        }

        public async void LoadMolList()
        {
            List<CommonMol> AllMols = await SAOwner.getAllMols(DataHolder.Owner.OwnerId);
            cbChooseMol.Items.AddRange(AllMols.ToArray());
        }
    }
}
