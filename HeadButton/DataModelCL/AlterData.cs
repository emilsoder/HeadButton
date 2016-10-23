using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModelCL
{
    public class AlterData
    {
        public string connString = "";

        //Used by HeadButton MainView
        public void RemoveProduct(string _selectedProductName)
        {
            string _id = DataProvider.ProductID(_selectedProductName).ToString();

            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = connection.CreateCommand();

            command.CommandText = "DELETE FROM [dbo].[Products] WHERE [ProductID] = @ProductID";
            command.Parameters.AddWithValue("@ProductID", _id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        //Used by EditProductProject
        public void EditProduct(string _newUnitPrice, string _newProductName, string _productIndex, string _selectedProductName)
        {
            string _id = DataProvider.ProductID(_selectedProductName).ToString();

            SqlConnection conn1 = new SqlConnection(connString);
            conn1.Open();

            SqlConnection conn = new SqlConnection(connString);
            string sqlQuery = "UPDATE [dbo].[Products] SET [ProductName] = @ProductName, [UnitPrice] = @UnitPrice WHERE [ProductID] = @ProductID";

            SqlCommand cmd = new SqlCommand(sqlQuery, conn);

            cmd.Parameters.AddWithValue("@ProductName", _newProductName);
            cmd.Parameters.AddWithValue("@UnitPrice", _newUnitPrice);
            cmd.Parameters.AddWithValue("@ProductID", _id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void InsertNewProduct(string productName, string unitsInStock, string unitsInOrder, string quantityPerUnit, string unitPrice, string reorderLevel, string selectedSupplier, string selectedCategory, string discontinued)
        {
            string category = DataProvider.CategoryID(selectedCategory);
            string supplier = DataProvider.SupplierID(selectedSupplier);
            string isDiscontinued = DataProvider.DiscontinuedInt(discontinued);

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO dbo.Products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)"
                + " VALUES (@ProductName, @SupplierID,  @CategoryID,  @QuantityPerUnit, @UnitPrice, @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued)";

            cmd.Parameters.AddWithValue("@ProductName", productName);
            cmd.Parameters.AddWithValue("@SupplierID", supplier);
            cmd.Parameters.AddWithValue("@CategoryID", category);

            cmd.Parameters.AddWithValue("@QuantityPerUnit", quantityPerUnit);
            cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
            cmd.Parameters.AddWithValue("@UnitsInStock", unitsInStock);

            cmd.Parameters.AddWithValue("@UnitsOnOrder", unitsInOrder);
            cmd.Parameters.AddWithValue("@ReorderLevel", reorderLevel);
            cmd.Parameters.AddWithValue("@Discontinued", isDiscontinued);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}