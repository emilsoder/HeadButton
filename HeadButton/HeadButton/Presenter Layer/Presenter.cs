using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadButton.Presenter_Layer
{
    #region klassbeskrivning
    //Här lägger vi "Lim"-koden. Presentern ska fungera som en mellanhand från View Layer till Model Layer. 
    //Den ska föra över och hämta data til och från View Layer till Model Layer.
    #endregion

    public class Presenter
    {
        // Hämta indexen vid Click-Event
        public static int categoryIndex { get; set; }
        public static int productIndex { get; set; }

        // Nya och eller Ändrade värden
        public static string newProductName { get; set; }
        public static int newUnitPrice { get; set; }

        //Listor ska fyllas i Model. 
        //Dessa ska användas som ListBoxarnas datakällor i MainView.
        public static List<string> listCategories = new List<string>();
        public static List<string> listProducts = new List<string>();

        public static void CategoryRequest(int _categoryIndex)
        {
            categoryIndex = _categoryIndex;
            //TODO: anropa model

        }

        public static void ProductRequest(int _productIndex)
        {
            productIndex = _productIndex;
            //TODO: anropa model

        }
    }
}
