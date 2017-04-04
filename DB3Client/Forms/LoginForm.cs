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

namespace DB3Client.Forms
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
            cbLanguage.DataSource = Constants.SupportedLanguages;

        }

        private void btnLogin_Click(object sender, EventArgs e)
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


            MainForm form = new MainForm();
            Hide();
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                Show();
            }

        }
    }
}
