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
