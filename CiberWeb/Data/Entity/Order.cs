using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime OrderDate { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}
