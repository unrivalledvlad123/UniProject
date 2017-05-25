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
using Common.Forms.Base;
using DB3Client.ServiceAccess;
using iTextSharp.text;

namespace DB3Client.Forms
{
    public partial class LoginForm : MLForm
    {

        public static bool Trigger;

        public LoginForm()
        {
            InitializeComponent();
            cbLanguage.DataSource = Constants.SupportedLanguages;
            cbServer.DataSource = Constants.AvailableServers;
            Trigger = true;

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (Trigger)
            {
                Trigger = false;
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
                    DataHolder.ServerAddress = cbServer.Text;
                    CommonUser user = await SAUsers.Login(tbUsername.Text, tbPassword.Text);
                    if (user != null)
                    {

                        DataHolder.CurrnetUserId = user.UserId;
                        DataHolder.OwnerId = user.OwnerId;
                        DataHolder.Username = user.Username;
                        DataHolder.UserType = user.Role;
                        DataHolder.Settings = await SASettings.getUserSettings();
                        List<CommonMol> allMols = await SAOwner.getAllMols(user.OwnerId);
                        foreach (var mol in allMols)
                        {
                            if (mol.IsPrimery)
                            {
                                DataHolder.PrimeryMol = mol;
                                break;
                            }
                        }

                        MainForm form = new MainForm();
                        Hide();

                        if (form.ShowDialog() == DialogResult.Cancel)
                        {
                            Trigger = true;
                            labelError.Visible = false;
                            Show();
                            tbPassword.Text = string.Empty;
                            tbUsername.Text = DataHolder.Username;

                            //clear previus data
                            DataHolder.CurrnetUserId = Guid.Empty;
                            DataHolder.OwnerId = Guid.Empty;
                            DataHolder.ServerAddress = string.Empty;
                            DataHolder.Username = string.Empty;
                            DataHolder.UserType = 99;
                            DataHolder.UserCulture = new CultureInfo("en-US");
                            DataHolder.PrimeryMol = null;
                            DataHolder.Settings = new CommonSettings();
                        }
                    }
                    else
                    {
                        labelError.Visible = true;
                        labelError.Text = DataHolder.GetString("invalid_username_or_password");
                        Trigger = true;
                    }
                }
                else
                {
                    labelError.Visible = true;
                    labelError.Text = DataHolder.GetString("invalid_username_or_password");
                    Trigger = true;
                }
            }
        }
    }

}


