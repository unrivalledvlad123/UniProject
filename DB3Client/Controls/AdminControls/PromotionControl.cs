using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.Classes;
using DB3Client.Properties;
using DB3Client.ServiceAccess;
using MetroFramework.Controls;

namespace DB3Client.Controls.AdminControls
{
    public partial class PromotionControl : MetroUserControl
    {
        public List<CommonDiscounts> Discounts = new List<CommonDiscounts>();
        public CommonDiscounts SelectedItem = new CommonDiscounts();

        public PromotionControl()
        {
            InitializeComponent();

            cbSelectedRow.DisplayMember = "TypeName";
            cbSelectedRow.DataSource = DataHolder.Settings.Discounts;
            labelError.Visible = false;
            cbEnablePromotions.Checked = Settings.Default.PromotionEnabled;
            cbSelectedRow.SelectedIndex = -1;
        }


        public bool CheckExsting()
        {
            var test = DataHolder.Settings.Discounts.FirstOrDefault(p => p.TypeName == tbDiscountTitle.Text);
            CommonDiscounts selected = (CommonDiscounts) cbSelectedRow.SelectedItem;
            if (test != null && selected.TypeName == test.TypeName)
            {
                return true;
            }
            if (test != null && selected.TypeName != test.TypeName)
            {
                return false;
            }
            return true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbDiscountTitle.Text))
            {
                if (CheckExsting())
                {
                    SelectedItem.Discount = tbDiscount.Value;
                    decimal temp;
                    decimal temp2;
                    decimal.TryParse(tbDiscountStart.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out temp);
                    decimal.TryParse(tbDiscountEnd.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out temp2);
                    SelectedItem.RangeFrom = temp;
                    SelectedItem.RangeTo = temp2;
                    SelectedItem.TypeName = tbDiscountTitle.Text;

                    bool success = await SASettings.PostUpdateDiscount(SelectedItem);
                    if (success)
                    {
                        DataHolder.Settings.Discounts = await SASettings.GetDiscountSettings();
                        cbSelectedRow.DisplayMember = "TypeName";
                        cbSelectedRow.DataSource = DataHolder.Settings.Discounts;
                        cbSelectedRow.SelectedIndex = -1;
                        tbDiscountTitle.Text = "";
                        tbDiscount.Value = 0;
                        tbDiscountEnd.Text = "";
                        tbDiscountStart.Text = "";
                        labelError.Text = "success_error_settings";
                        labelError.ForeColor = Color.Green;
                        labelError.Visible = true;

                    }
                    else
                    {
                        labelError.Text = "fail_error_settings";
                        labelError.ForeColor = Color.Red;
                        labelError.Visible = true;

                    }
                }
                else
                {
                    labelError.Text = "name_already_existing";
                    labelError.ForeColor = Color.Red;
                    labelError.Visible = true;
                }
            }
            else
            {
                labelError.Text = "all_fields_are_required";
                labelError.ForeColor = Color.Red;
                labelError.Visible = true;
            }

        }

        private void tbDiscountStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void tbDiscountEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void cbSelectedRow_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CommonDiscounts selectedItem = (CommonDiscounts) cbSelectedRow.SelectedItem;
            tbDiscountTitle.Text = selectedItem.TypeName;
            tbDiscount.Value = selectedItem.Discount;
            tbDiscountEnd.Text = selectedItem.RangeTo.ToString();
            tbDiscountStart.Text = selectedItem.RangeFrom.ToString();
            SelectedItem = selectedItem;
            labelError.Visible = false;
        }

        private void cbEnablePromotions_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnablePromotions.Checked)
            {
                cbSelectedRow.Enabled = true;
                tbDiscountTitle.Enabled = true;
                tbDiscountEnd.Enabled = true;
                tbDiscountStart.Enabled = true;
                tbDiscount.Enabled = true;
                btnSave.Enabled = true;
                Settings.Default.PromotionEnabled = cbEnablePromotions.Enabled;
            }
            else
            {
                cbSelectedRow.Enabled = false;
                tbDiscountTitle.Enabled = false;
                tbDiscountEnd.Enabled = false;
                tbDiscountStart.Enabled = false;
                tbDiscount.Enabled = false;
                btnSave.Enabled = false;
                Settings.Default.PromotionEnabled = cbEnablePromotions.Enabled;
            }

        }
    }
}
