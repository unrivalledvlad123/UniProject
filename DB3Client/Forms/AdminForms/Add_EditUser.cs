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
using DB3Client.ServiceAccess;

namespace DB3Client.Forms.AdminForms
{
    public partial class Add_EditUser : MetroFramework.Forms.MetroForm
    {
        public Add_EditUser()
        {
            InitializeComponent();

            cbUserRole.DataSource = Enum.GetValues(typeof(Enums.UserRoles));
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPassword.Text) && !string.IsNullOrEmpty(tbPassword2.Text) && tbPassword.Text == tbPassword2.Text)
            {
                CommonUser newUser = new CommonUser();
                newUser.Password = tbPassword.Text;
                newUser.AssignedTo = tbAssignedTo.Text;
                newUser.Username = tbUsername.Text;
                await SAUsers.PostCreateUser(newUser);
            }

        }
    }
}
