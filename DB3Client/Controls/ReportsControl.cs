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
            ReportBuySellControl control = new ReportBuySellControl() {Dock = DockStyle.Fill};
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


        private void pictureBox8_Click(object sender, EventArgs e)
        {
                   ReportDocumentsControl control1 = new ReportDocumentsControl() { Dock = DockStyle.Fill };
                    panelReportsNew.Controls.Clear();
                   panelReportsNew.Controls.Add(control1);
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.BackgroundImage = Resource.documents_icon_shadow;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackgroundImage = Resource.documents_icon1;
        }

        #endregion


    }
}
