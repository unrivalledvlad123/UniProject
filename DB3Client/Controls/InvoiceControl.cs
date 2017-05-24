using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.Classes;
using DB3Client.Properties;
using DB3Client.ServiceAccess;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Rectangle = System.Drawing.Rectangle;

namespace DB3Client.Controls
{
    public partial class InvoiceControl : MetroFramework.Controls.MetroUserControl
    {
        public CommonSale Sale { get; set; }

        public bool SavePdf { get; set; }
    
        

        public InvoiceControl(CommonSale sale)
        {
            Sale = sale;
            InitializeComponent();
            SetGridColumnsItems();
            LoadDataFromDb();






            // ExportInvoiceToPdf MUST!!!!!!!!!!!!!!!! be the last method to call!!!!!!!!!!!!!
            //ExportInvoiceToPdf();
            // !!!!!!!!!!!!!!!!!!!!

        }


        // this sets the height of the grid to match rows , so no scroll there ( important for pdf saving)
        public void SetGridSize()
        {
            int height = 0;
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                height += row.Height;
            }
            height += dgvItems.ColumnHeadersHeight;
            dgvItems.ClientSize = new Size(Width, height + 2);
        }

        private void ExportInvoiceToPdf()
        {
            
            Bitmap b = new Bitmap(Width, Height);
            DrawToBitmap(b, new Rectangle(0, 0, b.Width, b.Height));

            Bitmap image = b;
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc,
                new FileStream(Settings.Default.InvoiceSaveLocation + @"\" + labelInvoiceNumber.Text + ".pdf",
                    FileMode.Create));
            doc.Open();
            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                ImageFormat.Bmp);

            if (pdfImage.Height > pdfImage.Width)
            {
                //Maximum height is 800 pixels.
                float percentage = 0.0f;
                percentage = 700 / pdfImage.Height;
                pdfImage.ScalePercent(percentage * 100);
            }
            else
            {
                //Maximum width is 600 pixels.
                float percentage = 0.0f;
                percentage = 540 / pdfImage.Width;
                pdfImage.ScalePercent(percentage * 100);
            }
            doc.Add(pdfImage);
            doc.Close();

        }

        private async void LoadDataFromDb()
        {
            CommonContract contract = await SAContract.GetPartnersById(Sale.BuyerId.ToString());
            mlLabel17.Text = contract.CompanyName;
            mlLabel15.Text = contract.VatNumber;
            mlLabel13.Text = contract.Bulstat;
            List<CommonMol> mols = await SAOwner.getAllMols(contract.PartnerId);
            CommonMol cMol = mols.Count == 0 ? new CommonMol() : mols.First();
            mlLabel7.Text = cMol.FirstName + " " + cMol.LastName;
            mlLabel29.Text = mlLabel7.Text;
            mlLabel9.Text = contract.Address;
            labelInvoiceNumber.Text = Sale.InvoiceNumber;
            mlLabel19.Text = Sale.Date.ToString(CultureInfo.InvariantCulture);
            mlLabel18.Text = Sale.Date.ToString(CultureInfo.InvariantCulture);
            CompanyOwner owner = await SAOwner.getOwner(Sale.SellerId);
            mlLabel24.Text = owner.CompanyName;
            mlLabel23.Text = owner.VatNumber == null ? "0" : owner.VatNumber;
            mlLabel22.Text = owner.Bulstat == null ? "0" : owner.Bulstat;
            mlLabel42.Text = owner.Iban == null ? "0" : owner.Iban;
            mlLabel41.Text = owner.SwiftCode == null ? "0" : owner.SwiftCode;
            mlLabel40.Text = owner.Bank == null ? "0" : owner.Bank;
            List<CommonMol> ownerMols = await SAOwner.getAllMols(owner.OwnerId);
//            CommonMol ownerMol = ownerMols.Count == 0 ? new CommonMol() : ownerMols.First();
//            mlLabel20.Text = ownerMol.FirstName + " " + ownerMol.LastName;
            mlLabel21.Text = owner.Address;
            mlLabel20.Text = DataHolder.PrimeryMol.FirstName + " " + DataHolder.PrimeryMol.LastName;
            mlLabel28.Text = mlLabel20.Text;
            
            //mlLabel34.Text = Sale.TotalPrice.ToString();
           // var vat = 1 + (Settings.Default.VatMultiplier / 100);
           // var vatPrice = Sale.TotalPrice / (double) vat;
           // mlLabel36.Text = vatPrice.ToString();
           // mlLabel38.Text = (Sale.TotalPrice - vatPrice).ToString();
            double total = 0;

            List<GridItem> items = new List<GridItem>();
            foreach (var soldItem in Sale.SoldItems)
            {
                CommonItem item = await SAItem.GetItemsById(soldItem.ItemId.ToString());
                GridItem gridItem = new GridItem();
                gridItem.Name = item.ToString();
                gridItem.Quantity = soldItem.Quantity.ToString();
                if (DataHolder.UserCulture.TwoLetterISOLanguageName == "bg")
                {
                    Enums.UnitTypesBg types = (Enums.UnitTypesBg)item.MeasurmentUnit;
                    gridItem.MeasurementUnitString = types.ToString();
                }
                else
                {
                    Enums.UnitTypes types = (Enums.UnitTypes)item.MeasurmentUnit;
                    gridItem.MeasurementUnitString = types.ToString();
                }
                gridItem.Price = soldItem.Price;
                var vatPrice = (double) soldItem.Price;
                gridItem.Total = (decimal) (soldItem.Quantity * vatPrice);
                total += (double) (soldItem.Quantity * vatPrice);
                items.Add(gridItem);
              
            }
            dgvItems.DataSource = items;

            // do not change set grid size and export method order!
            SetGridSize();
            if (SavePdf == true)
            {
                ExportInvoiceToPdf();
            }
            
            
        }
        public void SetGridColumnsItems()
        {
            dgvItems.DataSource = null;
            dgvItems.Columns.Clear();
            dgvItems.AutoGenerateColumns = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.RowHeadersVisible = false;


            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Name";
            c1.HeaderText = DataHolder.GetString("item_name");
            c1.DataPropertyName = "Name";
            c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvItems.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "quantity";
            c2.HeaderText = DataHolder.GetString("quantity");
            c2.DataPropertyName = "Quantity";
            c2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvItems.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "MeasurementUnit";
            c3.HeaderText = DataHolder.GetString("measurment_unit");
            c3.DataPropertyName = "MeasurementUnitString";
            c3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvItems.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Price";
            c4.HeaderText = DataHolder.GetString("price_each");
            c4.DataPropertyName = "Price";
            c4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvItems.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "TotalPrice";
            c5.HeaderText = DataHolder.GetString("total");
            c5.DataPropertyName = "Total";
            c5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvItems.Columns.Add(c5);



        }

        private void DONOTTOUCH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mlGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mlGroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void mlGroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void mlGroupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void mlGroupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void mlGroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void mlLabel14_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel13_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel15_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel16_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel17_Click(object sender, EventArgs e)
        {

        }

        private void mllabel134_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel20_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel12_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel21_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel22_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel23_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel24_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel26_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel18_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel19_Click(object sender, EventArgs e)
        {

        }

        private void labelInvoiceNumber_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel40_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel41_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel42_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel43_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel44_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel45_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel46_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel47_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel34_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel32_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel36_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel33_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel38_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel35_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel37_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel39_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel28_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel29_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel30_Click(object sender, EventArgs e)
        {

        }

        private void mlLabel31_Click(object sender, EventArgs e)
        {

        }
    }

    public class GridItem
    {
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string MeasurementUnitString { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}
