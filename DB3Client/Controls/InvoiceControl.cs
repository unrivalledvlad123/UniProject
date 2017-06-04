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
            CommonInvoice invoice = await SASale.GetInvoive(Sale.SaleId);

            mlLabel17.Text = invoice.BuyerCompanyName;
            mlLabel15.Text = invoice.BuyerVATNumber;
            mlLabel13.Text = invoice.BuyerBulstat;
            mlLabel7.Text = invoice.BuyerMol;
            mlLabel29.Text = invoice.BuyerMol;
            mlLabel9.Text = invoice.BuyerAddress;
            labelInvoiceNumber.Text = invoice.InvoiceNumber.ToString().PadLeft(10, '0');
            mlLabel19.Text = Sale.Date.ToString(CultureInfo.InvariantCulture);
            mlLabel18.Text = Sale.Date.ToString(CultureInfo.InvariantCulture);
            mlLabel24.Text = invoice.OwnerCompanyName;
            mlLabel23.Text = invoice.OwnerVATNumber;
            mlLabel22.Text = invoice.OwnerBulstat;
            mlLabel42.Text = invoice.OwnerIBAN;
            mlLabel41.Text = invoice.OwnerSwiftCode;
            mlLabel40.Text = invoice.OwnerBank;
            mlLabel21.Text = invoice.OwnerAddress;
            mlLabel20.Text = invoice.OwnerMol;
            mlLabel28.Text = invoice.OwnerMol;

            decimal totalBoth = 0;
            decimal ddsTotal = 0;
            decimal totatAmount = 0;


            List<GridItem> items = new List<GridItem>();
            foreach (var soldItem in Sale.SoldItems)
            {
                CommonItem item = await SAItem.GetItemsById(soldItem.ItemId.ToString());
                if (item != null)
                {
                    GridItem gridItem = new GridItem();
                    gridItem.Name = item.Name;
                    gridItem.Quantity = soldItem.Quantity.ToString();
                    if (DataHolder.UserCulture.TwoLetterISOLanguageName == "bg")
                    {
                        Enums.UnitTypesBg types = (Enums.UnitTypesBg) item.MeasurmentUnit;
                        gridItem.MeasurementUnitString = types.ToString();
                    }
                    else
                    {
                        Enums.UnitTypes types = (Enums.UnitTypes) item.MeasurmentUnit;
                        gridItem.MeasurementUnitString = types.ToString();
                    }
                    decimal temp = item.SellingPriceCent;
                    gridItem.Price = temp / 100;
                    var vatPercent = DataHolder.Settings.VatSettingsByGroup.FirstOrDefault(p => p.Key == item.Type);
                    gridItem.Total = soldItem.Quantity * gridItem.Price;
                    items.Add(gridItem);

                    totatAmount += gridItem.Price * soldItem.Quantity;
                    ddsTotal += (gridItem.Price * soldItem.Quantity) * vatPercent.Value;
                    totalBoth += (gridItem.Price * soldItem.Quantity) + ((gridItem.Price * soldItem.Quantity) * vatPercent.Value);
                }

            }
            dgvItems.DataSource = items;
            labelAmount.Text = totatAmount.ToString();
            labelTotal.Text = totalBoth.ToString();
            labelDDS.Text = ddsTotal.ToString();

            // do not change set grid size and export method order!
            SetGridSize();
            if (SavePdf)
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
