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
    public partial class FormLogin : Form
    {
        private string Username= "", Password= "";
        private string UserType = ""; //'cashier' and 'manager'.

        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            //Cashier username- shamal; password- shamal123.
            //Manager password- udara; password- udara123;

            Username= TextBoxUserName.Text;
            Password = TextBoxPassword.Text;

            if(Username.Equals("shamal") && Password.Equals("shamal123"))
            {
                UserType = "cashier";
                FormDashboard FormDashboard = new FormDashboard(UserType);
                FormDashboard.Show();
            }
            else if(Username.Equals("udara") && Password.Equals("udara123"))
            {
                UserType = "manager";
                FormDashboard FormDashboard = new FormDashboard(UserType);
                FormDashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials! Plesae try again.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
