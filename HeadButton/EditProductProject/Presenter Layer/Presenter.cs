using EditProductProject.Model_Layer;

namespace EditProductProject.Presenter_Layer
{
    public class Presenter
    {
        public void GetSetInputValues(string _unitPrice, string _productName, string _productIndex, string _oldName)
        {
            Model model = new Model();
            model.UpdateChanges(_unitPrice, _productName, _productIndex, _oldName);
        }
    }
}
