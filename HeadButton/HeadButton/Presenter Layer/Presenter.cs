using HeadButton.Model_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadButton.Presenter_Layer
{
    #region Klassbeskrivning
    //Här lägger vi "Lim"-koden. Presentern ska fungera som en mellanhand från View Layer till Model Layer. 
    //Den ska föra över och hämta data til och från View Layer till Model Layer.
    #endregion

    public class Presenter
    {
        // Hämta indexen vid Click-event
        public static int categoryIndex { get; set; }
        public static int productIndex { get; set; }

        // Hämtade värden
        public static string productName { get; set; }
        public static string unitPrice { get; set; }

        //Listor ska fyllas i Model.  // Dessa ska användas som ListBoxarnas datakällor i MainView.
        public static List<string> listCategories = new List<string>();
        public static List<string> listProducts = new List<string>();

        public static void OnStartUp()
        {
            Model.GetCategories();
        }

        public static void GetProducts()
        {
            Model.GetProductsByIndex();
        }

        public static void ProductRequest(string _selectedItem)
        {
            var regexString = Regex.Replace(_selectedItem, "[^0-9]", "");
            productIndex = Convert.ToInt32(regexString);
            Model.SetTextBoxes();
        }

        public void DeleteProduct()
        {
            if ((MessageBox.Show("Are you sure you want to delete selected product?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.OK))
            {
                Model.DeleteRecord(productIndex.ToString());
            }
        }
    }
}
