using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.Classes;
using Common.Forms.Base;
using DB3Client.Controls.AdminControls;
using DB3Client.Forms;
using DB3Client.Forms.AdminForms;
using DB3Client.ServiceAccess;
using MetroFramework.Properties;
using Newtonsoft.Json.Linq;

namespace DB3Client.Controls
{
    public partial class AdminControl : UserControl
    {
        private static List<CommonUser> AllUsers;
        private static List<CommonMol> AllMols;
        private static List<CommonMol> NonPrimeryMols = new List<CommonMol>();
        private static CommonMol PrimeryMol = new CommonMol();


        public AdminControl()
        {
            InitializeComponent();
            NonPrimeryMols.Clear();
            SetGridColomns();
            SetGridColomnsMols();
            SetGridColomnsMolsPrimary();
            LoadData();
            LoadCompanyData();
            LoadMolList();
            tabControlAdmin.SelectedTab = metroTabPage1;

            List<Control> test = new List<Control>();
            test.Add(btnAddMol);
            foreach (Control btn in test)
            {
                btn.Enabled = false;
            }

        }



        #region // <====== Utility Methodts ======> //

        public void SetGridColomns()
        {
            dgvUsers.DataSource = null;
            dgvUsers.Columns.Clear();
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.RowHeadersVisible = false;


            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "username";
            c1.HeaderText = DataHolder.GetString("username");
            c1.DataPropertyName = "Username";
            c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvUsers.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "role";
            c2.HeaderText = DataHolder.GetString("administration_role");
            c2.DataPropertyName = "RoleString";
            c2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvUsers.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "assignedTo";
            c3.HeaderText = DataHolder.GetString("assigned_to");
            c3.DataPropertyName = "AssignedTo";
            c3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvUsers.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "registeredAt";
            c4.HeaderText = DataHolder.GetString("created_at");
            c4.DataPropertyName = "RegisteredAt";
            c4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvUsers.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "userId";
            c5.HeaderText = "UserID";
            c5.DataPropertyName = "UserId";
            c5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c5.Visible = false;
            dgvUsers.Columns.Add(c5);

        }

        public void SetGridColomnsMols()
        {
            dgvMol.DataSource = null;
            dgvMol.Columns.Clear();
            dgvMol.AutoGenerateColumns = false;
            dgvMol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMol.RowHeadersVisible = false;


            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "firstname";
            c1.HeaderText = DataHolder.GetString("firstname_grid");
            c1.DataPropertyName = "FirstName";
            c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvMol.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "lastname";
            c2.HeaderText = DataHolder.GetString("lastname_grid");
            c2.DataPropertyName = "LastName";
            c2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvMol.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "phone";
            c3.HeaderText = DataHolder.GetString("phone_grid");
            c3.DataPropertyName = "Phone";
            c3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvMol.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "email";
            c4.HeaderText = DataHolder.GetString("email_grid");
            c4.DataPropertyName = "Email";
            c4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvMol.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "molId";
            c5.HeaderText = "MolId";
            c5.DataPropertyName = "MolId";
            c5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c5.Visible = false;
            dgvMol.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "Address";
            c6.HeaderText = "Address";
            c6.DataPropertyName = "Address";
            c6.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c6.Visible = false;
            dgvMol.Columns.Add(c6);

        }

        public void SetGridColomnsMolsPrimary()
        {
            dgvPrimaryMol.DataSource = null;
            dgvPrimaryMol.Columns.Clear();
            dgvPrimaryMol.AutoGenerateColumns = false;
            dgvPrimaryMol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrimaryMol.RowHeadersVisible = false;


            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "firstname";
            c1.HeaderText = DataHolder.GetString("firstname_grid");
            c1.DataPropertyName = "FirstName";
            c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvPrimaryMol.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "lastname";
            c2.HeaderText = DataHolder.GetString("lastname_grid");
            c2.DataPropertyName = "LastName";
            c2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvPrimaryMol.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "phone";
            c3.HeaderText = DataHolder.GetString("phone_grid");
            c3.DataPropertyName = "Phone";
            c3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvPrimaryMol.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "email";
            c4.HeaderText = DataHolder.GetString("email_grid");
            c4.DataPropertyName = "Email";
            c4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvPrimaryMol.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "molId";
            c5.HeaderText = "MolId";
            c5.DataPropertyName = "MolId";
            c5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c5.Visible = false;
            dgvPrimaryMol.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "Address";
            c6.HeaderText = "Address";
            c6.DataPropertyName = "Address";
            c6.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c6.Visible = false;
            dgvPrimaryMol.Columns.Add(c6);

        }

        public async void LoadData()
        {
            AllUsers = await SAUsers.GetAllUsers(DataHolder.Owner.OwnerId);
            dgvUsers.DataSource = AllUsers;
        }

        public void LoadCompanyData()
        {
            labelAddress.Text = !string.IsNullOrEmpty(DataHolder.Owner.Address) ? DataHolder.Owner.Address : "";
            labelCompanyName.Text = !string.IsNullOrEmpty(DataHolder.Owner.CompanyName) ? DataHolder.Owner.CompanyName : "";
            labelEmail.Text = !string.IsNullOrEmpty(DataHolder.Owner.Email) ? DataHolder.Owner.Email : "";
            labelPhone.Text = !string.IsNullOrEmpty(DataHolder.Owner.Phone) ? DataHolder.Owner.Phone : "";
            labelBulstat.Text = !string.IsNullOrEmpty(DataHolder.Owner.Bulstat) ? DataHolder.Owner.Bulstat : "";
            labelVAT.Text = !string.IsNullOrEmpty(DataHolder.Owner.VatNumber) ? DataHolder.Owner.VatNumber : "";
            labelBank.Text = !string.IsNullOrEmpty(DataHolder.Owner.Bank) ? DataHolder.Owner.Bank : "";
            labelIban.Text = !string.IsNullOrEmpty(DataHolder.Owner.Iban) ? DataHolder.Owner.Iban : "";
        }

        public async void LoadMolList()
        {
            AllMols = await SAOwner.getAllMols(DataHolder.Owner.OwnerId);
            NonPrimeryMols.Clear();

            List<CommonMol> primeryMol = new List<CommonMol>();
            foreach (var mol in AllMols)
            {
                if (mol.IsPrimery)
                {
                    primeryMol.Add(mol);
                    PrimeryMol = mol;
                }
                else
                {
                    NonPrimeryMols.Add(mol);
                }
            }
            dgvMol.DataSource = null;
            dgvMol.DataSource = NonPrimeryMols;
            dgvPrimaryMol.DataSource = primeryMol;
        }

        #endregion

        #region // < ====== Events =====> //

        #region // < ========== Manage users Events ============ > //

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count != 1)
            {
                btnEditUser.Enabled = false;
                btnDeleteUser.Enabled = false;
            }
            else
            {
                btnEditUser.Enabled = true;
                btnDeleteUser.Enabled = true;
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AddNewUserForm addForm = new AddNewUserForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 1 && dgvUsers.SelectedRows[0] != null)
            {
                CommonUser selectedItem = (CommonUser) dgvUsers.SelectedRows[0].DataBoundItem;
                EditUserForm form = new EditUserForm(selectedItem);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }

            }
        }

        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 1 && dgvUsers.SelectedRows[0] != null)
            {
                CommonUser selectedItem = (CommonUser) dgvUsers.SelectedRows[0].DataBoundItem;
                if (selectedItem.UserId != DataHolder.CurrnetUserId)
                {
                    bool success = await SAUsers.PostDeleteUser(selectedItem.UserId);
                    if (success)
                    {
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show(DataHolder.GetString("error_deleting_user"), DataHolder.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(DataHolder.GetString("error_deleting_user"), DataHolder.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        #endregion

        #region // < ========== Manage Company Events ============ > //

        private void dgvMol_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMol.SelectedRows.Count != 1)
            {
                btnEditMol.Enabled = false;
                btnDeleteMol.Enabled = false;
            }
            else
            {
                btnEditMol.Enabled = true;
                btnDeleteMol.Enabled = true;
            }
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            EditCompanyForm editForm = new EditCompanyForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                labelCompanyName.Text = editForm.Owner2.CompanyName;
                labelAddress.Text = editForm.Owner2.Address;
                labelEmail.Text = editForm.Owner2.Email;
                labelPhone.Text = editForm.Owner2.Phone;
                labelVAT.Text = editForm.Owner2.VatNumber;
                labelBulstat.Text = editForm.Owner2.Bulstat;
                labelBank.Text = editForm.Owner2.Bank;
                labelIban.Text = editForm.Owner2.Iban;


            }
        }

        private void btnAddMol_Click(object sender, EventArgs e)
        {
            AddEditMolForm form = new AddEditMolForm(null);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadMolList();
            }
        }

        private void btnEditMol_Click(object sender, EventArgs e)
        {
            if (dgvMol.SelectedRows.Count == 1 && dgvMol.SelectedRows[0] != null)
            {
                CommonMol selectedItem = (CommonMol) dgvMol.SelectedRows[0].DataBoundItem;
                AddEditMolForm form = new AddEditMolForm(selectedItem);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadMolList();
                }
            }
        }

        private async void btnDeleteMol_Click(object sender, EventArgs e)
        {
            if (dgvMol.SelectedRows.Count == 1 && dgvMol.SelectedRows[0] != null)
            {
                CommonMol selectedItem = (CommonMol) dgvMol.SelectedRows[0].DataBoundItem;
                bool success = await SAOwner.PostDeleteMol(selectedItem.MolId);
                if (success)
                {
                    LoadMolList();
                }
                else
                {
                    MessageBox.Show(DataHolder.GetString("error_deleting_mol"), DataHolder.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void pictureBoxGreen_Click(object sender, EventArgs e)
        {
            if (dgvMol.SelectedRows.Count == 1 && dgvMol.SelectedRows[0] != null)
            {
                CommonMol selectedItem = (CommonMol) dgvMol.SelectedRows[0].DataBoundItem;
                if (DataHolder.PrimeryMol == null)
                {
                    CommonMol tempMol = new CommonMol();
                    tempMol.MolId = Guid.NewGuid();

                    CommonMol newPrimeryMol = await SAOwner.SetPrimery(tempMol, selectedItem);
                    CommonMol molToRemove = NonPrimeryMols.FirstOrDefault(p => p.MolId == newPrimeryMol.MolId);
                    NonPrimeryMols.Remove(molToRemove);
                    List<CommonMol> temp = new List<CommonMol>();
                    temp.Add(newPrimeryMol);
                    dgvPrimaryMol.DataSource = null;
                    dgvPrimaryMol.DataSource = temp;

                    if (PrimeryMol.OwnerId != Guid.Empty)
                    {
                        PrimeryMol.IsPrimery = false;
                        NonPrimeryMols.Add(PrimeryMol);
                    }

                    dgvMol.DataSource = null;
                    dgvMol.DataSource = NonPrimeryMols;
                    PrimeryMol = newPrimeryMol;
                    DataHolder.PrimeryMol = newPrimeryMol;

                }
            }
        }

        private void pictureBoxGreen_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxGreen.BackgroundImage = DB3Client.Resource.nav_left_green_shadow;
        }

        private void pictureBoxGreen_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxGreen.BackgroundImage = DB3Client.Resource.nav_left_green;
        }

        private async void pictureBoxRed_Click(object sender, EventArgs e)
        {
            if (dgvPrimaryMol.SelectedRows.Count == 1 && dgvPrimaryMol.SelectedRows[0] != null)
            {
                CommonMol selectedItem = (CommonMol) dgvPrimaryMol.SelectedRows[0].DataBoundItem;

                CommonMol tempMol = new CommonMol();
                tempMol.MolId = Guid.NewGuid();

                CommonMol newNonPrimeryMol = await SAOwner.SetPrimery(selectedItem, tempMol);
                PrimeryMol = new CommonMol();
                DataHolder.PrimeryMol = null;
                selectedItem.IsPrimery = false;
                NonPrimeryMols.Add(selectedItem);
                dgvPrimaryMol.DataSource = null;
                dgvMol.DataSource = null;
                dgvMol.DataSource = NonPrimeryMols;

            }
        }

        private void pictureBoxRed_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxRed.BackgroundImage = DB3Client.Resource.nav_right_red_shadow;
        }

        private void pictureBoxRed_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxRed.BackgroundImage = DB3Client.Resource.nav_right_red;
        }


        #endregion

        #region  // < =========== Settings Events =============> //
        private void btnVatSettings_Click(object sender, EventArgs e)
        {
            VatControl control = new VatControl() { Dock = DockStyle.Fill };
            panelSettings.Controls.Clear();
            panelSettings.Controls.Add(control);
        }

        private void btnDirectorySettings_Click(object sender, EventArgs e)
        {
            DirectoryLocationControl control = new DirectoryLocationControl {Dock = DockStyle.Fill};
            panelSettings.Controls.Clear();
            panelSettings.Controls.Add(control);
        }

        #endregion

        #endregion


    }
}
