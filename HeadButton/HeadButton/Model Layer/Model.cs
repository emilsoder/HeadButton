using System.Data.SqlClient;
using HeadButton.Presenter_Layer;
using System.Configuration;

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


            cmd.CommandText = "SELECT [ProductName] FROM [dbo].[Products] WHERE CategoryID = @CategoryID";

            cmd.Parameters.AddWithValue("@CategoryID", _categoryIndex.ToString());

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Presenter.listProducts.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
            conn.Close();
        }

        public static void SetTextBoxes()
        {
            GetProduct(Presenter.selectedProductName);
        }

        public static void DeleteRecord(string _productIndex)
        {

        }

        public static void GetProduct(string _productName)
        {
            string _id = null;
            #region PROCEDURE 1: EXTRACT ID
            SqlConnection conn1 = new SqlConnection(connString);
            conn1.Open();

            SqlCommand cmd1 = conn1.CreateCommand();
            cmd1.CommandText = "SELECT [ProductID] FROM [dbo].[Products] WHERE ProductName = @ProductName";
            cmd1.Parameters.AddWithValue("@ProductName", _productName);

            SqlDataReader reader = cmd1.ExecuteReader();
            reader.Read();
            _id = (reader.GetValue(0).ToString());
            reader.Close();

            SqlCommand cmd2 = conn1.CreateCommand();
            cmd2.CommandText = "SELECT [ProductName], [UnitPrice] FROM [dbo].[Products] WHERE ProductID = @ProductID";
            cmd2.Parameters.AddWithValue("@ProductID", _id);

            SqlDataReader reader2 = cmd2.ExecuteReader();
            reader2.Read();
            Presenter.productName = (reader2.GetValue(0).ToString());
            Presenter.unitPrice = (reader2.GetValue(1).ToString());
            reader2.Close();

            conn1.Close();
            #endregion
        }
    }
}
    