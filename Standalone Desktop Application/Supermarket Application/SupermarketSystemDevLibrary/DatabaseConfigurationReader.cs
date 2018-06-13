using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace SupermarketSystemDevLibrary
{
    /// <summary>
    /// Reads an XML configuration file to be used in database connections.
    /// </summary>
    class DatabaseConfigurationReader
    {
        private string Server;
        private string Database;
        private string Username;
        private string Password;

        public void ReadDatabaseConfigurationFile()
        {
            try
            {
                using (XmlReader Reader = XmlReader.Create("Database Configuration.xml"))
                {
                    while (Reader.Read())
                    {
                        if (Reader.IsStartElement())
                        {
                            switch(Reader.Name)
                            {
                                case "server":
                                    Server = Reader.ReadElementContentAsString();
                                    break;
                                case "username":
                                    Username = Reader.ReadElementContentAsString();
                                    break;
                                case "password":
                                    Password = Reader.ReadElementContentAsString();
                                    break;
                                case "database":
                                    Database = Reader.ReadElementContentAsString();
                                    break;
                            }
                        
                        }
                    }
                }
                //MessageBox.Show(Server+ " "+ Username+ " "+ Password+ " "+ Database);
            }
            catch(FileNotFoundException e)
            {
                MessageBox.Show("Database configuration file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(SecurityException e)
            {
                MessageBox.Show("Inadequate permission to access database configuration file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception e)
            {
                MessageBox.Show("Error encountered in reading database configuration file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            
        }
        
        public string GetServer()
        {
            return Server;
        }

        public string GetDatabase()
        {
            return Database;
        }

        public string GetUsername()
        {
            return Username;
        }

        public string GetPassword()
        {
            return Password;
        }
    }
}
