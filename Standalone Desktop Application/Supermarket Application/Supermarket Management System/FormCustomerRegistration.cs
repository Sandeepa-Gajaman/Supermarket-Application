using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace supermarket
{
    public partial class FormCustomerRegistration : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string username;
        private string password;
        public FormCustomerRegistration()
        {
            server = "localhost";
            database = "illumip_supermarketmanagementsystem";
            username = "root";
            password = "";

            string connString;
            connString = $"SERVER={server};DATABASE={database};USERNAME={username};PASSWORD={password};";

            conn = new MySqlConnection(connString);
            InitializeComponent();
        }

        private void lblmobilenumber_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            string mobilenumber = txtmobilenumber.Text;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            if (Register(fname, lname, mobilenumber,date))
            {
                MessageBox.Show("Regester Successfully");
            }
            else
            {
                MessageBox.Show("Invalid Registration");
            }
        }
        public bool Register(string first_name, string last_name, string mobile_number, string date_of_registration)
        {
            string quary = $"insert into customer(first_name,last_name,mobile_number,date_of_registration) values ('{first_name}','{last_name}','{mobile_number}','{date_of_registration}');";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(quary, conn);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception e)
            {
                conn.Close();
                return false;
            }
        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                    return true;
            }
            catch(MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to Server Failed");
                        break;
                    case 1045:
                        MessageBox.Show("Server");
                            break;
                }
                return false;

                }
            
        }

    } 
}
