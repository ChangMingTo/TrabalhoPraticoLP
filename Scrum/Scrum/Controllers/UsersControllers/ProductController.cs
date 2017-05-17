using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Scrum.Models;

namespace Scrum.Controllers
{
    public class ProductController
    {
        private List<Product> productList;

        public ProductController()
        {
            productList = new List<Product>();
        }
        public bool AddProduct(Product add)
        {
            if (productList.Contains(add)==true)
            {
                return false;
            }
            else
            {
                productList.Add(add);
                return true;
            }
        }
    }
}