using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace SupermarketSystemDevLibrary
{
    /// <summary>
    /// Contains methods to assist commonly used database operations for the Item table.
    /// </summary>
    public class ItemDatabaseHelper
    {
        private MySqlConnection Connection;

        public ItemDatabaseHelper()
        {
            DatabaseConnectionInitializer ConnectionInitializer = new DatabaseConnectionInitializer();
            Connection = ConnectionInitializer.GetConnection();
        }

        /// <summary>
        /// A test method to retrieve data from a specified table. 
        /// </summary>
        /// <param name="Query">Enter an sql query to retrieve data from a particular table</param>
        /// <returns>A datatable</returns>
        public DataTable SelectDataFromAnyTable(string Query)
        {
            DataTable Table= new DataTable();
            try
            {
                Connection.Open();
                MySqlCommand Command = new MySqlCommand(Query, Connection);
                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                Adapter.SelectCommand = Command;
                Adapter.Fill(Table);
                Connection.Close();
                return Table;
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Error in retrieving data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(e.Message);
                return Table;
            }
            catch(Exception e)
            {
                MessageBox.Show("Error in retrieving data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(e.Message);
                return Table;
            }
        }

        /// <summary>
        /// Executes a stored procedure to view all items in the Item table.
        /// </summary>
        /// <returns>A datatable</returns>
        public DataTable SelectAllItems()
        {
            DataTable Table = new DataTable();
            try
            {
                Connection.Open();
                MySqlCommand Command = new MySqlCommand("select_all_items", Connection);
                Command.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                Adapter.SelectCommand = Command;
                Adapter.Fill(Table);
                Connection.Close();
                return Table;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error in retrieving data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in retrieving data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Table;
            }
        }

        /// <summary>
        /// Executes a stored procedure to view all items in the Item table according to the item category.
        /// </summary>
        /// <param name="Query"></param>
        /// <returns>A datatable</returns>
        public DataTable SelectItemsByCategory(string Category)
        {
            DataTable Table = new DataTable();
            try
            {
                Connection.Open();
                MySqlCommand Command = new MySqlCommand("select_items_by_category", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@category", Category);
                Command.Parameters["@category"].Direction = ParameterDirection.Input;

                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                Adapter.SelectCommand = Command;
                Adapter.Fill(Table);
                Connection.Close();
                return Table;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error in retrieving data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in retrieving data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Table;
            }
        }

        /// <summary>
        /// Executes a stored procedure to view all items in the Item table according to the item Brand.
        /// </summary>
        /// <param name="Item brand"></param>
        /// <returns>A datatable</returns>
        public DataTable SelectItemsByBrand(string Brand)
        {
            DataTable Table = new DataTable();
            try
            {
                Connection.Open();
                MySqlCommand Command = new MySqlCommand("select_items_by_brand", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@brand", Brand);
                Command.Parameters["@brand"].Direction = ParameterDirection.Input;

                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                Adapter.SelectCommand = Command;
                Adapter.Fill(Table);
                Connection.Close();
                return Table;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error in retrieving data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in retrieving data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Table;
            }
        }

        /// <summary>
        /// Executes a stored procedure to view all items in the Item table according to the item name.
        /// </summary>
        /// <param name="Item name"></param>
        /// <returns>A datatable</returns>
        public DataTable SelectItemsByName(string Name)
        {
            DataTable Table = new DataTable();
            try
            {
                Connection.Open();
                MySqlCommand Command = new MySqlCommand("select_items_by_name", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@name", Name);
                Command.Parameters["@name"].Direction = ParameterDirection.Input;

                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                Adapter.SelectCommand = Command;
                Adapter.Fill(Table);
                Connection.Close();
                return Table;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error in retrieving data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in retrieving data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Table;
            }
        }

        /// <summary>
        /// Executes a stored procedure to view all items in the Item table according to the item code.
        /// </summary>
        /// <param name="Item code"></param>
        /// <returns>A datatable</returns>
        public DataTable SelectItemsByCode(int Code)
        {
            DataTable Table = new DataTable();
            try
            {
                Connection.Open();
                MySqlCommand Command = new MySqlCommand("select_items_by_code", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@code", Code);
                Command.Parameters["@code"].Direction = ParameterDirection.Input;

                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                Adapter.SelectCommand = Command;
                Adapter.Fill(Table);
                Connection.Close();
                return Table;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error in retrieving data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in retrieving data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Table;
            }
        }

        /// <summary>
        /// Get the quantity of a particular item.
        /// </summary>
        /// <param name="ItemCode">Item code</param>
        /// <returns>Quantity</returns>
        public int GetQuantity(int ItemCode)
        {
            int Quantity = -999;
            try
            {
                Connection.Open();
                MySqlCommand Command = new MySqlCommand("get_item_inventory_quantity", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@param_item_code", ItemCode);
                Command.Parameters["@param_item_code"].Direction = ParameterDirection.Input;

                Command.Parameters.AddWithValue("@quantity", MySqlDbType.Int32);
                Command.Parameters["@quantity"].Direction = ParameterDirection.Output;
  
                Command.ExecuteNonQuery();
                Quantity = Convert.ToInt32(Command.Parameters["@quantity"].Value);
                Connection.Close();

                return Quantity;
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Error in retrieving data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(e.Message);
            }
            catch(Exception e)
            {
                MessageBox.Show("Error in retrieving data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(e.Message);
            }
            return Quantity;
        }

        /// <summary>
        /// Sets the quantity of a particular item. 
        /// </summary>
        /// <param name="ItemCode">Item code</param>
        /// <param name="ItemQuantity">Quantity</param>
        /// <returns></returns>
        public bool SetQuantity(int ItemCode, int ItemQuantity)
        {
            try
            {
                Connection.Open();
                MySqlCommand Command = new MySqlCommand("set_item_inventory_quantity", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@param_item_code", ItemCode);
                Command.Parameters["@param_item_code"].Direction = ParameterDirection.Input;

                Command.Parameters.AddWithValue("@param_item_quantity", ItemQuantity);
                Command.Parameters["@param_item_quantity"].Direction = ParameterDirection.Input;
                Command.ExecuteNonQuery();
                Connection.Close();

                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error in sending data to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in sending data to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(e.Message);
            }
            return false;
        }
        public bool UpdateQuantity(int ItemCode, int ItemQuantity)
        {
            try
            {
                Connection.Open();
                MySqlCommand Command = new MySqlCommand("add_quantity", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@param_item_code", ItemCode);
                Command.Parameters["@param_item_code"].Direction = ParameterDirection.Input;

                Command.Parameters.AddWithValue("@param_item_quantity", ItemQuantity);
                Command.Parameters["@param_item_quantity"].Direction = ParameterDirection.Input;
                Command.ExecuteNonQuery();
                Connection.Close();

                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error in sending data to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in sending data to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(e.Message);
            }
            return false;
        }

        public List<object> GetDetails(string customermobilenumber)
        {
            // double totalpurchasevalue=0;
            List<object> customerlist = new List<object>();

            try
            {
                Connection.Open();
                

                MySqlCommand cmd = new MySqlCommand(); //SQL Statement
                cmd.Connection = Connection;
                cmd.CommandText = "SELECT customer_id,shop_count,total_purchase_value FROM customer where mobile_number=@x";
                cmd.Parameters.AddWithValue("x", customermobilenumber);

                cmd.Connection = Connection;

                //  MessageBox.Show(cmd.ExecuteScalar().ToString());
                //  value = cmd.ExecuteScalar().ToString();
               // MessageBox.Show("hello");
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {


                    int customerid = reader.GetInt32(0);
                    int shopcount = reader.GetInt32(1);
                    decimal totalpurchasevalue = reader.GetDecimal(2);
                    customerlist.Add(customerid);
                    customerlist.Add(shopcount);
                    customerlist.Add(totalpurchasevalue);

                    //MessageBox.Show(customerid.ToString());
                   // MessageBox.Show(shopcount.ToString());
                    //MessageBox.Show(totalpurchasevalue.ToString());

                }
                else
                {
                     //MessageBox.Show("Please input valid phone number");
                    customerlist.Add("2");
                    customerlist.Add(0);
                    customerlist.Add(0.00);

                }
                //if(cmd.ExecuteScalar==null)
                // MessageBox.Show(val.ToString());
                Connection.Close();
            }

            catch (MySqlException e)
            {
                MessageBox.Show("Error in sending data to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(e.StackTrace);
                //MessageBox.Show(e.Message);
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("please input valid phone number");
                return null;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.HelpLink.ToString());
                // MessageBox.Show("Error in sending data to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(e.Message);
            }

            return customerlist;
        }

        /// <summary>
        /// Adds a new item to the item table.
        /// </summary>
        /// <param name="ItemCategory">Item category</param>
        /// <param name="ItemBrand">Item brand</param>
        /// <param name="ItemName">Item name</param>
        /// <param name="ItemDescription">Item description</param>
        /// <param name="ItemVolume">Item volume</param>
        /// <param name="ItemUnitPrice">Item unit price</param>
        /// <returns>True on success or false on failure</returns>
        public bool AddItem(string ItemCategory, string ItemBrand, string ItemName, string ItemDescription, 
            string ItemVolume, decimal ItemUnitPrice)
        {
            try
            {
                Connection.Open();
                MySqlCommand Command = new MySqlCommand("add_item", Connection);
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddWithValue("@item_category", ItemCategory);
                Command.Parameters["@item_category"].Direction = ParameterDirection.Input;

                Command.Parameters.AddWithValue("@item_brand", ItemBrand);
                Command.Parameters["@item_brand"].Direction = ParameterDirection.Input;

                Command.Parameters.AddWithValue("@item_name", ItemName);
                Command.Parameters["@item_name"].Direction = ParameterDirection.Input;

                Command.Parameters.AddWithValue("@item_description", ItemDescription);
                Command.Parameters["@item_description"].Direction = ParameterDirection.Input;

                Command.Parameters.AddWithValue("@item_volume", ItemVolume);
                Command.Parameters["@item_volume"].Direction = ParameterDirection.Input;

                //Command.Parameters.AddWithValue("@item_quantity", ItemCategory);
                //Command.Parameters["@item_quantity"].Direction = ParameterDirection.Input;

                Command.Parameters.AddWithValue("@item_unit_price", ItemUnitPrice);
                Command.Parameters["@item_unit_price"].Direction = ParameterDirection.Input;

                Command.ExecuteNonQuery();
                Connection.Close();
                return true;
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Error in sending data to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in sending data to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(e.Message);
            }
            return false;
        }

        /// <summary>
        /// Removes an existing item from the item table.
        /// </summary>
        /// <param name="ItemCode">Item code</param>
        /// <returns>True on success or false on failure</returns>
        public bool RemoveItem(int ItemCode)
        {
            try
            {
                Connection.Open();
                MySqlCommand Command = new MySqlCommand("remove_item", Connection);
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddWithValue("@param_item_code", ItemCode);
                Command.Parameters["@param_item_code"].Direction = ParameterDirection.Input;
                Command.ExecuteNonQuery();
                Connection.Close();

                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error in sending data to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in sending data to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(e.Message);
            }
            return false;
        }

        //mysql transaction
        /* public List<object> setorder(int customerid,string time,string date,int employeeid,decimal total)
 =======

         /// <summary>
         /// Removes an existing item from the item table.
         /// </summary>
         /// <param name="ItemCode">Item code</param>
         /// <returns>True on success or false on failure</returns>
         public bool RemoveItem(int ItemCode)
         {
             try
             {
                 Connection.Open();
                 MySqlCommand Command = new MySqlCommand("remove_item", Connection);
                 Command.CommandType = CommandType.StoredProcedure;

                 Command.Parameters.AddWithValue("@param_item_code", ItemCode);
                 Command.Parameters["@param_item_code"].Direction = ParameterDirection.Input;
                 Command.ExecuteNonQuery();
                 Connection.Close();

                 return true;
             }
             catch (MySqlException e)
             {
                 MessageBox.Show("Error in sending data to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 //MessageBox.Show(e.Message);
             }
             catch (Exception e)
             {
                 MessageBox.Show("Error in sending data to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 //MessageBox.Show(e.Message);
             }
             return false;
         }

         public List<object> setorder(int customerid,string time,string date,int employeeid,decimal total)
 >>>>>>> efc022a9e65ce5f40c9f790ecfc0ed196fc4cad9
         {
               MessageBox.Show(customerid.ToString());
               MessageBox.Show(time);
               MessageBox.Show(date);
               MessageBox.Show(employeeid.ToString());
               MessageBox.Show(total.ToString());
             List<object> connectiondetails = new List<object>();
             Connection.Open();
             MySqlCommand cmd = new MySqlCommand();
             MySqlTransaction mytran;
             mytran = Connection.BeginTransaction();
             cmd.Connection = Connection;
             cmd.Transaction = mytran;

             try
             {
                 cmd.CommandText = "INSERT INTO order_table(date,time,employee_id,customer_id,total_price) VALUES(@a,@b,@c,@d,@e)";
                 cmd.Parameters.AddWithValue("a", date);
                 cmd.Parameters.AddWithValue("b", time);
                 cmd.Parameters.AddWithValue("c", employeeid);
                 cmd.Parameters.AddWithValue("d", customerid);
                 cmd.Parameters.AddWithValue("e", total);
                 cmd.ExecuteNonQuery();
                  mytran.Commit();
                 MessageBox.Show("done");
                 //cmd.CommandText = "INSERT INTO order_table(date,time,employee_id,customer_id,total_price) VALUES(@a,@b,@c,@d,@e)";
                 connectiondetails.Add(Connection);
                 connectiondetails.Add(mytran);


             }
             catch(MySqlException e)
             {

                // mytran.Rollback();
                 MessageBox.Show("Error in sending data to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             catch(Exception e)
             {
               //  mytran.Rollback();
                 MessageBox.Show("Error in sending data to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

             }
             return connectiondetails;
         }*/
        public int setorder(int customerid, string time, string date, int employeeid, decimal total)
        {
            int id=0;
            try
            {
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "INSERT INTO order_table(date,time,employee_id,customer_id,total_price) VALUES(@a,@b,@c,@d,@e)";
                cmd.Parameters.AddWithValue("a", date);
                cmd.Parameters.AddWithValue("b", time);
                cmd.Parameters.AddWithValue("c", employeeid);
                cmd.Parameters.AddWithValue("d", customerid);
                cmd.Parameters.AddWithValue("e", total);
                cmd.ExecuteNonQuery();
                 id = Convert.ToInt32(cmd.LastInsertedId);

                //  MessageBox.Show(id.ToString(), "orderid");
                Connection.Close();
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Something Wrong with connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(e.Message);
            }
            catch(Exception e)
            {
                MessageBox.Show("OOps! Something Wrong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(e.Message);
            }
            return id;

            
        }
        public bool insertpayment(int orderid,string paymenttype, decimal totalpayment)
        {
            bool details=false;
            try
            {
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "INSERT INTO payment(order_id,payment_type,total_price_after_discount) VALUES(@a,@b,@c)";
                cmd.Parameters.AddWithValue("a", orderid);
                cmd.Parameters.AddWithValue("b", paymenttype);

                cmd.Parameters.AddWithValue("c", totalpayment);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("payment is succesfull");
                    details = true;
                }
                else
                {
                    MessageBox.Show("payment is not succesfull");
                    details = false;
                }


                Connection.Close();

            }
            catch(MySqlException e)
            {
                MessageBox.Show("Something Wrong with connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception e)
            {
                MessageBox.Show("OOPS! Something Wrong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return details;
        }
        public bool SetItemQuantity(int orderid,int itemcode,int quantity,decimal totalprice)
        {
            bool details=false;
            try
            {
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "INSERT INTO order_item_table(order_id,item_code,quantity,price) VALUES(@a,@b,@c,@d)";
                cmd.Parameters.AddWithValue("a", orderid);
                cmd.Parameters.AddWithValue("b", itemcode);
                cmd.Parameters.AddWithValue("c", quantity);
                cmd.Parameters.AddWithValue("d", totalprice);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                   // MessageBox.Show("payment is succesfull");
                    details = true;
                }
                else
                {
                   // MessageBox.Show("payment is not succesfull");
                    details = false;
                }


                Connection.Close();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Something Wrong with connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                details = false;
            }
            catch (Exception e)
            {
                details = false;
                MessageBox.Show("OOPS! Something Wrong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return details;
        }
        public bool DeleteItem(int itemid)
        {
            bool details = false;
            try
            {
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "Delete from  order_table Where order_id=@a";
                cmd.Parameters.AddWithValue("a", itemid);
                
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    // MessageBox.Show("payment is succesfull");
                    details = true;
                }
                else
                {
                    // MessageBox.Show("payment is not succesfull");
                    details = false;
                }


                Connection.Close();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Something Wrong with connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                details = false;
            }
            catch (Exception e)
            {
                details = false;
                MessageBox.Show("OOPS! Something Wrong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return details;
        }
        public bool UpdateCustomer(int orderid,int customerid)
        {
            bool details = false;
            try
            {
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "Update order_table Set customer_id=@b  where order_id=@a";
                cmd.Parameters.AddWithValue("a", orderid);
                cmd.Parameters.AddWithValue("b", customerid);

                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    // MessageBox.Show("payment is succesfull");
                    details = true;
                }
                else
                {
                    // MessageBox.Show("payment is not succesfull");
                    details = false;
                }


                Connection.Close();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Something Wrong with connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                details = false;
            }
            catch (Exception e)
            {
                details = false;
                MessageBox.Show("OOPS! Something Wrong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return details;
        }
    }
}




