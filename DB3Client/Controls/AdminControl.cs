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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DB3Client.Controls
{
    [Permission(PermissionId = "B762587D-D868-456A-BB05-547D7C292DD5", PermissionName = "add_new_user", PermissionLocation = "manage_users",PermissionControlRoot = "administration")]
    [Permission(PermissionId = "AEE0DF0D-94AE-488D-8F50-E5185BF56499", PermissionName = "edit_user", PermissionLocation = "manage_users", PermissionControlRoot = "administration")]
    [Permission(PermissionId = "99CEE3E2-6AD4-4A3C-8722-3363F98218A9", PermissionName = "delete_user", PermissionLocation = "manage_users", PermissionControlRoot = "administration")]
    [Permission(PermissionId = "6A1D1F0D-7742-4AC7-901F-D1ED22F05DD7", PermissionName = "edit_company_info", PermissionLocation = "manage_company", PermissionControlRoot = "administration")]
    [Permission(PermissionId = "79DC9C51-F2F9-4FA6-90B5-B762CAFE2A15", PermissionName = "edit_mol", PermissionLocation = "manage_company", PermissionControlRoot = "administration")]
    [Permission(PermissionId = "E8962FA8-C653-49BB-AAA7-8ACA9D3E1A11", PermissionName = "delete_mol", PermissionLocation = "manage_company", PermissionControlRoot = "administration")]
    [Permission(PermissionId = "2A1F186A-1CC5-4830-BDE9-4E489753C297", PermissionName = "add_mol", PermissionLocation = "manage_company", PermissionControlRoot = "administration")]
    [Permission(PermissionId = "E008B27F-52FA-4D1A-8C35-1570F1EBE6DC", PermissionName = "make_primery", PermissionLocation = "manage_company", PermissionControlRoot = "administration")]
    [Permission(PermissionId = "3374E66E-031E-4C5A-A42E-4ECE01E0B439", PermissionName = "remove_primery", PermissionLocation = "manage_company", PermissionControlRoot = "administration")]
    [Permission(PermissionId = "B97FE6B2-CFD4-4656-91FB-FAC579798A93", PermissionName = "vat_settings", PermissionLocation = "settings_tab", PermissionControlRoot = "administration")]
    [Permission(PermissionId = "B5EA5576-4597-47CD-AA49-F8C83ADFED04", PermissionName = "directory_settings", PermissionLocation = "settings_tab", PermissionControlRoot = "administration")]
    [Permission(PermissionId = "E395707A-7A50-4E82-801D-6CBB8931A8A2", PermissionName = "promotion_settings", PermissionLocation = "settings_tab", PermissionControlRoot = "administration")]
    [Permission(PermissionId = "3DBBFE0B-F340-4709-BB76-C60E0871032A", PermissionName = "general_settings", PermissionLocation = "settings_tab", PermissionControlRoot = "administration")]
    public partial class AdminControl : MetroFramework.Controls.MetroUserControl
    {
        List<TreeNode> allNodes = new List<TreeNode>();
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
            BuildPermissionsTree();
            Utils.AjustUserAccess(this);

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
            dgvUsers.DataSource = string.IsNullOrWhiteSpace(tbSearchUser.Text) ? AllUsers : AllUsers.Where(p => p.Username.Contains(tbSearchUser.Text)).ToList();
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


        public void BuildPermissionsTree()
        {
            List<PermissionAttribute> allPermissionAttributes = Utils.GetPermissionAttributes();

            foreach (var atribute in allPermissionAttributes)
            {
                TreeNode node = new TreeNode();
                node.Text = DataHolder.GetString(atribute.PermissionControlRoot);
               // node.Tag = atribute.PermissionId;
                node.Name = atribute.PermissionControlRoot;
                if (!treeViewPermissions.Nodes.ContainsKey(atribute.PermissionControlRoot))
                {
                    treeViewPermissions.Nodes.Add(node);
                }
            }
            foreach (var location in allPermissionAttributes)
            {
                TreeNode node = new TreeNode();
                node.Text = DataHolder.GetString(location.PermissionLocation);
               // node.Tag = location.PermissionId;
                node.Name = location.PermissionLocation;
                if (treeViewPermissions.Nodes.ContainsKey(location.PermissionControlRoot))
                {
                    if (!treeViewPermissions.Nodes[location.PermissionControlRoot].Nodes.ContainsKey(node.Name))
                    {
                        treeViewPermissions.Nodes[location.PermissionControlRoot].Nodes.Add(node);
                    }
                }
            }
            foreach (var action in allPermissionAttributes)
            {
                TreeNode node = new TreeNode();
                node.Text = DataHolder.GetString(action.PermissionName);
                node.Tag = action.PermissionId;
                node.Name = action.PermissionName;
                if (treeViewPermissions.Nodes.ContainsKey(action.PermissionControlRoot))
                {
                    if (treeViewPermissions.Nodes[action.PermissionControlRoot].Nodes.ContainsKey(action.PermissionLocation))
                    {
                        if (!treeViewPermissions.Nodes[action.PermissionControlRoot].Nodes[action.PermissionLocation].Nodes.ContainsKey(node.Name))
                        {
                            treeViewPermissions.Nodes[action.PermissionControlRoot].Nodes[action.PermissionLocation].Nodes.Add(node);
                        }
                    }
                }
            }
            treeViewPermissions.ExpandAll();
        }

        public void CheckPermission()
        {

            if (dgvUsers.SelectedRows.Count == 1 && dgvUsers.SelectedRows[0].DataBoundItem != null)
            {
                CommonUser selectedUser = (CommonUser) dgvUsers.SelectedRows[0].DataBoundItem;
                allNodes.Clear();
                Dictionary<string, bool> userPermission = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, bool>>(selectedUser.Permissions);
                foreach (TreeNode node in treeViewPermissions.Nodes)
                {
                    GetNodesRecursive(node);
                }

                foreach (TreeNode node in allNodes)
                {
                    if (node.Tag == null) continue;
                    if (userPermission == null)
                    {
                        node.Checked = false;
                    }
                    else
                    {
                        if (userPermission.ContainsKey(node.Tag.ToString()))
                        {
                            node.Checked = userPermission[node.Tag.ToString()];
                        }
                        else
                        {
                            node.Checked = false;
                        }
                    }
                }
            }
        }

        public void GetNodesRecursive(TreeNode oParentNode)
        {
            allNodes.Add(oParentNode);
            foreach (TreeNode oSubNode in oParentNode.Nodes)
            {
                GetNodesRecursive(oSubNode);
            }
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
                btnSavePermissions.Enabled = false;
            }
            else
            {
                btnEditUser.Enabled = true;
                btnDeleteUser.Enabled = true;
                btnSavePermissions.Enabled = true;
            }
            Dictionary<string, bool> userPermission = JsonConvert.DeserializeObject<Dictionary<string, bool>>(DataHolder.UserPermissions);
            if (userPermission != null)
            {
                if (userPermission.ContainsKey(btnEditUser.Tag.ToString()))
                {
                    if (dgvUsers.SelectedRows.Count == 1)
                    {
                        btnEditUser.Enabled = userPermission[btnEditUser.Tag.ToString()];
                    }
                    else
                    {
                        btnEditUser.Enabled = false;
                    }

                }
                else
                {
                    btnEditUser.Enabled = false;
                }
                if (userPermission.ContainsKey(btnDeleteUser.Tag.ToString()))
                {
                    if (dgvUsers.SelectedRows.Count == 1)
                    {
                        btnDeleteUser.Enabled = userPermission[btnDeleteUser.Tag.ToString()];
                    }
                    else
                    {
                        btnDeleteUser.Enabled = false;
                    }
                }
                else
                {
                    btnDeleteUser.Enabled = false;
                }
            }

            CheckPermission();
            if (dgvUsers.SelectedRows.Count ==1 && dgvUsers.SelectedRows[0]!= null)
            {
                CommonUser user = (CommonUser)dgvUsers.SelectedRows[0].DataBoundItem;
                if (user.UserId == DataHolder.CurrnetUserId)
                {
                    btnSavePermissions.Enabled = false;
                }
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

        private void tbSearchUser_TextChanged(object sender, EventArgs e)
        {
            dgvUsers.DataSource = !string.IsNullOrWhiteSpace(tbSearchUser.Text) ? AllUsers.Where(p => p.Username.Contains(tbSearchUser.Text)).ToList() : AllUsers;
        }

        private async void btnSavePermissions_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 1 && dgvUsers.SelectedRows[0] != null)
            {
                CommonUser selectedItem = (CommonUser) dgvUsers.SelectedRows[0].DataBoundItem;
                Dictionary<string, bool> newPermissions = new Dictionary<string, bool>();
                foreach (TreeNode node in allNodes)
                {
                    if (node.Tag == null) continue;
                    newPermissions.Add(node.Tag.ToString(), node.Checked);
                }

                var output = Newtonsoft.Json.JsonConvert.SerializeObject(newPermissions);
                bool success = await SAUsers.PostUpdateUserPermissions(selectedItem.UserId, output);

                if (success)
                {
                    labelError.Text = "success_error_settings";
                    labelError.ForeColor = Color.Green;
                    labelError.Visible = true;
                    LoadData();
                }
                else
                {
                    labelError.Text = "fail_error_settings";
                    labelError.ForeColor = Color.Red;
                    labelError.Visible = true;
                }
            }
        }
        private void dgvUsers_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }

        private void treeViewPermissions_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
        }

        private void CheckTreeViewNode(TreeNode node, bool isChecked)
        {
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;

                if (item.Nodes.Count > 0)
                {
                    CheckTreeViewNode(item, isChecked);
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
            Dictionary<string, bool> userPermission = JsonConvert.DeserializeObject<Dictionary<string, bool>>(DataHolder.UserPermissions);
            if (userPermission != null)
            {
                if (userPermission.ContainsKey(btnEditMol.Tag.ToString()))
                {
                    if (dgvMol.SelectedRows.Count == 1)
                    {
                        btnEditMol.Enabled = userPermission[btnEditMol.Tag.ToString()];
                    }
                    else
                    {
                        btnEditMol.Enabled = false;
                    }

                }
                else
                {
                    if (dgvMol.SelectedRows.Count == 1)
                    {
                        btnEditMol.Enabled = false;
                    }
                }
                if (userPermission.ContainsKey(btnDeleteMol.Tag.ToString()))
                {
                    if (dgvMol.SelectedRows.Count == 1)
                    {
                        btnDeleteMol.Enabled = userPermission[btnDeleteMol.Tag.ToString()];
                    }
                    else
                    {
                        btnDeleteMol.Enabled = false;
                    }
                }
                else
                {
                    if (dgvMol.SelectedRows.Count == 1)
                    {
                        btnDeleteMol.Enabled = false;
                    }
                }
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
        private void mlButton1_Click(object sender, EventArgs e)
        {
            PromotionControl control = new PromotionControl() { Dock = DockStyle.Fill };
            panelSettings.Controls.Clear();
            panelSettings.Controls.Add(control);
        }
        private void btnGenerealSettings_Click(object sender, EventArgs e)
        {
            GeneralSettingsControl control = new GeneralSettingsControl() { Dock = DockStyle.Fill };
            panelSettings.Controls.Clear();
            panelSettings.Controls.Add(control);
        }





        #endregion

        #endregion

       
    }

}
