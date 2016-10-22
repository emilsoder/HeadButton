using AddProductProject.Model_Layer;
using System.Collections.Generic;

namespace AddProductProject.Presenter_Layer
{
    public class Presenter
    {
        public string DiscontinuedInt(string discontinued)
        {
            string formattedValue = null;

            if (discontinued == "False")
            {
                formattedValue = "0";
            }
            else if (discontinued == "True")
            {
                formattedValue = "1";
            }
            return formattedValue;
        }
        public string CategoryInt(string category)
        {
            string formattedValue = null;

            if (category == "cat1")
            {
                formattedValue = "1";
            }
            else if (category == "cat2")
            {
                formattedValue = "2";
            }
            else if (category == "cat3")
            {
                formattedValue = "3";
            }
            else if (category == "cat4")
            {
                formattedValue = "4";
            }
            else if (category == "cat5")
            {
                formattedValue = "5";
            }

            return formattedValue;
        }
        public string SupplierInt(string supplier)
        {
            string formattedValue = null;
            
            if (supplier == "sup1")
            {
                formattedValue = "1";
            }
            else if (supplier == "sup2")
            {
                formattedValue = "2";
            }
            else if (supplier == "sup3")
            {
                formattedValue = "3";
            }
            else if (supplier == "sup4")
            {
                formattedValue = "4";
            }
            else if (supplier == "sup5")
            {
                formattedValue = "5";
            }
            return formattedValue;
        }

        public static List<string> SupplierList = new List<string>();

        public static void GetSuppliers()
        {
            Model.GetSuppliers();
        }

        public void SetStringValues(string _productName, string _unitsInStock, string _unitsInOrder, string _quantityPerUnit, string _unitPrice, string _reorderLevel, string _selectedSupplier, string _selectedCategory, string _discontinued)
        {
            Model m = new Model();

            m.productName = _productName;
            m.unitsInStock = _unitsInStock;
            m.unitsOnOrder = _unitsInOrder;
            m.quantityPerUnit = _quantityPerUnit;
            m.unitPrice = _unitPrice;
            m.reorderLevel = _reorderLevel;

            m.supplier = _selectedSupplier;
            m.category = _selectedCategory;

            //m.categoryID = CategoryInt(_selectedCategory);
            m.discontinuedInt = DiscontinuedInt(_discontinued);
            //m.supplierID = SupplierInt(_selectedSupplier);

            m.AddRecord();
        }
    }
}
