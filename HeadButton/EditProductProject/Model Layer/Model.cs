using System.Data.SqlClient;
using System.Configuration;

namespace EditProductProject.Model_Layer
{
    public class Model
    {
        public static string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public void UpdateChanges(string _unitPrice, string _productName, string _productIndex)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                string sqlQuery = "UPDATE [dbo].[Products] SET [ProductName]=@ProductName, [UnitPrice]=@UnitPrice WHERE [ProductID]=@ProductID";

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                cmd.Parameters.AddWithValue("@ProductName", _productName);
                cmd.Parameters.AddWithValue("@UnitPrice", _unitPrice);
                cmd.Parameters.AddWithValue("@ProductID", _productIndex);

                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }
    }
}
