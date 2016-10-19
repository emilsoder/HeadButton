using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using HeadButton.Presenter_Layer;


namespace HeadButton.Model_Layer
{
    #region Klassbeskrivning
    //Här lägger vi logik, databaslogik och liknande
    #endregion

    public class Model
    {
        #region Connection String
        public static string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NORTHWND;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        #endregion

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

        public static void GetProductsByIndex()
        {
            var selectedItem = Presenter.categoryIndex + 1;

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [ProductName], [ProductID] FROM [dbo].[Products] WHERE CategoryID = @CategoryID";
            cmd.Parameters.AddWithValue("@CategoryID", selectedItem.ToString());

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Presenter.listProducts.Add(reader.GetValue(1).ToString() + ". " + reader.GetValue(0).ToString());
            }

            reader.Close();
            conn.Close();
        }

        public static void SetTextBoxes()
        {
            SetUnitPrice();
            SetProductName();
        }

        private static void SetUnitPrice()
        {
            int selectedItem = Presenter.productIndex;

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [UnitPrice] FROM [dbo].[Products] WHERE ProductID = @ProductID";
            cmd.Parameters.AddWithValue("@ProductID", selectedItem.ToString());

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            Presenter.unitPrice = (reader.GetValue(0).ToString());

            reader.Close();
            conn.Close();
        }

        private static void SetProductName()
        {
            int selectedItem = Presenter.productIndex;

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [ProductName] FROM [dbo].[Products] WHERE ProductID = @ProductID";

            cmd.Parameters.AddWithValue("@ProductID", selectedItem.ToString());

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            Presenter.productName = (reader.GetValue(0).ToString());

            reader.Close();
            conn.Close();
        }

        public static void Update()
        {
            SqlConnection conn = new SqlConnection(connString);
            string sqlQuery = "UPDATE [dbo].[Products] SET [ProductName]=@ProductName, [UnitPrice]=@UnitPrice WHERE [ProductID]=@ProductID";

            SqlCommand cmd = new SqlCommand(sqlQuery, conn);

            cmd.Parameters.AddWithValue("@ProductName", Presenter.newProductName);
            cmd.Parameters.AddWithValue("@UnitPrice", Presenter.newUnitPrice);
            cmd.Parameters.AddWithValue("@ProductID", Presenter.productIndex);

            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
