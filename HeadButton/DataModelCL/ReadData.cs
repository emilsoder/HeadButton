using System.Data.SqlClient;

namespace DataModelCL
{
    public class ReadData
    {
        public string connString = "";

        public string productName { get; set; }
        public string unitPrice { get; set; }

        public void ProductToEdit(string _selectedProductName)
        {
            string _id = DataProvider.ProductID(_selectedProductName).ToString();

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [ProductName], [UnitPrice] FROM [dbo].[Products] WHERE ProductID = @ProductID";
            cmd.Parameters.AddWithValue("@ProductID", _id);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            productName = (reader.GetValue(0).ToString());
            unitPrice = (reader.GetValue(1).ToString());
            reader.Close();
            conn.Close();
        }

        public void GetCategories()
        {
            SqlConnection conn = new SqlConnection(connString);

            string sqlQuery = "SELECT [CategoryName] FROM [dbo].[Categories]";

            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            conn.Open();

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                DataProvider.listCategories.Add(rd.GetValue(0).ToString());
            }

            rd.Close();
            conn.Close();
        }

        public void GetProductsByIndex(int _categoryIndex)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [ProductName] FROM [dbo].[Products] WHERE CategoryID = @CategoryID";
            cmd.Parameters.AddWithValue("@CategoryID", _categoryIndex.ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DataProvider.listProducts.Add(reader.GetValue(0).ToString());
            }

            reader.Close();
            conn.Close();
        }
    }
}
