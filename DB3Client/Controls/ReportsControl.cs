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
using Common;
using Common.Classes.DTOs;
using Common.Classes.ReportClasses;
using DB3Client.Properties;
using DB3Client.ServiceAccess;

namespace DB3Client.Controls
{
    public partial class ReportsControl : MetroFramework.Controls.MetroUserControl
    {
        public List<ReportBuySell> ReportResult = new List<ReportBuySell>();
        public ReportsControl()
        {
            InitializeComponent();
            tabControlReports.SelectedTab = metroTabPage1;
            SetGridColomns();
            rbItemType.Checked = true;
            if (DataHolder.UserCulture.TwoLetterISOLanguageName == "bg")
            {
                cbReportType.DataSource = Enum.GetValues(typeof(Enums.ReportTypeBg));
                cbItemType.DataSource = Enum.GetValues(typeof(Enums.ItemTypesBg));
            }
            else
            {
                cbReportType.DataSource = Enum.GetValues(typeof(Enums.ReportType));
                cbItemType.DataSource = Enum.GetValues(typeof(Enums.ItemTypes));
            }
            CheckButtonState();
            
        }
        
        #region // < ========== Events ============ > //

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            bool trigger = true;
            if (rbSpecificItem.Checked)
            {
                if (string.IsNullOrWhiteSpace(tbSpecificItem.Text))
                {
                    labelError.Text = "invalid_data";
                    labelError.Visible = true;
                    trigger = false;
                }
            }
            if (trigger)
            {
                labelError.Visible = false;
                int item;
                int report;
                if (DataHolder.UserCulture.TwoLetterISOLanguageName == "bg")
                {
                    Enums.ReportTypeBg reportType;
                    Enum.TryParse(cbReportType.SelectedValue.ToString(), out reportType);
                    report = (int) reportType;
                    Enums.ItemTypesBg itemType;
                    Enum.TryParse(cbItemType.SelectedValue.ToString(), out itemType);
                    item = (int) itemType;
                }
                else
                {
                    Enums.ReportType reportType;
                    Enum.TryParse(cbReportType.SelectedValue.ToString(), out reportType);
                    report = (int) reportType;
                    Enums.ItemTypes itemType;
                    Enum.TryParse(cbItemType.SelectedValue.ToString(), out itemType);
                    item = (int) itemType;
                }
                ReportDTO dto = new ReportDTO();
                dto.FromDate = dtFrom.Value;
                dto.ToDate = dtTo.Value;
                dto.IsItem = rbSpecificItem.Checked;
                dto.IsType = rbItemType.Checked;
                dto.ItemCode = tbSpecificItem.Text;
                dto.ItemType = item;
                dto.ReportType = report;

                List<ReportBuySell> result = await SAReports.PostGenerateReport(dto);
                if (result.Count == 0)
                {
                    labelError.Text = "no_results_found";
                    labelError.Visible = true;
                    dgvResults.DataSource = null;
                    CheckButtonState();
                }
                else
                {
                    if (DataHolder.UserCulture.TwoLetterISOLanguageName == "bg")
                    {
                        foreach (var row in result)
                        {
                            Enums.UnitTypesBg types = (Enums.UnitTypesBg) row.Unit;
                            row.UnitString = types.ToString();
                        }
                    }
                    else
                    {
                        foreach (var row in result)
                        {
                            Enums.UnitTypes types = (Enums.UnitTypes) row.Unit;
                            row.UnitString = types.ToString();
                        }
                    }
                    dgvResults.DataSource = result;
                    ReportResult = result;
                    CheckButtonState();
                }
            }
        }

        private void rbSpecificItem_CheckedChanged(object sender, EventArgs e)
        {
            cbItemType.Enabled = false;
            tbSpecificItem.Enabled = true;
        }

        private void rbItemType_CheckedChanged(object sender, EventArgs e)
        {
            cbItemType.Enabled = true;
            tbSpecificItem.Enabled = false;
        }

        private void tabControlReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var csv = new StringBuilder();
            foreach (var row in ReportResult)
            {
                Enums.UnitTypes types = (Enums.UnitTypes)row.Unit;
                string unit = types.ToString();
                var newLine = string.Format("{0},{1},{2},{3},{4}", row.Date, row.PriceEach, row.Quantity, unit, row.Total);
                csv.AppendLine(newLine);
            }
            File.WriteAllText(Settings.Default.InvoiceSaveLocation + @"\csv.csv", csv.ToString());
        }

        #endregion

        #region // < ============ Methods ===========> //

        public void SetGridColomns()
        {
            dgvResults.DataSource = null;
            dgvResults.Columns.Clear();
            dgvResults.AutoGenerateColumns = false;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.RowHeadersVisible = false;

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "date";
            c1.HeaderText = DataHolder.GetString("invoice_date");
            c1.DataPropertyName = "Date";
            c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvResults.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "price";
            c2.HeaderText = DataHolder.GetString("price_each");
            c2.DataPropertyName = "PriceEach";
            c2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvResults.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "quantity";
            c3.HeaderText = DataHolder.GetString("quantity");
            c3.DataPropertyName = "Quantity";
            c3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvResults.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "unit";
            c4.HeaderText = DataHolder.GetString("measurment_unit");
            c4.DataPropertyName = "UnitString";
            c4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvResults.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "total";
            c5.HeaderText = DataHolder.GetString("total");
            c5.DataPropertyName = "Total";
            c5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvResults.Columns.Add(c5);

        }

        public void CheckButtonState()
        {
            btnExport.Enabled = dgvResults.DataSource != null;
        }

        #endregion
        
    }
}
