using System;
using System.Diagnostics;
using AddProductProject.Model_Layer;

namespace AddProductProject.Presenter_Layer
{
    public class Presenter
    {
        public string productName { get; set; }
        public string unitsInStock { get; set; }
        public string unitsInOrder { get; set; }
        public string quantityPerUnit { get; set; }
        public string unitPrice { get; set; }
        public string reorderLevel { get; set; }

        public string selectedSupplier { get; set; }
        public string selectedCategory { get; set; }
        public string discontinued { get; set; }

        public string supplierID { get; set; }
        public string categoryID { get; set; }
        public string isDiscontinued { get; set; }

        public void FormatInputToIntegers()
        {
            ConvertDiscontinuedToInt();
            ConvertCategoryToInt();
            ConvertSupplierToInt();
        }
        public void ConvertDiscontinuedToInt()
        {
            string selected = discontinued.ToLower();
            string formattedValue = "";

            #region TRY
            try
            {
                #endregion
                if (selected == "false")
                {
                    formattedValue = "0";
                }
                else if (selected == "true")
                {
                    formattedValue = "1";
                }

                isDiscontinued = formattedValue;

                #region Catch Exception Handler
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            #endregion
        }

        // TODO: 
        // Ändra "cat-X " till kategoriens namn
        public void ConvertCategoryToInt()
        {
            string selected = selectedCategory;
            string formattedValue = "";

            #region TRY
            try
            {
                #endregion

                if (selected == "cat1")
                {
                    formattedValue = "1";
                }
                else if (selected == "cat2")
                {
                    formattedValue = "2";
                }
                else if (selected == "cat3")
                {
                    formattedValue = "3";
                }
                else if (selected == "cat4")
                {
                    formattedValue = "4";
                }
                else if (selected == "cat5")
                {
                    formattedValue = "5";
                }

                categoryID = formattedValue;

                #region Catch Exception Handler            
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            #endregion
        }

        // TODO: 
        // Ändra "sup-x " till tillverkarnas namn
        public void ConvertSupplierToInt()
        {
            string selected = selectedSupplier;
            string formattedValue = "";

            #region TRY
            try
            {
                #endregion
                if (selected == "sup1")
                {
                    formattedValue = "1";
                }
                else if (selected == "sup2")
                {
                    formattedValue = "2";
                }
                else if (selected == "sup3")
                {
                    formattedValue = "3";
                }
                else if (selected == "sup4")
                {
                    formattedValue = "4";
                }
                else if (selected == "sup5")
                {
                    formattedValue = "5";
                }

                supplierID = formattedValue;

                #region Catch Exception Handler
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            #endregion
        }

        public void SetStringValues(string _productName, string _unitsInStock, string _unitsInOrder, string _quantityPerUnit, string _unitPrice, string _reorderLevel, string _selectedSupplier, string _selectedCategory, string _discontinued)
        {
            selectedCategory = _selectedCategory;
            selectedSupplier = _selectedSupplier;
            discontinued = _discontinued;

            FormatInputToIntegers();

            productName = _productName;
            unitsInStock = _unitsInStock;
            unitsInOrder = _unitsInOrder;
            quantityPerUnit = _quantityPerUnit;
            unitPrice = _unitPrice;
            reorderLevel = _reorderLevel;

            Model model = new Model();
            model.AddRecord();
        }

        public bool sqlTransactionSuccessful { get; set; }
    }
}
