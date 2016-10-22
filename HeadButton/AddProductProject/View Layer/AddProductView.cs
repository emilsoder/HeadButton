using AddProductProject.Presenter_Layer;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AddProductProject.View_Layer
{
    public partial class AddProductView : Form
    {
        public AddProductView()
        {
            InitializeComponent();
        }
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            Presenter presenter = new Presenter();
            try
            {
                presenter.SetStringValues(txtProductName.Text, txtUnitsInStock.Text, txtUnitsInOrder.Text, txtQuantityPerUnit.Text, txtUnitPrice.Text, txtRecorderLevel.Text, ddlSupplier.Text.ToString(), ddlCategory.Text.ToString(), ddlDiscontinued.Text.ToString());
            }
            #region EXCEPTION INFO FOR DEBUG **** REMOVE WHEN TESTING DONE ****
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            } 
            #endregion
        }
        private void btnClearText_Click(object sender, EventArgs e)
        {
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
