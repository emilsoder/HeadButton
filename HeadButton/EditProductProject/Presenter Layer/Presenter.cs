﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EditProductProject.Model_Layer;

namespace EditProductProject.Presenter_Layer
{
    public class Presenter
    {
        public void GetSetInputValues(string _unitPrice, string _productName, string _productIndex)
        {
            Model model = new Model();
            model.UpdateChanges(_unitPrice, _productName, _productIndex);
        }
    }
}
