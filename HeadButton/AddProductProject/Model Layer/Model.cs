using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace AddProductProject.Model_Layer
{
    public class Model
    {
        public readonly string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        
        #region PROPERTIES
        public string productName { get; set; }
        public string unitsInStock { get; set; }
        public string unitsInOrder { get; set; }
        public string quantityPerUnit { get; set; }
        public string unitPrice { get; set; }
        public string reorderLevel { get; set; }

        public string supplierID { get; set; }
        public string categoryID { get; set; }
        public string discontinuedInt { get; set; } 
        #endregion

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
                cmd.Parameters.AddWithValue("@parameter", discontinuedInt);
                cmd.StatementCompleted += Cmd_StatementCompleted;

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
    }
}
