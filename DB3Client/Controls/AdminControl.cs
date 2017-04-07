﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.Classes;
using DB3Client.Forms;
using DB3Client.Forms.AdminForms;

namespace DB3Client.Controls
{
    public partial class AdminControl : MetroFramework.Controls.MetroUserControl
    {
       public AdminControl()
        {
            InitializeComponent();
            SetGridColomns();
            //tabControlAdmin.SelectedTab = metroTabPage1;
         }
      
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
            c1.DataPropertyName = "username";
            c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvUsers.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "role";
            c2.HeaderText = DataHolder.GetString("administration_role");
            c2.DataPropertyName = "role";
            c2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvUsers.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "assignedTo";
            c3.HeaderText = DataHolder.GetString("assigned_to");
            c3.DataPropertyName = "assignedTo";
            c3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvUsers.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "registeredAt";
            c4.HeaderText = DataHolder.GetString("created_at");
            c4.DataPropertyName = "registeredAt";
            c4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvUsers.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "userId";
            c5.HeaderText = "UserID";
            c5.DataPropertyName = "userId";
            c5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c5.Visible = false;
            dgvUsers.Columns.Add(c5);

        }

        #region // <====== Utility Methodts ======> //



        #endregion

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                labelCompanyName.Text = editForm.Owner2.CompanyName;
                labelAddress.Text = editForm.Owner2.Address;
                labelEmail.Text = editForm.Owner2.Email;
                labelPhone.Text = editForm.Owner2.Phone;
                
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            Add_EditUser addForm = new Add_EditUser();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
