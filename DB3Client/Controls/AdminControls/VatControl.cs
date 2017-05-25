using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.Classes;
using DB3Client.ServiceAccess;

namespace DB3Client.Controls.AdminControls
{
    public partial class VatControl : MetroFramework.Controls.MetroUserControl
    {
        public CommonSettings Settings = new CommonSettings();
        public VatControl()
        {
            InitializeComponent();
            cbItemTypes.DataSource = Enum.GetValues(DataHolder.UserCulture.TwoLetterISOLanguageName == "bg" ? typeof(Enums.ItemTypesBg) : typeof(Enums.ItemTypes));
            var temp = DataHolder.Settings.VatSettingsByGroup.FirstOrDefault(p => p.Key == cbItemTypes.SelectedIndex);
            tbVatMultiplier.Value = temp.Value * 100;
        }

        private async void btnSaveSettings_Click(object sender, EventArgs e)
        {

            KeyValuePair<int, decimal> newRecord = new KeyValuePair<int, decimal>(cbItemTypes.SelectedIndex, tbVatMultiplier.Value / 100);
            bool success = await SASettings.PostUpdateSettings(newRecord);
            if (success)
            {
                labelErrorSettings.Text = "success_error_settings";
                labelErrorSettings.ForeColor = Color.Green;
                labelErrorSettings.Visible = true;
                DataHolder.Settings = await SASettings.getUserSettings();
            }
            else
            {
                labelErrorSettings.Text = "fail_error_settings";
                labelErrorSettings.ForeColor = Color.Red;
                labelErrorSettings.Visible = true;
            }
        }

        private void cbItemTypes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var temp = DataHolder.Settings.VatSettingsByGroup.FirstOrDefault(p => p.Key == cbItemTypes.SelectedIndex);
            tbVatMultiplier.Value = temp.Value*100;
            labelErrorSettings.Visible = false;
        }
    }
}
