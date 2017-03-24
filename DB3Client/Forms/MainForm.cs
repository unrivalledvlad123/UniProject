using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB3Client.Controls;
using MetroFramework.Forms;

namespace DB3Client.Forms
{
    public partial class MainForm : MetroForm
    {

        public MetroFramework.Controls.MetroPanel MainContainer
        {
            get { return mpContainer; }
            set { mpContainer = value; }
        }
        // static MainForm _instance;

        //public static MainForm Instance
        //{
        //    get
        //    {
        //        if (_instance ==null)

        //            _instance = new MainForm();
        //        return _instance;
        //    }
        //}
        
        public MainForm()
        {
            InitializeComponent();
        }

        //private void MainForm_Load(object sender, EventArgs e)
        //{
        //    _instance = this;
        //}

        private void mtSales_Click(object sender, EventArgs e)
        {
            SalesControl salesControl = new SalesControl {Dock = DockStyle.Fill};
            MainContainer.Controls.Clear();
            MainContainer.Controls.Add(salesControl);
        }

        private void mtOrders_Click(object sender, EventArgs e)
        {
            OrdersControl ordersControl = new OrdersControl {Dock = DockStyle.Fill};
            MainContainer.Controls.Clear();
            mpContainer.Controls.Add(ordersControl);
        }

        private void mtContacts_Click(object sender, EventArgs e)
        {
            ContractsControl contractsControl = new ContractsControl {Dock = DockStyle.Fill};
            MainContainer.Controls.Clear();
            MainContainer.Controls.Add(contractsControl);
        }

        private void mtWerehouse_Click(object sender, EventArgs e)
        {
            WarehouseControl warehouseControl = new WarehouseControl {Dock = DockStyle.Fill};
            MainContainer.Controls.Clear();
            MainContainer.Controls.Add(warehouseControl);
        }

        private void mtAdmin_Click(object sender, EventArgs e)
        {
            AdminControl adminControl = new AdminControl {Dock = DockStyle.Fill};
            MainContainer.Controls.Clear();
            MainContainer.Controls.Add(adminControl);
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
        }
    }
}
