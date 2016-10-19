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
            lstProducts.Items.Clear();
            Presenter.listProducts.Clear();
            Presenter.categoryIndex = lstCategories.SelectedIndex;
            //Model.GetProductsByIndex();
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

            Presenter.productIndex = lstProducts.SelectedIndex;
            //Model.SetTextBoxes();
            Presenter.ProductItemRequest();
            txtProductName.Text = Presenter.productName;
            txtUnitPrice.Text = Presenter.unitPrice.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUnitPrice.Text != "" && txtProductName.Text != "")
                {
                    Presenter.newUnitPrice = txtUnitPrice.Text;
                    Presenter.newProductName = txtProductName.Text;

                    ClearTextBoxes();
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
            txtUnitPrice.Text = "";
            txtProductName.Text = "";
        }

        private void OnFormLoad()
        {
            Presenter.OnStartUp();
            lstCategories.DataSource = Presenter.listCategories;
        }
    }
}
