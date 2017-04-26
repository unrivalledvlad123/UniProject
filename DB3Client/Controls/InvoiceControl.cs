using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Rectangle = System.Drawing.Rectangle;

namespace DB3Client.Controls
{
    public partial class InvoiceControl : MetroFramework.Controls.MetroUserControl
    {
        public InvoiceControl()
        {

            InitializeComponent();
            SetGridSize();
            LoadDataFromDb();





            // ExportInvoiceToPdf MUST!!!!!!!!!!!!!!!! be the last method to call!!!!!!!!!!!!!
            ExportInvoiceToPdf();
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
            PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\vlado.CC\Desktop\image.pdf", FileMode.Create));
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
           //await someMethod
        }

    }
}
