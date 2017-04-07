using System;
using Common;
using Common.Classes;

namespace DB3Client.Forms.AdminForms
{
    public partial class EditForm : MetroFramework.Forms.MetroForm
    {

        public CompanyOwner Owner2;
        
        public EditForm()
        {
            InitializeComponent();
            Owner2 = new CompanyOwner();
            //TODO fix after owner is properly saved


            //tbAddress.Text = DataHolder.Owner.Address;
            //tbCompanyName.Text = DataHolder.Owner.CompanyName;
            //tbEmail.Text = DataHolder.Owner.Email;
            //tbPhone.Text = DataHolder.Owner.Phone;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Owner2.Address = tbAddress.Text;
            Owner2.CompanyName = tbCompanyName.Text;
            Owner2.Email = tbEmail.Text;
            Owner2.Phone = tbPhone.Text;
        }
    }
}
