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
    //Här lägger vi logik, databaslogik och liknande
    public class Model
    {
        #region Connection String
        public static string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        #endregion

        public static void GetCategories()
        {
            SqlConnection conn = new SqlConnection(connString);

            string sqlQuery = "SELECT [CategoryName] FROM [NORTHWND].[dbo].[Categories]";
            //string sqlQuery = "SELECT [CategoryName] FROM [dbo].[Categories]";

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
            var selectedItem = (Presenter.categoryIndex) + 1;

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT top(1000)"
                + "[ProductName]"
                + "FROM [NORTHWND].[dbo].[Products]"
                + "where CategoryID="
                + selectedItem.ToString();

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
            SetUnitPrice();
            SetProductName();
        }

        private static void SetUnitPrice()
        {
            int selectedItem = Presenter.productIndex + 1;

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [UnitPrice]" 
                + "FROM [NORTHWND].[dbo].[Products]" 
                + "where ProductID=" 
                + selectedItem.ToString();

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            //while (reader.Read())
            //{
            Presenter.unitPrice = (reader.GetValue(0).ToString());
            //}

            reader.Close();
            conn.Close();
        }

        private static void SetProductName()
        {
            int selectedItem = Presenter.productIndex + 1;

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [ProductName]"
                + "FROM [NORTHWND].[dbo].[Products]" 
                + "where ProductID=" 
                + selectedItem.ToString();

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //while (reader.Read())
            //{
                Presenter.productName = (reader.GetValue(0).ToString());
            //}

            reader.Close();
            conn.Close();
        }

    }
}
