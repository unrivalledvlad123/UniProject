using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.Classes;
using Common.Forms.Base;
using DB3Client.Controls;
using DB3Client.ServiceAccess;
using MetroFramework.Forms;

namespace DB3Client.Forms
{
    public partial class MainForm : MLForm
    {
        
        public MetroFramework.Controls.MetroPanel MainContainer
        {
            get { return mpContainer; }
            set { mpContainer = value; }
        }

        public MainForm()
        {
            InitializeComponent();
            OnInitialization();
            GetOwner(DataHolder.OwnerId);
            SwitchRoles();
        }

        public void OnInitialization()
        {
            labelLogedAs.Text = DataHolder.GetString("logged_as_current_user") + " " + DataHolder.Username;
            labelCurrentServer.Text = DataHolder.GetString("connected_to_server") + " " + DataHolder.ServerAddress;
            mtAdmin.Visible = false;
            mtContacts.Visible = false;
            mtOrders.Visible = false;
            mtSales.Visible = false;
            mtWerehouse.Visible = false;
            mtReports.Visible = false;
        }

        #region // < ======== Methods ====== > //

        public async void GetOwner(Guid ownerId)
        {
            DataHolder.Owner = await SAOwner.getOwner(ownerId);
        }

        public void SwitchRoles()
        {
            switch (DataHolder.UserType)
            {
                case 0:
                    mtAdmin.Visible = true;
                    mtContacts.Visible = true;
                    mtOrders.Visible = true;
                    mtSales.Visible = true;
                    mtWerehouse.Visible = true;
                    mtReports.Visible = true;
                    break;
                case 1:
                    mtContacts.Visible = true;
                    mtOrders.Visible = true;
                    mtSales.Visible = true;
                    mtWerehouse.Visible = true;
                    mtReports.Visible = true;
                    break;
                case 2:
                    mtSales.Visible = true;
                    mtWerehouse.Visible = true;
                    break;
            }
        }

        #endregion


        #region // < ====== Events ======> //

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

        private void mtReports_Click(object sender, EventArgs e)
        {
            ReportsControl reportControl = new ReportsControl() { Dock = DockStyle.Fill };
            MainContainer.Controls.Clear();
            MainContainer.Controls.Add(reportControl);
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss", DataHolder.UserCulture);
        }

        #endregion

       
    }
}
