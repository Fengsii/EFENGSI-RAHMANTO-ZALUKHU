using fashionStoreInventoryManajement.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace fashionStoreInventoryManajement.Controller
{
    internal class ValidasiController
    {
        //====== VALIDASI USERNAME =========\\
        public bool ValidasiUsername(string username)
        {
            
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }

           
            if (username.Length < 3 || username.Length > 11)
            {
                return false;
            }

            
            if (username[0] == ' ')
            {
                return false;
            }

            if (username.Contains("  "))
            {
                return false;
            }


            string forbiddenCharsPattern = @"[@#$%&*()!^+=\{\}\[\]|\\/<>\-;:?,.]";
            if (Regex.IsMatch(username, forbiddenCharsPattern))
            {
                return false;
            }

            return true;
        }

        //====== VALIDASI PASSWORD =========\\
        public bool ValidasiPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            if (password.Length < 3 || password.Length > 11)
            {
                return false;
            }

            string pattern = @"^(?=.*[A-Za-z])(?=.*\d{2,}).{3,11}$";

            return Regex.IsMatch(password, pattern);
        }
       

        //====== VALIDASI ID SUPPLIER =========\\
        public bool ValidasiIdSupplier(string IdSupplier)
        {

            if (string.IsNullOrEmpty(IdSupplier))
            {
                return false;
            }


            if (IdSupplier.Length != 4)
            {
                return false;
            }


            if (IdSupplier[0] != 'A')
            {
                return false;
            }


            if (IdSupplier[1] != '0')
            {
                return false;
            }

            string numericPart = IdSupplier.Substring(2);
            if (!int.TryParse(numericPart, out _))
            {
                return false;
            }


            if (IdSupplier.Contains(" "))
            {
                return false;
            }


            string forbiddenCharsPattern = @"[@#$%&*()!^+=\{\}\[\]|\\/<>\-;:?,.]";
            if (Regex.IsMatch(IdSupplier, forbiddenCharsPattern))
            {
                return false;
            }


            return true;
        }

        //====== VALIDASI ID CUSTOMER =========\\
        public bool ValidasiIdCustomer(string idCustomer)
        {

            if (string.IsNullOrEmpty(idCustomer))
            {
                return false;
            }


            if (idCustomer.Length != 4)
            {
                return false;
            }


            if (idCustomer[0] != 'B')
            {
                return false;
            }


            if (idCustomer[1] != '0')
            {
                return false;
            }

            string numericPart = idCustomer.Substring(2);
            if (!int.TryParse(numericPart, out _))
            {
                return false;
            }


            if (idCustomer.Contains(" "))
            {
                return false;
            }


            string forbiddenCharsPattern = @"[@#$%&*()!^+=\{\}\[\]|\\/<>\-;:?,.]";
            if (Regex.IsMatch(idCustomer, forbiddenCharsPattern))
            {
                return false;
            }


            return true;
        }

        //====== VALIDASI ID CATEGORY =========\\
        public bool ValidasiIdCategory(string idCategory)
        {

            if (string.IsNullOrEmpty(idCategory))
            {
                return false;
            }


            if (idCategory.Length != 4)
            {
                return false;
            }


            if (idCategory[0] != 'C')
            {
                return false;
            }


            if (idCategory[1] != '0')
            {
                return false;
            }

            string numericPart = idCategory.Substring(2);
            if (!int.TryParse(numericPart, out _))
            {
                return false;
            }


            if (idCategory.Contains(" "))
            {
                return false;
            }


            string forbiddenCharsPattern = @"[@#$%&*()!^+=\{\}\[\]|\\/<>\-;:?,.]";
            if (Regex.IsMatch(idCategory, forbiddenCharsPattern))
            {
                return false;
            }


            return true;
        }

        //====== VALIDASI ID PURCHASES =========\\
        public bool ValidasiIdPurchases(string IdPurchases)
        {

            if (string.IsNullOrEmpty(IdPurchases))
            {
                return false;
            }


            if (IdPurchases.Length != 4)
            {
                return false;
            }


            if (IdPurchases[0] != 'E')
            {
                return false;
            }


            if (IdPurchases[1] != '0')
            {
                return false;
            }

            string numericPart = IdPurchases.Substring(2);
            if (!int.TryParse(numericPart, out _))
            {
                return false;
            }


            if (IdPurchases.Contains(" "))
            {
                return false;
            }


            string forbiddenCharsPattern = @"[@#$%&*()!^+=\{\}\[\]|\\/<>\-;:?,.]";
            if (Regex.IsMatch(IdPurchases, forbiddenCharsPattern))
            {
                return false;
            }


            return true;
        }


        //====== VALIDASI ID SALES =========\\
        public bool ValidasiIdSales(string IdSales)
        {

            if (string.IsNullOrEmpty(IdSales))
            {
                return false;
            }


            if (IdSales.Length != 4)
            {
                return false;
            }


            if (IdSales[0] != 'F')
            {
                return false;
            }


            if (IdSales[1] != '0')
            {
                return false;
            }

            string numericPart = IdSales.Substring(2);
            if (!int.TryParse(numericPart, out _))
            {
                return false;
            }


            if (IdSales.Contains(" "))
            {
                return false;
            }


            string forbiddenCharsPattern = @"[@#$%&*()!^+=\{\}\[\]|\\/<>\-;:?,.]";
            if (Regex.IsMatch(IdSales, forbiddenCharsPattern))
            {
                return false;
            }


            return true;
        }

        //====== VALIDASI NAME PRODUCT =========\\
        public bool ValidasiNameProduct(string NameProduct)
        {
            if (string.IsNullOrEmpty(NameProduct))
            {
                return false;
            }

            if (NameProduct.Length < 3 || NameProduct.Length > 11)
            {
                return false;
            }

            if (NameProduct[0] == ' ')
            {
                return false;
            }

            if (NameProduct.Contains("  "))
            {
                return false;
            }

            string forbiddenCharsPattern = @"[@#$%&*()!^+=\{\}\[\]|\\/<>\-;:?,.]";
            if (Regex.IsMatch(NameProduct, forbiddenCharsPattern))
            {
                return false;
            }

            string containsNumbersPattern = @"\d"; // MENGECEK ANGKA //Simbol regex untuk mencocokkan angka desimal tunggal (digit 0 hingga 9).
            if (Regex.IsMatch(NameProduct, containsNumbersPattern))
            {
                return false;
            }

            return true;
        }


        //====== VALIDASI SIZE =========\\
        public bool ValidasiSize(string size)
        {
           
            if (string.IsNullOrEmpty(size))
            {
                return false;
            }

          
            if (size.Length < 1 || size.Length > 2)
            {
                return false;
            }

           
            char firstChar = size[0];
            if (firstChar != 'M' && firstChar != 'L' && firstChar != 'X')
            {
                return false;
            }

            if (size.Length == 2)
            {
                char secondChar = size[1];
                if (secondChar != 'L' || size == "ML" || size == "LL")
                {
                    return false;
                }
            }

            if (size.Contains(" "))
            {
                return false;
            }

            string forbiddenCharsPattern = @"[@#$%&*()!^+=\{\}\[\]|\\/<>\-;:?,.]";
            if (Regex.IsMatch(size, forbiddenCharsPattern))
            {
                return false;
            }

            return true;
        }

        //====== VALIDASI ANGKA=========\\
        public bool ValidasiHanyaAngka(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            string hanyaAngkaPattern = @"^\d+$";//Angka saja 0 - 9 (Rgex untuk mencocokkan angka)
            if (!Regex.IsMatch(input, hanyaAngkaPattern))// True = False > if tdk di esekusi tapi Kalau False = True > if di esekusi
            {
                return false;
            }

            return true;
        }

        //============== VALIDASI NOMOR HP ===========\\
        public bool ValidasiNomorHP(string nomorHP)
        {
            string pattern = @"^(?:\+62|62|0)8[1-9][0-9]{7,11}$";

            if (!Regex.IsMatch(nomorHP, pattern))
            {
                return false;
            }

            if (nomorHP.Any(c => !char.IsDigit(c) && c != '+' && c != ' '))// Any fungsinya memeriksa setiap karakter dalam string HP / C  Representasi karakter no HP  
                                                                           //Lambda Expression 
            {
                return false;
            }

            if (nomorHP.Contains(" "))
            {
                return false;
            }

            return true;
        }


        //============== Validasi NAMA ===============\\
        public bool ValidasiNama(string nama)
        {
            if (string.IsNullOrEmpty(nama))
            {
                return false;
            }

            string hanyaHurufSpasiPattern = @"^[a-zA-Z ]+$";
            if (!Regex.IsMatch(nama, hanyaHurufSpasiPattern))
            {
                return false;
            }

            // Cek jumlah spasi maksimal 3
            int jumlahSpasi = nama.Count(c => c == ' ');
            //                           lambda expression, Mengecek apakah karakter adalah spasi.
            if (jumlahSpasi > 3)
            {
                return false;
            }

            if (nama.Contains("  "))
            {
                return false;
            }

            return true;
        }

        


    }
}
