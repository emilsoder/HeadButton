using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using AddProductProject.Presenter_Layer;

namespace AddProductProject.Model_Layer
{
    public class Model
    {
        public static readonly string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        #region PROPERTIES
        public string productName { get; set; }
        public string unitsInStock { get; set; }
        public string unitsOnOrder { get; set; }
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
                cmd.CommandText = "INSERT INTO dbo.Products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)"
                    + " VALUES (@ProductName, @SupplierID,  @CategoryID,  @QuantityPerUnit, @UnitPrice, @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued)";

                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@SupplierID", SupplierID());
                cmd.Parameters.AddWithValue("@CategoryID", CategoryID());

                cmd.Parameters.AddWithValue("@QuantityPerUnit", quantityPerUnit);
                cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                cmd.Parameters.AddWithValue("@UnitsInStock", unitsInStock);

                cmd.Parameters.AddWithValue("@UnitsOnOrder", unitsOnOrder);
                cmd.Parameters.AddWithValue("@ReorderLevel", reorderLevel);
                cmd.Parameters.AddWithValue("@Discontinued", discontinuedInt);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            MessageBox.Show("Product added!", "Successful!");
        }

        /// <summary>
        /// Gets the collection of Suppliers. 
        /// 
        /// Fills ComboBox with values
        /// </summary>
        public static void GetSuppliers()
        {
            SqlConnection conn = new SqlConnection(connString);
            string sqlQuery = "SELECT [CompanyName] FROM [dbo].[Suppliers] ORDER BY SupplierID";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                Presenter.SupplierList.Add(rd.GetValue(0).ToString());
            }

            rd.Close();
            conn.Close();
        }

        /// <summary>
        /// Get the value of SupplierID
        /// </summary>
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

        /// <summary>
        /// Get the value of CategoryID
        /// </summary>
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
