using System.Data.SqlClient;
using System.Configuration;
using AddProductProject.Presenter_Layer;
using System.Diagnostics;
using System.Windows.Forms;

namespace AddProductProject.Model_Layer
{
    public class Model : Presenter
    {
        public readonly string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;     

        public void AddRecord()
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            try
            {
                // TODO: 
                // Skapa T-SQL kommando för att lägga till ny produkt
                cmd.CommandText = "INSERT INTO dbo.Products ()";

                // TODO: 
                // Ändra "@parameter" till respektive parameter 
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@CategoryID", categoryID);

                cmd.Parameters.AddWithValue("@parameter", supplierID);

                cmd.Parameters.AddWithValue("@parameter", unitPrice);
                cmd.Parameters.AddWithValue("@parameter", unitsInStock);
                cmd.Parameters.AddWithValue("@parameter", quantityPerUnit);

                cmd.Parameters.AddWithValue("@parameter", unitsInOrder);
                cmd.Parameters.AddWithValue("@parameter", reorderLevel);
                cmd.Parameters.AddWithValue("@parameter", unitPrice);
                cmd.Parameters.AddWithValue("@parameter", isDiscontinued);

                cmd.ExecuteNonQuery();
                cmd.StatementCompleted += Cmd_StatementCompleted;
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.ToString());
                MessageBox.Show(ex.Errors.ToString() + "  --- " + ex.Message);
            }
            conn.Close();
            
        }

        private void Cmd_StatementCompleted(object sender, System.Data.StatementCompletedEventArgs e)
        {
            if (e.RecordCount != 0)
            {
                sqlTransactionSuccessful = true;
            }
        }
    }
}
