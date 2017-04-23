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
using DB3Client.Forms.WarehouseForms;

namespace DB3Client.Controls
{
    public partial class WarehouseControl : MetroFramework.Controls.MetroUserControl
    {
        public WarehouseControl()
        {
            InitializeComponent();
            SetGridColomns();
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            AddEditForm addForm = new AddEditForm(null);

            if (addForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
        public void SetGridColomns()
        {
            dgvGoods.DataSource = null;
            dgvGoods.Columns.Clear();
            dgvGoods.AutoGenerateColumns = false;
            dgvGoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGoods.RowHeadersVisible = false;


            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "namegoods";
            c1.HeaderText = DataHolder.GetString("name_goods");
            c1.DataPropertyName = "Name";
            c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvGoods.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "descriptiongoods";
            c2.HeaderText = DataHolder.GetString("description_grid_goods");
            c2.DataPropertyName = "Description";
            c2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvGoods.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "typegoods";
            c3.HeaderText = DataHolder.GetString("type_grid_goods");
            c3.DataPropertyName = "Type";
            c3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvGoods.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "quantitygoods";
            c4.HeaderText = DataHolder.GetString("quantity_grid_goods");
            c4.DataPropertyName = "Quanity";
            c4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvGoods.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "pricePerEachGood";
            c5.HeaderText = DataHolder.GetString("price_per_each_grid_good");
            c5.DataPropertyName = "PricePerEach";
            c5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvGoods.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "itedId";
            c6.HeaderText = "";
            c6.DataPropertyName = "ItemId";
            c6.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            c6.Visible = false;
            dgvGoods.Columns.Add(c6);

        }

        private void btnEditPricelist_Click(object sender, EventArgs e)
        {
            formPricelist priceListForm = new formPricelist(null);

            if (priceListForm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
