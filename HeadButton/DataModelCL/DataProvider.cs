using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataModelCL
{
    public class DataProvider
    {
        public static string connString = "";

        public static List<string> listProducts = new List<string>();
        public static List<string> listCategories = new List<string>();
        public static List<string> listSuppliers = new List<string>();

        public static string ProductID(string _selectedProductName)
        {
            string _id = null;

            SqlConnection conn1 = new SqlConnection(connString);
            conn1.Open();

            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandText = "SELECT [ProductID] FROM [dbo].[Products] WHERE ProductName = @ProductName";
            cmd1.Parameters.AddWithValue("@ProductName", _selectedProductName);

            SqlDataReader reader = cmd1.ExecuteReader();
            reader.Read();
            _id = (reader.GetValue(0).ToString());
            reader.Close();

            return _id;
        }

        public static string CategoryID(string _selectedCategory)
        {
            string _categoryID = null;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [CategoryID] FROM [dbo].[Categories] WHERE CategoryName = @CategoryName";
            cmd.Parameters.AddWithValue("@CategoryName", _selectedCategory);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                _categoryID = (reader.GetValue(0).ToString());
            }

            reader.Close();
            conn.Close();
            return _categoryID;
        }

        public static string SupplierID(string _supplier)
        {
            string _supplierID = null;

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [SupplierID] FROM [dbo].[Suppliers] WHERE CompanyName = @CompanyName";
            cmd.Parameters.AddWithValue("@CompanyName", _supplier);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                _supplierID = (reader.GetValue(0).ToString());
            }

            reader.Close();
            conn.Close();
            return _supplierID;
        }

        public void GetSuppliers()
        {
            SqlConnection conn = new SqlConnection(connString);
            string sqlQuery = "SELECT [CompanyName] FROM [dbo].[Suppliers] ORDER BY SupplierID";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                listSuppliers.Add(rd.GetValue(0).ToString());
            }

            rd.Close();
            conn.Close();
        }
        public static string DiscontinuedInt(string discontinued)
        {
            string formattedValue = null;

            if (discontinued == "False")
            {
                formattedValue = "0";
            }
            else if (discontinued == "True")
            {
                formattedValue = "1";
            }
            return formattedValue;
        }

    }
}
