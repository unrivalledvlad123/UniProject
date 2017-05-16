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

namespace DB3Client.Forms.AdminForms
{
    public partial class AddEditMolForm : MLForm
    {
        public static CommonMol OldMol;

        public AddEditMolForm(CommonMol oldMol)
        {
            InitializeComponent();
            if (oldMol != null)
            {
                tbFirstname.Text = !string.IsNullOrEmpty(oldMol.FirstName) ? oldMol.FirstName : "";
                tbLastname.Text = !string.IsNullOrEmpty(oldMol.LastName) ? oldMol.LastName : "";
                tbAddress.Text = !string.IsNullOrEmpty(oldMol.Address) ? oldMol.Address : "";
                tbPhone.Text = !string.IsNullOrEmpty(oldMol.Email) ? oldMol.Email : "";
                tbEmail.Text = !string.IsNullOrEmpty(oldMol.Phone) ? oldMol.Phone : "";
            }
            OldMol = oldMol;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            CommonMol mol = new CommonMol();
            mol.MolId = OldMol?.MolId ?? Guid.Empty;  
            mol.OwnerId = DataHolder.Owner.OwnerId;
            mol.Address = tbAddress.Text;
            mol.Email = tbPhone.Text;
            mol.FirstName = tbFirstname.Text;
            mol.LastName = tbLastname.Text;
            mol.Phone = tbEmail.Text;
            bool success;
            if (OldMol == null)
            {
                 success = await SAOwner.PostCreateMol(mol);
            }
            else
            {
                success = await SAOwner.PostUpdateMol(mol); 
            }
            
            if (success)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                labelError.Visible = true;
            }
        }
    }
}
