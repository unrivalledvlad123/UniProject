using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.Classes;
using Common.Forms.Base;
using DB3Client.ServiceAccess;

namespace DB3Client.Forms.ContractsForms
{
    public partial class AddEditContractForm : MLForm
    {
        protected CommonContract contract;
        protected CommonMol mol;
        public AddEditContractForm(CommonContract c, CommonMol m)
        {
            InitializeComponent();
            contract = c;
            mol = m;

            tbAdressContract.Text = contract.Address;
            tbBulstatNumberContract.Text = contract.Bulstat;
            tbCompanyNameContract.Text = contract.CompanyName;
            tbEmailContract.Text = contract.Email;
            tbPhoneContract.Text = contract.Phone;
            tbVatNumberContract.Text = contract.VatNumber;
            tbAdressMolContract.Text = mol.Address;
            tbEmailMolContract.Text = mol.Email;
            tbFirstNameMol.Text = mol.FirstName;
            tbLastNameMol.Text = mol.LastName;
            tbPhoneMolContract.Text = mol.Phone;

        }
        
        private async void btnSaveContract_Click(object sender, EventArgs e)
        {

            contract.Address = tbAdressContract.Text;
            contract.Bulstat = tbBulstatNumberContract.Text;
            contract.CompanyName = tbCompanyNameContract.Text;
            contract.Email = tbEmailContract.Text;
           // contract.PartnerId = Guid.Empty;
            contract.Phone = tbPhoneContract.Text;
            contract.VatNumber = tbVatNumberContract.Text;

            if (contract.PartnerId == Guid.Empty)
            {
                Guid partnerId = await SAContract.PostCreateContract(contract);

                if (partnerId == Guid.Empty)
                {
                    return;
                }

                //  mol.MolId = Guid.Empty;
                mol.OwnerId = partnerId;
            }
            else
            {
                bool isUpdated = await SAContract.PostUpdateContract(contract);
                if (!isUpdated)
                {
                    return;
                }
            }
            mol.Address = tbAdressMolContract.Text;
            mol.Email = tbEmailMolContract.Text;
            mol.FirstName = tbFirstNameMol.Text;
            mol.LastName = tbLastNameMol.Text;
            mol.Phone = tbPhoneMolContract.Text;
            bool success = false;
            if (mol.MolId == Guid.Empty)
            {
                success = await SAOwner.PostCreateMol(mol);

            }
            else
            {
                success = await SAOwner.PostUpdateMol(mol);

            }
            

            if (!success)
            {
                return;
            }



            DialogResult = DialogResult.OK;


        }
    }
}
