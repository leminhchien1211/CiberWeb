using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CiberWeb.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime OrderDate { get; set; }
        public ProductModel Product { get; set; }
        public CustomerModel Customer { get; set; }
        public IPagedList<Order> PageList { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
