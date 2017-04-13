﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.Classes;
using DB3Client.Forms;
using DB3Client.Forms.AdminForms;
using DB3Client.ServiceAccess;

namespace DB3Client.Controls
{
    public partial class AdminControl : MetroFramework.Controls.MetroUserControl
    {
        private static List<CommonUser> AllUsers;
        private static List<CommonMol> AllMols;


        public AdminControl()
        {
            InitializeComponent();
            SetGridColomns();
            SetGridColomnsMols();
            LoadData();
            LoadCompanyData();
            LoadMolList();

            tabControlAdmin.SelectedTab = metroTabPage1;

            
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
        }

        public async void LoadMolList()
        {
            AllMols = await SAOwner.getAllMols(DataHolder.Owner.OwnerId);
            dgvMol.DataSource = AllMols;
        }

        #endregion

        #region // < ====== Events =====> //

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
                CommonUser selectedItem = (CommonUser)dgvUsers.SelectedRows[0].DataBoundItem;
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
                CommonUser selectedItem = (CommonUser)dgvUsers.SelectedRows[0].DataBoundItem;
                bool success = await SAUsers.PostDeleteUser(selectedItem.UserId);
                if (success)
                {
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Error_deleting_user", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                CommonMol selectedItem = (CommonMol)dgvMol.SelectedRows[0].DataBoundItem;
                bool success = await SAOwner.PostDeleteMol(selectedItem.MolId);
                if (success)
                {
                    LoadMolList();
                }
                else
                {
                    MessageBox.Show("Error_deleting_mol", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

    }
}
