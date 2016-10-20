using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeadButton.Presenter_Layer;
using HeadButton.Model_Layer;
using System.Diagnostics;
using System.Text.RegularExpressions;
using AddProductProject;

namespace HeadButton.View_Layer
{
    public partial class MainView : Form
    {

        public MainView()
        {
            InitializeComponent();
            OnFormLoad();
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
            txtUnitPrice.Clear();
            txtProductName.Clear();

            var regexString = Regex.Replace(lstProducts.SelectedItem.ToString(), "[^0-9]", "");

            Presenter.productIndex = Convert.ToInt32(regexString);
            Presenter.ProductItemRequest();

            txtProductName.Text = Presenter.productName;
            txtUnitPrice.Text = Presenter.unitPrice.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           int selectedItem = lstProducts.SelectedIndex;

            try
            {
                if ((txtNewUnitPrice.Text != "") && (txtNewProductName.Text != ""))
                {
                    Presenter.newUnitPrice = txtNewUnitPrice.Text;
                    Presenter.newProductName = txtNewProductName.Text;

                    Model.Update();
                    ClearTextBoxes();
                    GetProductsList();
                    lstProducts.SelectedIndex = selectedItem;

                }
                else
                {
                    MessageBox.Show("Fälten får inte vara tomma!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Felmeddelande");
            }
        }

        public void ClearTextBoxes()
        {
            txtUnitPrice.Text = null;
            txtProductName.Text = null;
            txtNewProductName.Text = null;
            txtNewUnitPrice.Text = null;
        }

        private void OnFormLoad()
        {
            Presenter.OnStartUp();
            lstCategories.DataSource = Presenter.listCategories;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductProject.View_Layer.AddProductView addProductView = new AddProductProject.View_Layer.AddProductView();
            addProductView.ShowDialog();
        }
    }
}
