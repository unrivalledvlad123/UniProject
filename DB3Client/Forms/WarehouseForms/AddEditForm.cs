using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Classes;
using Common.Forms.Base;

namespace DB3Client.Forms.WarehouseForms
{
    public partial class AddEditForm : MLForm
    {
        public static CommonItem OldItem;
        public AddEditForm(CommonItem oldItem)
        {
            InitializeComponent();
            if (oldItem != null)
            {
                tbNameGoods.Text = !string.IsNullOrEmpty(oldItem.Name) ? oldItem.Name : "";
                tbTypeGoods.Text  = oldItem.Type.ToString();
                tbDescriptionGoods.Text = !string.IsNullOrEmpty(oldItem.Description) ? oldItem.Description : "";
                
            }
            OldItem = oldItem;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNameGoods.Text) || !string.IsNullOrEmpty(tbTypeGoods.Text))
            {

            }
            else
            {
                mlErrorError.Visible = true;
                mlErrorError.Text = "enter_text_error";
            }
        }

   
    }
}
