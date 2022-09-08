using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CiberWeb.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public CategoryModel Category { get; set; }
    }
}
