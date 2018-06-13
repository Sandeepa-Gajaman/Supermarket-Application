using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    public partial class FormDashboard : Form
    {
        public FormDashboard(string UserType)
        {
            InitializeComponent();
            if (UserType.Equals("cashier"))
            {
                PanelManager.Enabled = false;
            }
            //if (UserType.Equals("manager"))
            //{
            //}
        }

        private void ButtonPOS_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();
        }

        private void ButtonCustomerRegistration_Click(object sender, EventArgs e)
        {
            supermarket.FormCustomerRegistration Form = new supermarket.FormCustomerRegistration();
            Form.Show();
        }

        private void ButtonInventoryManagement_Click(object sender, EventArgs e)
        {
            FormInventory FormInventory = new FormInventory();
            FormInventory.Show();
        }

        private void ButtonManagementReports_Click(object sender, EventArgs e)
        {
            FormManagementReports FormManagementReports = new FormManagementReports();
            FormManagementReports.Show();
        }
    }
}
