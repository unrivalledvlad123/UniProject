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

namespace DB3Client.Forms.WarehouseForms
{
    public partial class formPricelist : MLForm
    {
        public static CommonWarehouseItemsPrice OldPrice;
        public formPricelist(CommonWarehouseItemsPrice oldPrice)
        {
            InitializeComponent();
            SetGridColomnsPricelist();
            if (oldPrice != null)
            {
                tbNewPriceWharehouse.Text = !string.IsNullOrEmpty(oldPrice.SellingPriceCent) ? oldPrice.SellingPriceCent : "";

            }
            OldPrice = oldPrice;
        }

        private void btnSaveNewPriceWharehouse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNewPriceWharehouse.Text))
            {

            }
            else
            {
                mlErrorPriceListForm.Visible = true;
                mlErrorPriceListForm.Text = "price_list_form_error";
            }
        }
        public void SetGridColomnsPricelist()
        {
            dgvPriceListWharehouseGrid.DataSource = null;
            dgvPriceListWharehouseGrid.Columns.Clear();
            dgvPriceListWharehouseGrid.AutoGenerateColumns = false;
            dgvPriceListWharehouseGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPriceListWharehouseGrid.RowHeadersVisible = false;


            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "NameGoodsPriceList";
            c1.HeaderText = DataHolder.GetString("name_goods_pricelist");
            c1.DataPropertyName = "Name";
            c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvPriceListWharehouseGrid.Columns.Add(c1);

    

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "typegoodspricelist";
            c2.HeaderText = DataHolder.GetString("type_goods_pricelist");
            c2.DataPropertyName = "Type";
            c2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvPriceListWharehouseGrid.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "CurrentPriceListWarehouse";
            c3.HeaderText = DataHolder.GetString("current_price_list_warehouse");
            c3.DataPropertyName = "SellingPriceCent";
            c3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvPriceListWharehouseGrid.Columns.Add(c3);

            

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "ItemIdPriceList";
            c4.HeaderText = "";
            c4.DataPropertyName = "ItemId";
            c4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c4.Visible = false;
            dgvPriceListWharehouseGrid.Columns.Add(c4);

        }

        private void tbUnderDevelopmentWharehouse_Click(object sender, EventArgs e)
        {

        }
    }
}
