using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB3Client.Properties;
using MetroFramework.Controls;

namespace DB3Client.Controls.AdminControls
{
    public partial class GeneralSettingsControl : MetroUserControl
    {
        public GeneralSettingsControl()
        {
            InitializeComponent();
            cbMapping.Checked = Settings.Default.ItemMapping;
        }

        private void cbMapping_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.ItemMapping = cbMapping.Checked;
        }
    }
}
