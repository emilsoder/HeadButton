using System.Data.SqlClient;
using HeadButton.Presenter_Layer;
using System.Configuration;
using System.Windows.Forms;
using System.Diagnostics;

namespace HeadButton.Model_Layer
{
    #region Klassbeskrivning
    //Här lägger vi logik, databaslogik och liknande
    #endregion

    public class Model
    {
        public static string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            
        public static void GetCategories()
        {
            SqlConnection conn = new SqlConnection(connString);

            string sqlQuery = "SELECT [CategoryName] FROM [dbo].[Categories]";

            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            conn.Open();

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                Presenter.listCategories.Add(rd.GetValue(0).ToString());
            }

            rd.Close();
            conn.Close();
        }

        public static void GetProductsByIndex(int _categoryIndex)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [ProductName] FROM [dbo].[Products] WHERE CategoryID = @CategoryID" 
                + " ORDER BY ProductName";

            cmd.Parameters.AddWithValue("@CategoryID", _categoryIndex.ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Presenter.listProducts.Add(reader.GetValue(0).ToString());
            }

            reader.Close();
            conn.Close();
        }

        public static void RemoveProduct(string _selectedProductName)
        {
            string _id = ProductID(_selectedProductName).ToString();

            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = connection.CreateCommand();

            command.CommandText = "DELETE FROM [dbo].[Products] WHERE [ProductID] = @ProductID";
            command.Parameters.AddWithValue("@ProductID", _id);

            connection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("You do not have permission to delete this product, but you can edit it instead.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Debug.WriteLine(ex.Message);
            }
            connection.Close();
        }

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

        public static void GetProductToEdit(string _selectedProductName)
        {
            string _id = ProductID(_selectedProductName).ToString();

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [ProductName], [UnitPrice] FROM [dbo].[Products] WHERE ProductID = @ProductID";
            cmd.Parameters.AddWithValue("@ProductID", _id);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Presenter.productName = (reader.GetValue(0).ToString());
            Presenter.unitPrice = (reader.GetValue(1).ToString());
            reader.Close();
            conn.Close();
        }
    }
}
    
            //SqlCommand cmd1 = conn1.CreateCommand();
            //cmd1.CommandText = "SELECT [ProductID] FROM [dbo].[Products] WHERE ProductName = @ProductName";
            //cmd1.Parameters.AddWithValue("@ProductName", _selectedProductName);

            //SqlDataReader reader = cmd1.ExecuteReader();
            //reader.Read();
            //_id = (reader.GetValue(0).ToString());
            //reader.Close();       
            //public static void SetTextBoxes()
            //{
            //    GetProduct(Presenter.selectedProductName);
            //}
