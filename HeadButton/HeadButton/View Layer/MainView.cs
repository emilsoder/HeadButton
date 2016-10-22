using System;
using System.Windows.Forms;
using HeadButton.Presenter_Layer;
using HeadButton.Model_Layer;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace HeadButton.View_Layer
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            OnFormLoad();
        }

        private void OnFormLoad()
        {
            Presenter.OnStartUp();
            lstCategories.DataSource = Presenter.listCategories;
        }

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductsList();
        }

        private void GetProductsList()
        {
            lstProducts.Items.Clear();
            Presenter.listProducts.Clear();
            Presenter.categoryIndex = lstCategories.SelectedIndex;
            Presenter.GetProducts();

            try
            {
                foreach (var item in Presenter.listProducts)
                {
                    lstProducts.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.ProductRequest(lstProducts.SelectedItem.ToString());
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductProject.View_Layer.AddProductView addProductView = new AddProductProject.View_Layer.AddProductView();
            addProductView.ddlCategoryDataSource(Presenter.listCategories);
            addProductView.ShowDialog();
            ExternalForm_FormClosed();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            Presenter presenter = new Presenter();
            presenter.DeleteProduct();
        }

        private int selectedItem { get; set; }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            selectedItem = lstProducts.SelectedIndex;

            EditProductProject.View_Layer.EditProductView editProductView = new EditProductProject.View_Layer.EditProductView();
            editProductView.SetValues(Presenter.productName, Presenter.unitPrice, Presenter.productIndex.ToString());
            editProductView.ShowDialog();
            ExternalForm_FormClosed();
        }

        private void ExternalForm_FormClosed()
        {
            GetProductsList();
            if (selectedItem >= 0)
            {
                lstProducts.SelectedIndex = selectedItem;
            }
        }
    }
}

//var regexString = Regex.Replace(lstProducts.SelectedItem.ToString(), "[^0-9]", "");

            //Presenter.productIndex = Convert.ToInt32(regexString);
            //Presenter.ProductItemRequest();
        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    //int selectedItem = lstProducts.SelectedIndex;

        //    //try
        //    //{
        //    //    if ((txtNewUnitPrice.Text != "") && (txtNewProductName.Text != ""))
        //    //    {
        //    //        Presenter.newUnitPrice = txtNewUnitPrice.Text;
        //    //        Presenter.newProductName = txtNewProductName.Text;
        //    //        Model.Update(); //OK
        //    //        ClearTextBoxes(); // ??
        //    //        GetProductsList(); // OK
        //    //        lstProducts.SelectedIndex = selectedItem; //OK
        //    //    }
        //    //    else
        //    //    {
        //    //        MessageBox.Show("Fälten får inte vara tomma!");
        //    //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.Message, "Felmeddelande");
        //    //}
        //}