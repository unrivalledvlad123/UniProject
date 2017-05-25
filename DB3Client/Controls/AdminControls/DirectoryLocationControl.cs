using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB3Client.Controls.AdminControls
{
    public partial class DirectoryLocationControl : MetroFramework.Controls.MetroUserControl
    {
        public DirectoryLocationControl()
        {
            InitializeComponent();
            tbPdfSaveLocation.Text = Properties.Settings.Default.InvoiceSaveLocation;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.InvoiceSaveLocation = tbPdfSaveLocation.Text;
                labelError.Text = "success_error_settings";
                labelError.ForeColor = Color.Green;
                labelError.Visible = true;
                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {
                labelError.Text = "fail_error_settings";
                labelError.ForeColor = Color.Red;
                labelError.Visible = true;
            }
        }
    }
}
