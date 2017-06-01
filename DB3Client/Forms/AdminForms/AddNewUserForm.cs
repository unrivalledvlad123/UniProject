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
    public partial class AddNewUserForm : MLForm
    {
       public AddNewUserForm()
        {
            InitializeComponent();
            cbUserRole.DataSource = Enum.GetValues(typeof(Enums.UserRoles));
          }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPassword.Text) && !string.IsNullOrEmpty(tbPassword2.Text) && tbPassword.Text != tbPassword2.Text)
            {
                labelError.Text = "password_mismatch";
                labelError.Visible = true;
            }
            else if (!string.IsNullOrEmpty(tbPassword.Text) && !string.IsNullOrEmpty(tbPassword2.Text) && tbPassword.Text == tbPassword2.Text)
            {
                CommonUser  newUser = new CommonUser();
                newUser.Username = tbUsername.Text;
                newUser.Password = tbPassword.Text;
                newUser.AssignedTo = tbAssignedTo.Text;
                newUser.OwnerId = DataHolder.Owner.OwnerId;
                Enums.UserRoles role;
                Enum.TryParse(cbUserRole.SelectedValue.ToString(), out role);
                newUser.Role = (int) role;
                newUser.IsRestrictedUser = cbRestricteduser.Checked;
                // switch between new user and existing user
                var success = await SAUsers.PostCreateUser(newUser);
               
                if (success)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    labelError.Text = "user_already_exist";
                    labelError.Visible = true;
                }
            }
            else
            {
                labelError.Text = "empty_username_or_password";
                labelError.Visible = true;
            }

        }

    }
}
