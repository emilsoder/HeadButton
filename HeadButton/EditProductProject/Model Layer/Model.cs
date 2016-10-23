using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace EditProductProject.Model_Layer
{
    public class Model
    {
        public static string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public void UpdateChanges(string _newUnitPrice, string _newProductName, string _productIndex, string _selectedProduct)
        {
            try
            {
                #region PROCEDURE 1: EXTRACT ID            
                string _id = null;
                SqlConnection conn1 = new SqlConnection(connString);
                conn1.Open();

                SqlCommand cmd1 = conn1.CreateCommand();
                cmd1.CommandText = "SELECT [ProductID] FROM [dbo].[Products] WHERE ProductName = @ProductName";
                cmd1.Parameters.AddWithValue("@ProductName", _selectedProduct);

                SqlDataReader reader = cmd1.ExecuteReader();
                reader.Read();
                _id = (reader.GetValue(0).ToString());
                reader.Close();
                conn1.Close();
                #endregion

                #region PRODECURE 2: UPDATE RECORD AT ID
                SqlConnection conn = new SqlConnection(connString);
                string sqlQuery = "UPDATE [dbo].[Products] SET [ProductName] = @ProductName, [UnitPrice] = @UnitPrice WHERE [ProductID] = @ProductID";

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                cmd.Parameters.AddWithValue("@ProductName", _newProductName);
                cmd.Parameters.AddWithValue("@UnitPrice", _newUnitPrice);
                cmd.Parameters.AddWithValue("@ProductID", _id);

                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
                #endregion
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Debug.WriteLine(ex.Source + ex.Data + ex.Message);
            }
        }
    }
}
