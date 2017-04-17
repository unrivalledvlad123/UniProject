using System;
using System.Windows.Forms;
using Common;
using Common.Classes;
using Common.Forms.Base;
using DB3Client.ServiceAccess;

namespace DB3Client.Forms.AdminForms
{
    public partial class EditCompanyForm : MLForm
    {

        public CompanyOwner Owner2;
        
        public EditCompanyForm()
        {
            InitializeComponent();
            Owner2 = new CompanyOwner();
            tbBulstat.Text = !string.IsNullOrEmpty(DataHolder.Owner.Bulstat) ? DataHolder.Owner.Bulstat : "";
            tbVatNumber.Text = !string.IsNullOrEmpty(DataHolder.Owner.VatNumber) ? DataHolder.Owner.VatNumber : "";
            tbAddress.Text = !string.IsNullOrEmpty(DataHolder.Owner.Address) ? DataHolder.Owner.Address : ""; ;
            tbCompanyName.Text = !string.IsNullOrEmpty(DataHolder.Owner.CompanyName) ? DataHolder.Owner.CompanyName : "";
            tbEmail.Text = !string.IsNullOrEmpty(DataHolder.Owner.Email) ? DataHolder.Owner.Email : "";
            tbPhone.Text = !string.IsNullOrEmpty(DataHolder.Owner.Phone) ? DataHolder.Owner.Phone : "";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            Owner2.Address = tbAddress.Text;
            Owner2.CompanyName = tbCompanyName.Text;
            Owner2.Email = tbEmail.Text;
            Owner2.Phone = tbPhone.Text;
            Owner2.Bulstat = tbBulstat.Text;
            Owner2.VatNumber = tbVatNumber.Text;
            Owner2.OwnerId = DataHolder.Owner.OwnerId;
            
            bool success = await SAOwner.PostUpdateOwner(Owner2);
            if (success)
            {
                DataHolder.Owner.VatNumber = Owner2.VatNumber;
                DataHolder.Owner.Address = Owner2.Address;
                DataHolder.Owner.Bulstat = Owner2.Bulstat;
                DataHolder.Owner.CompanyName = Owner2.CompanyName;
                DataHolder.Owner.Email = Owner2.Email;
                DataHolder.Owner.Phone = Owner2.Phone;
                DialogResult = DialogResult.OK;
            }
            else
            {
                labelError.Visible = true;
            }

        }
    }
}
