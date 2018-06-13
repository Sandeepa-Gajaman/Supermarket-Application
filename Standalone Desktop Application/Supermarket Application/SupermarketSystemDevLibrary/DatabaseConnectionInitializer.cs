using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SupermarketSystemDevLibrary
{
    /// <summary>
    /// Initializes a MySQLDatabase connection to be used in database operations.
    /// </summary>
    class DatabaseConnectionInitializer
    {
        private MySqlConnection Connection;
        private string Server;
        private string Database;
        private string Username;
        private string Password;

        public DatabaseConnectionInitializer()
        {
            try
            {
                DatabaseConfigurationReader Reader = new DatabaseConfigurationReader();
                Reader.ReadDatabaseConfigurationFile();
                Server = Reader.GetServer();
                Database = Reader.GetDatabase();
                Username = Reader.GetUsername();
                Password = Reader.GetPassword();
                string ConnectionString = "server=" + Server + ";" + "uid=" +
                    Username + ";" + "pwd=" + Password + ";" + "database=" + Database + ";";
                //string ConnectionString = "server=localhost;uid=root;pwd=root;database=incidentreportingapp";
                Connection = new MySqlConnection(ConnectionString);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in initializing database connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Returns a MySQLConnection object to be used in database operations.
        /// </summary>
        /// <returns>MySQLConnection</returns>
        public MySqlConnection GetConnection()
        {
            return Connection;
        }

    }
}
