using fashionStoreInventoryManajement.Model;
using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace fashionStoreInventoryManajement.Controller
{
    internal class FashionStoreController:Model.Connection
    {
        //================== SUPPLIER ==================\\
        public DataTable showSupplier(MySqlCommand c)
        {
            DataTable data = new DataTable();
            try
            {
                string show = "SELECT * FROM Supplier";
                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void addSupplier(string idSupplier, string namaSupplier, string noSupplier)
        {
            string addsup = "INSERT INTO Supplier values(" + "@id_supplier,@nama_supplier,@no_supplier)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(addsup, GetConn());
                cmd.Parameters.Add("@id_supplier", MySqlConnector.MySqlDbType.VarChar).Value = idSupplier;
                cmd.Parameters.Add("@nama_supplier", MySqlConnector.MySqlDbType.VarChar).Value = namaSupplier;
                cmd.Parameters.Add("@no_supplier", MySqlConnector.MySqlDbType.VarChar).Value = noSupplier;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Supplier Gagal" + ex.Message);
            }
        }

        public void updateSupplier(string idSupplier, string namaSupplier, string noSupplier)
        {
            string update = "UPDATE Supplier set nama_supplier=@nama_supplier, nomor_telephone_supplier=@no_supplier where id_supplier=@id_supplier";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_supplier", MySqlConnector.MySqlDbType.VarChar).Value = idSupplier;
                cmd.Parameters.Add("@nama_supplier", MySqlConnector.MySqlDbType.VarChar).Value = namaSupplier;
                cmd.Parameters.Add("@no_supplier", MySqlConnector.MySqlDbType.VarChar).Value = noSupplier;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Supplier Gagal" + ex.Message);
            }
        }

        public void deleteSupplier(string idSupplier)
        {
            string hapus = "DELETE FROM Supplier WHERE id_supplier=@id_supplier";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id_supplier", MySqlConnector.MySqlDbType.VarChar).Value = idSupplier;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete Data Supplier Gagal" + ex.Message);
            }
        }



        //================== CUSTOMER ==================\\
        public DataTable showCustomer(MySqlCommand c)
        {
            DataTable data = new DataTable();
            try
            {
                string show = "SELECT * FROM Customer";
                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void addCustomer(string idCustomer, string namaCustomer, string noCustomer)
        {
            string addsup = "INSERT INTO Customer values(" + "@id_customer,@nama_customer,@no_customer)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(addsup, GetConn());
                cmd.Parameters.Add("@id_customer", MySqlConnector.MySqlDbType.VarChar).Value = idCustomer;
                cmd.Parameters.Add("@nama_customer", MySqlConnector.MySqlDbType.VarChar).Value = namaCustomer;
                cmd.Parameters.Add("@no_customer", MySqlConnector.MySqlDbType.VarChar).Value = noCustomer;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Customer Gagal" + ex.Message);
            }
        }

        public void updateCustomer(string idCustomer, string namaCustomer, string noCustomer)
        {
            string update = "UPDATE Customer set  nama_costumer=@nama_customer, nomor_telephone_custumer=@no_customer where id_customer=@id_customer";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_customer", MySqlConnector.MySqlDbType.VarChar).Value = idCustomer;
                cmd.Parameters.Add("@nama_customer", MySqlConnector.MySqlDbType.VarChar).Value = namaCustomer;
                cmd.Parameters.Add("@no_customer", MySqlConnector.MySqlDbType.VarChar).Value = noCustomer;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Customer Gagal" + ex.Message);
            }
        }

        public void deleteCustomer(string idCustomer)
        {
            string hapus = "DELETE FROM Customer WHERE id_customer=@id_customer";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id_customer", MySqlConnector.MySqlDbType.VarChar).Value = idCustomer;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete Data Customer Gagal" + ex.Message);
            }
        }


        //================== CATEGORY ==================\\
        public DataTable showCategory(MySqlCommand c)
        {
            DataTable data = new DataTable();
            try
            {
                string show = "SELECT * FROM Category";
                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void addCategory(string idCategory, string namaCategory)
        {
            string addsup = "INSERT INTO Category values(" + "@id_category,@nama_category)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(addsup, GetConn());
                cmd.Parameters.Add("@id_category", MySqlConnector.MySqlDbType.VarChar).Value = idCategory;
                cmd.Parameters.Add("@nama_category", MySqlConnector.MySqlDbType.VarChar).Value = namaCategory;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Category Gagal" + ex.Message);
            }
        }

        public void updateCategory(string idCategory, string namaCategory)
        {
            string update = "UPDATE Category set  nama_category=@nama_category where  kode_category=@id_category";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_category", MySqlConnector.MySqlDbType.VarChar).Value = idCategory;
                cmd.Parameters.Add("@nama_category", MySqlConnector.MySqlDbType.VarChar).Value = namaCategory;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Category Gagal" + ex.Message);
            }
        }

        public void deleteCategory(string idCategory)
        {
            string hapus = "DELETE FROM Category WHERE  kode_category=@id_category";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id_category", MySqlConnector.MySqlDbType.VarChar).Value = idCategory;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete Data Category Gagal" + ex.Message);
            }
        }


        //================== PRURCHASES ==================\\
        public DataTable showPurchases(MySqlCommand c)
        {
            DataTable data = new DataTable();
            try
            {
                string show = "SELECT * FROM Pembelian";
                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void deletePurchases(string id_pembelian)
        {
            string hapus = "DELETE FROM Pembelian WHERE id_pembelian=@id_pembelian";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id_pembelian", MySqlConnector.MySqlDbType.VarChar).Value = id_pembelian;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete Data Purchases Gagal" + ex.Message);
            }
        }


        public void addPurchasest(string purchaseId, string supplierId, string categoryCode, string productName, string size, string amount, string price, DateTime purchaseDate, byte[] image)
        {
            string add = "INSERT INTO Pembelian (id_pembelian, id_supplier, kode_category, nama_baju, ukuran, jumlah, harga, total_harga, tanggal_pembelian, gambar) " +
                         "VALUES (@purchaseId, @supplierId, @categoryCode, @productName, @size, @amount, @price, @totalPrice, @purchaseDate, @image)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.AddWithValue("@purchaseId", purchaseId);
                cmd.Parameters.AddWithValue("@supplierId", supplierId);
                cmd.Parameters.AddWithValue("@categoryCode", categoryCode);
                cmd.Parameters.AddWithValue("@productName", productName);
                cmd.Parameters.AddWithValue("@size", size);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@totalPrice", Convert.ToInt32(amount) * Convert.ToInt32(price));
                cmd.Parameters.AddWithValue("@purchaseDate", purchaseDate);
                cmd.Parameters.AddWithValue("@image", image);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Data Failed!!" + ex.Message);
            }
        }

    

        //================== PRURCHASES GET DATA PURCHASES FOR REPORT ==================\\
        public DataTable getSupplierPurchasesReport()
        {
            DataTable reportData = new DataTable();
            try
            {
                string query = @"
            SELECT 
                s.nama_supplier AS 'Nama Supplier',
                p.nama_baju AS 'Nama Produk',
                p.jumlah AS 'Jumlah',
                p.harga AS 'Harga',
                (p.jumlah * p.harga) AS 'Total',
                p.ukuran AS 'Ukuran',
                c.nama_category AS 'Kategori',
                p.tanggal_pembelian AS 'Tanggal Pembelian'
            FROM 
                Pembelian p
            INNER JOIN 
                Supplier s ON p.id_supplier = s.id_supplier
            INNER JOIN 
                Category c ON p.kode_category = c.kode_category
            ORDER BY 
                p.tanggal_pembelian DESC";

                cmd = new MySqlConnector.MySqlCommand(query, GetConn());
                da = new MySqlConnector.MySqlDataAdapter(cmd);
                da.Fill(reportData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating supplier purchases report: " + ex.Message);
            }
            return reportData;
        }

        //================== PRURCHASES GET DATA SALES FOR REPORT ==================\\
        public DataTable getSalesReport()
        {
            DataTable reportData = new DataTable();
            try
            {
                string query = @"
        SELECT 
            c.nama_costumer AS 'Nama Customer',
            p.nama_baju AS 'Nama Produk',
            s.ukuran AS 'Ukuran',
            s.harga AS 'Harga Satuan',
            s.jumlah AS 'Jumlah Terjual',
            s.total_harga AS 'Total Harga',
            cat.nama_category AS 'Kategori',
            s.tanggal_penjualan AS 'Tanggal Penjualan'
        FROM 
            Penjualan s
        INNER JOIN 
            Customer c ON s.id_customer = c.id_customer
        INNER JOIN 
            Product p ON s.id_produk = p.id_produk
        INNER JOIN 
            Category cat ON p.kode_category = cat.kode_category
        ORDER BY 
            s.tanggal_penjualan DESC";
                cmd = new MySqlConnector.MySqlCommand(query, GetConn());
                da = new MySqlConnector.MySqlDataAdapter(cmd);
                da.Fill(reportData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating sales report: " + ex.Message);
            }
            return reportData;
        }



        //================== PRODUCT ==================\\
        public DataTable showProduct(MySqlCommand c)
        {
            DataTable data = new DataTable();
            try
            {
                string show = "SELECT * FROM Product";
                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        
        public void addProduct(string id_pembelian, string kode_category, string nama_baju, string ukuran,
        string harga, string stok, DateTime tanggal_pembelian, byte[] gambar)
        {
           
            string addsup = "INSERT INTO Product (id_pembelian, kode_category, nama_baju, ukuran, harga, stok, tanggal_pembelian, gambar) " +
                            "VALUES (@id_pembelian, @kode_category, @nama_baju, @ukuran, @harga, @stok, @tanggal_pembelian, @gambar)";
            try
            {
                // Membuat koneksi dan perintah
                cmd = new MySqlConnector.MySqlCommand(addsup, GetConn());

                // Menambahkan parameter
                cmd.Parameters.Add("@id_pembelian", MySqlConnector.MySqlDbType.VarChar).Value = id_pembelian;
                cmd.Parameters.Add("@kode_category", MySqlConnector.MySqlDbType.VarChar).Value = kode_category;
                cmd.Parameters.Add("@nama_baju", MySqlConnector.MySqlDbType.VarChar).Value = nama_baju;
                cmd.Parameters.Add("@ukuran", MySqlConnector.MySqlDbType.VarChar).Value = ukuran;
                cmd.Parameters.Add("@harga", MySqlConnector.MySqlDbType.Int32).Value = Convert.ToInt32(harga); // Konversi harga ke INT
                cmd.Parameters.Add("@stok", MySqlConnector.MySqlDbType.Int32).Value = Convert.ToInt32(stok); // Konversi stok ke INT
                cmd.Parameters.Add("@tanggal_pembelian", MySqlConnector.MySqlDbType.Date).Value = tanggal_pembelian; // Format DATE
                cmd.Parameters.Add("@gambar", MySqlConnector.MySqlDbType.LongBlob).Value = gambar;

                // Eksekusi query
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Product Gagal: " + ex.Message);
            }
        }



        public void updateProduct(string id_produk, string id_pembelian, string kode_category, string nama_baju, string ukuran,
        string harga, string stok, DateTime tanggal_pembelian, byte[] gambar)
        {
            string update = "UPDATE Product SET id_pembelian=@id_pembelian, kode_category=@kode_category, nama_baju=@nama_baju, ukuran=@ukuran, " +
                            "harga=@harga, stok=@stok, tanggal_pembelian=@tanggal_pembelian, gambar=@gambar WHERE id_produk=@id_produk";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_produk", MySqlConnector.MySqlDbType.VarChar).Value = id_produk;
                cmd.Parameters.Add("@id_pembelian", MySqlConnector.MySqlDbType.VarChar).Value = id_pembelian;
                cmd.Parameters.Add("@kode_category", MySqlConnector.MySqlDbType.VarChar).Value = kode_category;
                cmd.Parameters.Add("@nama_baju", MySqlConnector.MySqlDbType.VarChar).Value = nama_baju;
                cmd.Parameters.Add("@ukuran", MySqlConnector.MySqlDbType.VarChar).Value = ukuran;
                cmd.Parameters.Add("@harga", MySqlConnector.MySqlDbType.VarChar).Value = harga;
                cmd.Parameters.Add("@stok", MySqlConnector.MySqlDbType.VarChar).Value = stok;
                cmd.Parameters.Add("@tanggal_pembelian", MySqlConnector.MySqlDbType.DateTime).Value = tanggal_pembelian;
                cmd.Parameters.Add("@gambar", MySqlConnector.MySqlDbType.Blob).Value = gambar;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Product Gagal: " + ex.Message);
            }
        }
        public void deleteProduct(string id_produk)
        {
            string hapus = "DELETE FROM Product WHERE id_produk=@id_produk";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id_produk", MySqlConnector.MySqlDbType.VarChar).Value = id_produk;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete Data Product Gagal" + ex.Message);
            }
        }



        //================== SALES ==================\\

        public DataTable showSales(MySqlCommand c)
        {
            DataTable data = new DataTable();
            try
            {
                string show = "SELECT * FROM Penjualan";
                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }


        public void addSales(string id_penjualan, string id_customer, string id_produk, string jumlah, DateTime tanggal_penjualan)
        {
            string addsup = "INSERT INTO Penjualan (id_penjualan, id_customer, id_produk, jumlah, tanggal_penjualan) " +
                            "VALUES (@id_penjualan, @id_customer, @id_produk, @jumlah, @tanggal_penjualan)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(addsup, GetConn());
                cmd.Parameters.Add("@id_penjualan", MySqlConnector.MySqlDbType.VarChar).Value = id_penjualan;
                cmd.Parameters.Add("@id_customer", MySqlConnector.MySqlDbType.VarChar).Value = id_customer;
                cmd.Parameters.Add("@id_produk", MySqlConnector.MySqlDbType.VarChar).Value = id_produk;
                cmd.Parameters.Add("@jumlah", MySqlConnector.MySqlDbType.Int32).Value = int.Parse(jumlah);
                cmd.Parameters.Add("@tanggal_penjualan", MySqlConnector.MySqlDbType.Date).Value = tanggal_penjualan;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Sales Gagal: " + ex.Message);
            }
        }

        public void deleteSales(string id_produk)
        {
            string hapus = "DELETE FROM Penjualan WHERE id_penjualan=@id_penjualan";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id_penjualan", MySqlConnector.MySqlDbType.VarChar).Value = id_produk;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete Data Sales Gagal" + ex.Message);
            }
        }




        private readonly Connection connection = new Connection(); // Inisialisasi objek Connection

        //======================= SEARCH SUPPLIER ==================\\
        public DataTable SearchSupplier(string search)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = connection.GetConn()) 
                {
                    string query = @"
                        SELECT * 
                        FROM Supplier 
                        WHERE CONCAT(id_supplier, nama_supplier, nomor_telephone_supplier) LIKE @search";

                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@search", "%" + search + "%"); 

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            return dt;
        }


        //======================= SEARCH CUSTOMER ==================\\
        public DataTable SearchCustomer(string search)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = connection.GetConn()) 
                {
                    string query = @"
                        SELECT * 
                        FROM Customer  
                        WHERE CONCAT(id_customer, nama_costumer, nomor_telephone_custumer) LIKE @search";

                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@search", "%" + search + "%"); 

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            return dt;
        }

        //======================= SEARCH CUSTOMER ==================\\
        public DataTable SearchCategory(string search)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = connection.GetConn()) 
                {
                    string query = @"
                        SELECT * 
                        FROM Category  
                        WHERE CONCAT(kode_category, nama_category) LIKE @search";

                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@search", "%" + search + "%"); 

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            return dt;
        }

        //======================= SEARCH PRODUCT ==================\\
        public DataTable SearchProduct(string search, DateTime? tanggalPembelian = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = connection.GetConn()) 
                {
                   
                    string query = @"
                SELECT * 
                FROM Product  
                WHERE (CONCAT(id_produk, id_pembelian, kode_category, nama_baju, ukuran, harga, stok) LIKE @search)
                      AND (@tanggalPembelian IS NULL OR DATE(tanggal_pembelian) = @tanggalPembelian)";

                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@search", "%" + search + "%"); 
                    command.Parameters.AddWithValue("@tanggalPembelian", tanggalPembelian.HasValue ? tanggalPembelian.Value.ToString("yyyy-MM-dd") : (object)DBNull.Value);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            return dt;
        }


        //======================= SEARCH PURCAHSES ==================\\
        public DataTable SearchPurchases(string search, DateTime? tanggalPembelian = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = connection.GetConn())
                {
                    string query = @"
                SELECT * 
                FROM Pembelian  
                WHERE (CONCAT(id_pembelian, id_supplier, kode_category, nama_baju, ukuran, jumlah, harga, total_harga, tanggal_pembelian) LIKE @search)
                      AND (@tanggalPembelian IS NULL OR DATE(tanggal_pembelian) = @tanggalPembelian)";

                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@search", "%" + search + "%");
                    command.Parameters.AddWithValue("@tanggalPembelian", tanggalPembelian.HasValue ? tanggalPembelian.Value.ToString("yyyy-MM-dd") : (object)DBNull.Value);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            return dt;
        }


       //======================= SEARCH SALES ==================\\
        public DataTable SearchSales(string search, DateTime? tanggalPenjualan = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = connection.GetConn())
                {

                    string query = @"
                SELECT * 
                FROM Penjualan 
                WHERE (CONCAT(id_penjualan, id_customer, id_produk, nama_baju, ukuran, jumlah, harga, total_harga, tanggal_penjualan) LIKE @search)
                      AND (@tanggalPenjualan IS NULL OR DATE(tanggal_penjualan) = @tanggalPenjualan)";

                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@search", "%" + search + "%");
                    command.Parameters.AddWithValue("@tanggalPenjualan", tanggalPenjualan.HasValue ? tanggalPenjualan.Value.ToString("yyyy-MM-dd") : (object)DBNull.Value);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            return dt;
        }

    }
}
