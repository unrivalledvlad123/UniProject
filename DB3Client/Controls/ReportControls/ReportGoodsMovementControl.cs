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
using Common.Classes.DTOs;
using Common.Classes.ReportClasses;
using DB3Client.ServiceAccess;

namespace DB3Client.Controls.ReportControls
{
    public partial class ReportGoodsMovementControl : MetroFramework.Controls.MetroUserControl
    {
        public ReportGoodsMovementControl()
        {
            InitializeComponent();

            cbItemTypeDiagram.Checked = false;
            cbItemTypesDiagram.Enabled = false;
            if (DataHolder.UserCulture.TwoLetterISOLanguageName == "bg")
            {
                cbDiagramType.DataSource = Enum.GetValues(typeof(Enums.DiagramTypeBg));
                cbItemTypesDiagram.DataSource = Enum.GetValues(typeof(Enums.ItemTypesBg));
            }
            else
            {
                cbDiagramType.DataSource = Enum.GetValues(typeof(Enums.DiagramType));
                cbItemTypesDiagram.DataSource = Enum.GetValues(typeof(Enums.ItemTypes));
            }
        }

        private async void btnGenerateDiagram_Click(object sender, EventArgs e)
        {
            labelErrorDiagram.Visible = false;
            chartMovement.Series.Clear();
            int diagram;
            int temp1;
            if (DataHolder.UserCulture.TwoLetterISOLanguageName == "bg")
            {
                Enums.DiagramTypeBg diagramType;
                Enum.TryParse(cbDiagramType.SelectedValue.ToString(), out diagramType);
                diagram = (int) diagramType;
                Enums.ItemTypesBg temp;
                Enum.TryParse(cbItemTypesDiagram.SelectedValue.ToString(), out temp);
                temp1 = (int) temp;
            }
            else
            {
                Enums.DiagramType diagramType;
                Enum.TryParse(cbDiagramType.SelectedValue.ToString(), out diagramType);
                diagram = (int) diagramType;
                Enums.ItemTypes temp;
                Enum.TryParse(cbItemTypesDiagram.SelectedValue.ToString(), out temp);
                temp1 = (int) temp;
            }
            DiagramDTO dto = new DiagramDTO
            {
                ReportType = diagram,
                FromDate = dtFromDiagram.Value,
                ToDate = dtToDiagram.Value,
                IsType = cbItemTypeDiagram.Checked,
                ItemType = temp1

            };
            List<ReportMovement> result = await SAReports.PostGenerateDiagramMovement(dto);
            var counter = result.SelectMany(row => row.QuantityesList).Aggregate(0, (current, n) => current + n.Value);
                // check if everywhere is 0(empty result)
            if (counter == 0)
            {
                labelErrorDiagram.Visible = true;
                labelErrorDiagram.Text = DataHolder.GetString("no_results_found");
            }
            else
            {
                List<ReportMovement> parsedResults = new List<ReportMovement>();
                if (!cbItemTypeDiagram.Checked)
                {
                    foreach (ReportMovement row in result)
                    {
                        if (DataHolder.UserCulture.TwoLetterISOLanguageName == "bg")
                        {
                            int value;
                            int.TryParse(row.Name, out value);
                            Enums.ItemTypesBg types = (Enums.ItemTypesBg) value;
                            ReportMovement element = new ReportMovement();
                            element.Name = types.ToString();
                            element.QuantityesList = row.QuantityesList;
                            parsedResults.Add(element);
                        }
                        else
                        {
                            int value;
                            int.TryParse(row.Name, out value);
                            Enums.ItemTypes types = (Enums.ItemTypes) value;
                            ReportMovement element = new ReportMovement();
                            element.Name = types.ToString();
                            element.QuantityesList = row.QuantityesList;
                            parsedResults.Add(element);
                        }
                    }
                    foreach (var row in parsedResults)
                    {
                        chartMovement.Series.Add(row.Name);
                        foreach (var rowvalue in row.QuantityesList)
                        {
                            chartMovement.Series[row.Name].Points.AddXY(rowvalue.Key, rowvalue.Value);
                        }
                    }
                }
                else
                {
                    foreach (var row in result)
                    {
                        chartMovement.Series.Add(row.Name);
                        foreach (var rowvalue in row.QuantityesList)
                        {
                            chartMovement.Series[row.Name].Points.AddXY(rowvalue.Key, rowvalue.Value);
                        }
                    }
                }
            }
        }

        private void cbItemTypeDiagram_CheckedChanged(object sender, EventArgs e)
        {
            cbItemTypesDiagram.Enabled = cbItemTypeDiagram.Checked;
        }
    }
}
