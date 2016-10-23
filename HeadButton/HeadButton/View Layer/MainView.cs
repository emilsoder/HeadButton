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
            if (lstCategories.SelectedIndex != -1)
            {
                GetProductsList();
            }
        }

        private void GetProductsList()
        {
            lstProducts.Items.Clear();
            Presenter.listProducts.Clear();
            Presenter.GetProducts(lstCategories.SelectedIndex);

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
            if (lstProducts.SelectedIndex != -1)
            {
                Presenter.ProductRequest(lstProducts.SelectedItem.ToString());
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductProject.View_Layer.AddProductView addProductView = new AddProductProject.View_Layer.AddProductView();
            addProductView.ddlCategoryDataSource(Presenter.listCategories);
            addProductView.ShowDialog();
            AddProduct_FormClosed();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            //Presenter presenter = new Presenter();
            Presenter.DeleteProduct(lstProducts.SelectedItem.ToString());
            GetProductsList();
        }

        private int selectedItem { get; set; }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            selectedItem = lstProducts.SelectedIndex;

            EditProductProject.View_Layer.EditProductView editProductView = new EditProductProject.View_Layer.EditProductView();
            editProductView.SetValues(Presenter.productName, Presenter.unitPrice, Presenter.selectedProductName);
            editProductView.ShowDialog();
            editProductView.TopMost = true;
            AddProduct_FormClosed();
        }

        private void AddProduct_FormClosed()
        {
            GetProductsList();
            lstProducts.SelectedIndex = selectedItem;
        }
    }
}