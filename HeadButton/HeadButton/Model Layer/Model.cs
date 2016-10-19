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
        public static void FillData()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string sqlQuery = "SELECT [CategoryName] FROM [NORTHWND].[dbo].[Categories]";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                Presenter.listCategories.Add(rd.GetValue(0).ToString());
            }
        }

        public static void Update()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string sqlQuery = "UPDATE [NORTHWND].[dbo].[Products] SET [ProductName]=@ProductName, [UnitPrice]=@UnitPrice WHERE [ProductID]=@ProductID";
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
