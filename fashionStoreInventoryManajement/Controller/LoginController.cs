using fashionStoreInventoryManajement.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fashionStoreInventoryManajement.Controller
{
    internal class LoginController:Model.Connection
    {
        private Connection connection = new Connection();

        public DataTable getList(MySqlCommand command)
        {
            DataTable table = new DataTable();
            try
            {
                command.Connection = GetConn();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }

        public void addAdmin(string username, string passwordd)
        {
            string add = "INSERT INTO Admin VALUES(" + "@username,@passwordd)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@username", MySqlConnector.MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@passwordd", MySqlConnector.MySqlDbType.VarChar).Value = passwordd;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding Data Failed" + ex.Message);
            }

        }
    }
}
