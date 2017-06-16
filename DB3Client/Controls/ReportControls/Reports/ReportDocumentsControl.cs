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

namespace DB3Client.Controls.ReportControls.Reports
{
    [Permission(PermissionId = "ECA1249A-015A-40F7-B0D6-35471B697B0D", PermissionName = "view_sale_receipt", PermissionLocation = "tab_reports", PermissionControlRoot = "reports")]
    [Permission(PermissionId = "2E96435F-1DC5-4420-B825-8025315606E4", PermissionName = "view_invoice", PermissionLocation = "tab_reports", PermissionControlRoot = "reports")]
    [Permission(PermissionId = "6EC31D7C-4C8B-44BB-8646-D597646AD5BA", PermissionName = "generate", PermissionLocation = "tab_reports", PermissionControlRoot = "reports")]
    [Permission(PermissionId = "A4C7707B-F0A4-40E0-B461-386BB264E210", PermissionName = "export_to_csv_d", PermissionLocation = "tab_reports", PermissionControlRoot = "reports")]


    public partial class ReportDocumentsControl : UserControl

    {
        public List<CommonContract> ListOfAllContracts = new List<CommonContract>();
        public ReportDocumentsControl()
        {
            InitializeComponent();
        }

        
    }
//    public async void LoadDataAsync()
//    {
//        // cbSearch.SelectedIndex = -1;
//        try
//        {
//           
//            AllContacts = await SAContract.GetAllContracts(cbSearchContract.Text);
//            cbSearchContract.DataSource = AllContacts;
//            cbSearchContract.SelectedIndex = -1;
//            cbSearchContract.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
//            cbSearchContract.AutoCompleteSource = AutoCompleteSource.ListItems;
//            cbSearchContract.DropDownStyle = ComboBoxStyle.DropDown;
//            // AllMols = await SAOwner.getAllMols(DataHolder.Owner.OwnerId);
//            CommonMol primeryMol = DataHolder.PrimeryMol;
//
//
//        }
//        catch (Exception e)
//        {
//            MessageBox.Show(e.Message, DataHolder.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
//        }
//    }
}
