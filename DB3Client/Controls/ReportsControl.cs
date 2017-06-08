using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Common;
using Common.Classes.DTOs;
using Common.Classes.ReportClasses;
using DB3Client.Controls.ReportControls;
using DB3Client.Controls.ReportControls.Reports;
using DB3Client.Properties;
using DB3Client.ServiceAccess;

namespace DB3Client.Controls
{
    [Permission(PermissionId = "DCBB48FB-5B18-4395-AF8C-B332C15A91E1", PermissionName = "test", PermissionLocation = "report_control", PermissionControlRoot = "report_control")]
    [Permission(PermissionId = "DCBB48FB-5B18-4335-AF8C-B332C15A91E1", PermissionName = "test", PermissionLocation = "randomForm", PermissionControlRoot = "report_control")]
    public partial class ReportsControl : MetroFramework.Controls.MetroUserControl
    {


        public ReportsControl()
        {
            InitializeComponent();
            tabControlReports.SelectedTab = metroTabPage1;

        }

        #region // < ========== Events ============ > //

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DiagramBuySellControl control = new DiagramBuySellControl() {Dock = DockStyle.Fill};
            panelDiagrams.Controls.Clear();
            panelDiagrams.Controls.Add(control);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Resource.apps_kchart_report__shadow;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Resource.apps_kchart_report;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DiagramGoodsMovementControl control = new DiagramGoodsMovementControl() {Dock = DockStyle.Fill};
            panelDiagrams.Controls.Clear();
            panelDiagrams.Controls.Add(control);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Resource._1495654881_bar_chart_shadow;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Resource._1495654881_bar_chart;
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ReportBuySellControl control = new ReportBuySellControl() { Dock = DockStyle.Fill };
            panelReportsNew.Controls.Clear();
            panelReportsNew.Controls.Add(control);
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.BackgroundImage = Resource.report_sales_shadow;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackgroundImage = Resource.report_sales;
        }

        
        #endregion


    }
}
