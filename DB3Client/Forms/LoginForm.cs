using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.Classes;
using DB3Client.ServiceAccess;

namespace DB3Client.Forms
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        
        public LoginForm()
        {
            InitializeComponent();
            cbLanguage.DataSource = Constants.SupportedLanguages;
          
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
           
            DataHolder.Init();
            switch (cbLanguage.SelectedValue.ToString())
            {
                case "Български":
                    DataHolder.UserCulture = new CultureInfo("bg-BG");
                    break;
                case "English":
                    DataHolder.UserCulture = new CultureInfo("en-US");
                    break;
                default:
                    DataHolder.UserCulture = new CultureInfo("en-US");
                    break;
            }

            if (!string.IsNullOrEmpty(tbUsername.Text) && !string.IsNullOrEmpty(tbPassword.Text))
            {
                CommonUser user = await SAUsers.Login(tbUsername.Text, tbPassword.Text);
                if (user != null)
                {

                    DataHolder.CurrnetUserId = user.UserId;
                    DataHolder.OwnerId = user.OwnerId;
                    DataHolder.ServerAddress = tbServer.Text;
                    DataHolder.Username = user.Username;
                    DataHolder.UserType = user.Role;

                    MainForm form = new MainForm();
                    Hide();

                    if (form.ShowDialog() == DialogResult.Cancel)
                    {
                        labelError.Visible = false;
                        Show();
                        tbPassword.Text = string.Empty;
                        tbUsername.Text = DataHolder.Username;
                        tbServer.Text = DataHolder.ServerAddress;

                        //clear previus data
                        DataHolder.CurrnetUserId = Guid.Empty;
                        DataHolder.OwnerId = Guid.Empty;
                        DataHolder.ServerAddress = string.Empty;
                        DataHolder.Username = string.Empty;
                        DataHolder.UserType = 99;
                        DataHolder.UserCulture = new CultureInfo("en-US");
                    }
                }
            }
            else
            {
                labelError.Visible = true;
                labelError.Text = DataHolder.GetString("invalid_username_or_password");
                labelError.ForeColor = Color.Red;
            }
        }
    }

}


