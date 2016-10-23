using AddProductProject.Presenter_Layer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace AddProductProject.View_Layer
{
    public partial class AddProductView : Form
    {
        public AddProductView()
        {
            InitializeComponent();
            ddlSupplierDataSource();
        }

        public void ddlCategoryDataSource(List<string> categoryList)
        {
            ddlCategory.DataSource = categoryList;
        }

        private void ddlSupplierDataSource()
        {
            Presenter.GetSuppliers();
            ddlSupplier.DataSource = Presenter.SupplierList;
        }
        
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            Presenter presenter = new Presenter();
            try
            {
                presenter.SetStringValues(txtProductName.Text, txtUnitsInStock.Text, txtUnitsInOrder.Text, txtQuantityPerUnit.Text, txtUnitPrice.Text, txtRecorderLevel.Text, ddlSupplier.SelectedItem.ToString(), ddlCategory.SelectedItem.ToString(), ddlDiscontinued.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
            ResetTextBoxes();
        }
        private void ResetTextBoxes()
        {
            txtProductName.Text = "";
            txtUnitsInStock.Text = "";
            txtUnitsInOrder.Text = "";
            txtQuantityPerUnit.Text = "";
            txtUnitPrice.Text = "";
            txtRecorderLevel.Text = "";
        }
    }
}

             //ddlSupplier.SelectedItem.ToString(), ddlCategory.SelectedItem.ToString(), ddlDiscontinued.SelectedItem.ToString()
