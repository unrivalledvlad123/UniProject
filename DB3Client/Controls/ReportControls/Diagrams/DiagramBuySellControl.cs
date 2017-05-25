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
using DB3Client.ServiceAccess;

namespace DB3Client.Controls.ReportControls
{
    public partial class DiagramBuySellControl : MetroFramework.Controls.MetroUserControl
    {
        public DiagramBuySellControl()
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
            chartSales.Series["Items"].Points.Clear();
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
            Dictionary<string, int> result = await SAReports.PostGenerateDiagram(dto);
            if (result == null || result.Count == 0)
            {
                labelErrorDiagram.Visible = true;
                labelErrorDiagram.Text = DataHolder.GetString("no_results_found");
            }
            else
            {
                List<KeyValuePair<string, int>> parsedResults = new List<KeyValuePair<string, int>>();
                if (!cbItemTypeDiagram.Checked)
                {
                    foreach (KeyValuePair<string, int> row in result)
                    {
                        if (DataHolder.UserCulture.TwoLetterISOLanguageName == "bg")
                        {
                            int value;
                            int.TryParse(row.Key, out value);
                            Enums.ItemTypesBg types = (Enums.ItemTypesBg) value;
                            parsedResults.Add(new KeyValuePair<string, int>(types.ToString(), row.Value));
                        }
                        else
                        {
                            int value;
                            int.TryParse(row.Key, out value);
                            Enums.ItemTypes types = (Enums.ItemTypes) value;
                            parsedResults.Add(new KeyValuePair<string, int>(types.ToString(), row.Value));
                        }
                    }
                }
                else
                {
                    parsedResults.AddRange(result.Select(row => new KeyValuePair<string, int>(row.Key, row.Value)));
                }

                foreach (var row in parsedResults)
                {
                    chartSales.Series["Items"].Points.AddXY(row.Key, row.Value);
                }
            }
        }

        private void cbItemTypeDiagram_CheckedChanged(object sender, EventArgs e)
        {
            cbItemTypesDiagram.Enabled = cbItemTypeDiagram.Checked;
        }

    }
}
