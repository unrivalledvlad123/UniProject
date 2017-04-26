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
using Common.Forms.Base;
using DB3Client.Controls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Rectangle = System.Drawing.Rectangle;

namespace DB3Client.Forms
{
    public partial class InvoiceTemplateForm : MLForm
    {
        public InvoiceControl HolderControl;

        public InvoiceTemplateForm()
        {
            InitializeComponent();
            InvoiceControl inv = new InvoiceControl {Dock = DockStyle.Fill};
            HolderControl = inv;
            metroPanel1.Controls.Add(inv);

        }

    }
}
