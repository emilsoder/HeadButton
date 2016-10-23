using System;
using System.Windows.Forms;
using EditProductProject.Presenter_Layer;

namespace EditProductProject.View_Layer
{
    public partial class EditProductView : Form
    {
        public string productIndex { get; set; }

        public EditProductView()
        {
            InitializeComponent();
        }

        public static string oldName { get; set; }

        public void SetValues(string _productName, string _unitPrice, string _productIndex)
        {
            lblProductName.Text = _productName;
            lblUnitPrice.Text = _unitPrice;

            productIndex = _productIndex;
            oldName = _productName;
        }

        private void CommitChanges()
        {
            try
            {
                string productName = null;
                string unitPrice = null;

                #region CHECK FOR CHANGES 
                if (txtNewProductName.Text == "")
                {
                    productName = lblProductName.Text;
                }
                else
                {
                    productName = txtNewProductName.Text;
                }

                if (txtNewUnitPrice.Text == "")
                {
                    unitPrice = lblUnitPrice.Text;
                }
                else
                {
                    unitPrice = txtNewUnitPrice.Text;
                }
                #endregion

                Presenter presenter = new Presenter();
                presenter.GetSetInputValues(unitPrice, productName, productIndex, oldName);

                string info = "Old name: " + lblProductName.Text + "\n" + " New name: " + productName + "\n\n" + "Old price: " + lblUnitPrice.Text + "\n" + "New price: " + unitPrice;
                if ((MessageBox.Show(info, "Success!", MessageBoxButtons.OK) == DialogResult.OK))
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Felmeddelande");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CommitChanges();
        }
    }
}
