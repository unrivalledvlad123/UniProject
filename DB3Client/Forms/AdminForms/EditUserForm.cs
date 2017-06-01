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

namespace DB3Client.Forms.AdminForms
{
    public partial class EditUserForm : MLForm
    {
        public CommonUser OldUser;
        public EditUserForm(CommonUser oldUser)
        {
            InitializeComponent();
            cbUserRole.DataSource = Enum.GetValues(typeof(Enums.UserRoles));
            cbPasswordChange.Checked = false;
            gbPasswordChange.Enabled = false;
            OldUser = oldUser;
            tbAssignedTo.Text = oldUser.AssignedTo;
            cbUserRole.Text = oldUser.RoleString;
            cbRestricteduser.Checked = oldUser.IsRestrictedUser;
        }

        private void mlCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            gbPasswordChange.Enabled = cbPasswordChange.Checked;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (cbPasswordChange.Checked)
            {
                if (!string.IsNullOrWhiteSpace(tbPassword.Text) && !string.IsNullOrWhiteSpace(tbPassword2.Text) && tbPassword.Text != tbPassword2.Text)
                {
                    labelError.Text = "password_mismatch";
                    labelError.Visible = true;
                }
                else if (!string.IsNullOrEmpty(tbPassword.Text) && !string.IsNullOrEmpty(tbPassword2.Text) && tbPassword.Text == tbPassword2.Text)
                {
                    CommonUser newUser = new CommonUser();
                    newUser.Password = tbPassword.Text;
                    newUser.AssignedTo = tbAssignedTo.Text;
                    newUser.OwnerId = DataHolder.Owner.OwnerId;
                    Enums.UserRoles role;
                    Enum.TryParse(cbUserRole.SelectedValue.ToString(), out role);
                    newUser.Role = (int)role;
                    newUser.UserId = OldUser.UserId;
                    newUser.IsRestrictedUser = cbRestricteduser.Checked;
                    var success = await SAUsers.PostEditUser(newUser);

                    if (success)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        labelError.Text = "invalid_user";
                        labelError.Visible = true;
                    }
                }
                else
                {
                    labelError.Text = "empty_username_or_password";
                    labelError.Visible = true;
                }
            }
            else
            {
                CommonUser newUser = new CommonUser();
                newUser.AssignedTo = tbAssignedTo.Text;
                newUser.OwnerId = DataHolder.Owner.OwnerId;
                Enums.UserRoles role;
                Enum.TryParse(cbUserRole.SelectedValue.ToString(), out role);
                newUser.Role = (int)role;
                newUser.UserId = OldUser.UserId;
                newUser.IsRestrictedUser = cbRestricteduser.Checked;
                var success = await SAUsers.PostEditUser(newUser);

                if (success)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    labelError.Text = "invalid_user";
                    labelError.Visible = true;
                }
            }
        }

     }
}
