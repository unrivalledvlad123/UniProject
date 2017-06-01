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
using DB3Client.Forms;
using DB3Client.Forms.ContractsForms;
using DB3Client.Forms.TrasactionForms;
using DB3Client.ServiceAccess;

namespace DB3Client.Controls
{
    public partial class ContractsControl : UserControl
    {
        public ContractsControl()
        {
            InitializeComponent();
            LoadDataContracts();
            SetGridColomnsAllSales();
            LoadDataTransactions();
            SetGridColomnsContracts();
            tabControlContracts.SelectedTab = metroTabPage1;
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            AddEditContractForm editForm = new AddEditContractForm(new CommonContract(), new CommonMol());

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadDataContracts();
            }
           
        }

        private async void LoadDataContracts()
        {
            List<CommonContract> list = await SAContract.GetAllContracts(tbSearchContracts.Text);
            dgvContracts.DataSource = list;
        }

        private void tbSearchContracts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            LoadDataContracts();
        }

        private async void btnEditContract_Click(object sender, EventArgs e)
        {
            if (dgvContracts.SelectedRows.Count == 1 && dgvContracts.SelectedRows[0] != null)
            {
                CommonContract selectedItem = (CommonContract)dgvContracts.SelectedRows[0].DataBoundItem;
                List<CommonMol> mols = await SAOwner.getAllMols(selectedItem.PartnerId);
                CommonMol mol = mols.Count == 0 ? new CommonMol() : mols.First();
                AddEditContractForm form = new AddEditContractForm(selectedItem, mol);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadDataContracts();
                }

            }
        }

        public void SetGridColomnsContracts()
        {
            dgvContracts.DataSource = null;
            dgvContracts.Columns.Clear();
            dgvContracts.AutoGenerateColumns = false;
            dgvContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContracts.RowHeadersVisible = false;


            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "partnerId";
            c1.HeaderText = DataHolder.GetString("partner_Id_grid");
            c1.DataPropertyName = "PartnerId";
            c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c1.Visible = false;
            dgvContracts.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "companyname";
            c2.HeaderText = DataHolder.GetString("companyname_grid");
            c2.DataPropertyName = "CompanyName";
            c2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvContracts.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Address";
            c3.HeaderText = DataHolder.GetString("address_grid");
            c3.DataPropertyName = "Address";
            c3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c3.Visible = false;
            dgvContracts.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "phone";
            c4.HeaderText = DataHolder.GetString("phone_grid");
            c4.DataPropertyName = "Phone";
            c4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvContracts.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "email";
            c5.HeaderText = DataHolder.GetString("email_grid");
            c5.DataPropertyName = "Email";
            c5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvContracts.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "bulstat";
            c6.HeaderText = DataHolder.GetString("bulstat_grid");
            c6.DataPropertyName = "Bulstat";
            c6.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvContracts.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Name = "vatnumber";
            c7.HeaderText = DataHolder.GetString("vatnumber_grid");
            c7.DataPropertyName = "VatNumber";
            c7.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvContracts.Columns.Add(c7);

        }

        private void tbSearchTransactions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            LoadDataTransactions();
        }
        private async void LoadDataTransactions()
        {
            List<CommonSale> list = await SASale.GetAllSales(tbSearchTransactions.Text);
            foreach(CommonSale Item in list)
                {

                double temp = Item.TotalPrice;
                Item.ParsePrice = (temp / 100).ToString();
            
            }
            dgvTransactions.DataSource = list;

        }
        public void SetGridColomnsAllSales()
        {
            dgvTransactions.DataSource = null;
            dgvTransactions.Columns.Clear();
            dgvTransactions.AutoGenerateColumns = false;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.RowHeadersVisible = false;

            
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "CompanyName";
            c1.HeaderText = DataHolder.GetString("company_name");
            c1.DataPropertyName = "BuyerCompanyName";
            c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvTransactions.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Date";
            c2.HeaderText = DataHolder.GetString("date");
            c2.DataPropertyName = "Date";
            c2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvTransactions.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "InvoiceNumber";
            c3.HeaderText = DataHolder.GetString("invoice_number");
            c3.DataPropertyName = "InvoiceNumber";
            c3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvTransactions.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "totalAmount";
            c4.HeaderText = DataHolder.GetString("total_amount");
            c4.DataPropertyName = "ParsePrice";
            c4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvTransactions.Columns.Add(c4);

        }

        private void btnViewTransactionDetails_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count == 1 && dgvTransactions.SelectedRows[0] != null)
            {
                CommonSale selectedItem = (CommonSale)dgvTransactions.SelectedRows[0].DataBoundItem;
                TransactionDetailsForm detailsForm = new TransactionDetailsForm(selectedItem);

                if (detailsForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
         
        }

        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count == 1 && dgvTransactions.SelectedRows[0] != null)
            {
                
                CommonSale selectedItem = (CommonSale)dgvTransactions.SelectedRows[0].DataBoundItem;

                if (!string.IsNullOrEmpty(selectedItem.InvoiceId))
                {
                    InvoiceTemplateForm form = new InvoiceTemplateForm(selectedItem, false);

                    if (form.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Няма издадена Фактура към продажбата!");
                }

            }
        }

        private void cbContractType1_DropDown(object sender, EventArgs e)
        {
            cbContractType1.Items.Add("all");

        }
    }
}

 