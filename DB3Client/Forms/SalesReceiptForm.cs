using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Classes;
using Common.Forms.Base;
using DB3Client.Controls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Rectangle = System.Drawing.Rectangle;

namespace DB3Client.Forms
{
    public partial class SalesReceiptForm : MLForm
    {
        public SalesReceiptsControl HolderControl;

        public SalesReceiptForm(CommonSale sale, bool savePdf = true)
        {
            InitializeComponent();
            SalesReceiptsControl sreceipts = new SalesReceiptsControl(sale) { Dock = DockStyle.Fill, SavePdf = savePdf};
            HolderControl = sreceipts;
          metroPanel1.Controls.Add(sreceipts);

        }


    }
}