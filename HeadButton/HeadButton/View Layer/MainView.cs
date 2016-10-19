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

namespace HeadButton.View_Layer
{
    public partial class MainView : Form
    {
        public MainView()
        { 
            InitializeComponent();
        }
        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.CategoryRequest(lstCategories.SelectedIndex);
            lstCategories.DataSource = Presenter.listCategories;
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.ProductRequest(lstProducts.SelectedIndex);
            lstProducts.DataSource = Presenter.listProducts;

            txtNewProductName.Text = Presenter.newProductName;
            txtUnitPrice.Text = Presenter.newUnitPrice.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUnitPrice.Text != "" && txtNewProductName.Text != "")
                {
                    Presenter.newUnitPrice = int.Parse(txtUnitPrice.Text);
                    Presenter.newProductName = txtNewProductName.Text;
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
            txtNewProductName.Text = "";
        }
    }
}
