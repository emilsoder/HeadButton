using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using AddProductProject.Presenter_Layer;

namespace AddProductProject.Model_Layer
{
    public class Model
    {
        public static readonly string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        #region PROPERTIES
        public string productName { get; set; }
        public string unitsInStock { get; set; }
        public string unitsInOrder { get; set; }
        public string quantityPerUnit { get; set; }
        public string unitPrice { get; set; }
        public string reorderLevel { get; set; }
        public string discontinuedInt { get; set; } 
        public string supplier { get; set; }
        public string category { get; set; }
        #endregion

        public void AddRecord()
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            try
            {
                // Skapa T-SQL kommando för att lägga till ny produkt
                cmd.CommandText = "INSERT INTO dbo.Products ()";

                // Ändra "@parameter" till respektive parameter 
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@CategoryID", CategoryID());
                cmd.Parameters.AddWithValue("@parameter", SupplierID());
                cmd.Parameters.AddWithValue("@parameter", unitPrice);
                cmd.Parameters.AddWithValue("@parameter", unitsInStock);
                cmd.Parameters.AddWithValue("@parameter", quantityPerUnit);
                cmd.Parameters.AddWithValue("@parameter", unitsInOrder);
                cmd.Parameters.AddWithValue("@parameter", reorderLevel);
                cmd.Parameters.AddWithValue("@parameter", unitPrice);
                cmd.Parameters.AddWithValue("@parameter", discontinuedInt);

                cmd.ExecuteNonQuery();
                cmd.StatementCompleted += Cmd_StatementCompleted;
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("********  " + ex.Message + "  ********");
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        private void Cmd_StatementCompleted(object sender, System.Data.StatementCompletedEventArgs e)
        {
            if (e.RecordCount != 0)
                MessageBox.Show("Product added!", "Successful!");        
        }

        public static void GetSuppliers()
        {
            SqlConnection conn = new SqlConnection(connString);

            string sqlQuery = "SELECT [CompanyName] FROM [dbo].[Suppliers] ORDER BY SupplierID";

            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            conn.Open();

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                //Presenter.listCategories.Add(rd.GetValue(0).ToString());
                Presenter.SupplierList.Add(rd.GetValue(0).ToString());
            }

            rd.Close();
            conn.Close();
        }

        public string SupplierID()
        {
            string _supplierID = null;

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT [SupplierID] FROM [dbo].[Suppliers] WHERE CompanyName = @CompanyName";
            cmd.Parameters.AddWithValue("@CompanyName", supplier);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                _supplierID = (reader.GetValue(0).ToString());
            }

            reader.Close();
            conn.Close();

            return _supplierID;
        }

        public string CategoryID()
        {
            string _categoryID = null;

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT [CategoryID] FROM [dbo].[Categories] WHERE CategoryName = @CategoryName";
            cmd.Parameters.AddWithValue("@CategoryName", category);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                _categoryID = (reader.GetValue(0).ToString());
            }

            reader.Close();
            conn.Close();

            return _categoryID;
        }
    }
}
