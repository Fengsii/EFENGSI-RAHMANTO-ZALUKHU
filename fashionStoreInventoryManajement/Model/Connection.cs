using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fashionStoreInventoryManajement.Model
{
    internal class Connection
    {
        public MySqlCommand cmd;
        public DataSet ds;// menyimpan data onile
        public MySqlDataAdapter da;// biar dataset nya keisi menggunakkan datagradeview
        public MySqlConnection GetConn()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user=root;database=FashionStore";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal" + ex.Message);
            }
            return conn; 

        }
    }

}
