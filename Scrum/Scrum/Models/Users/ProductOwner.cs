using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum.Models
{
    public class ProductOwner
    {
        public ProductOwner(string a)
        {
            Nome = a;
        }
        public string Nome { get; set; }
        public List<Product> Products { get; set; }
    }
}