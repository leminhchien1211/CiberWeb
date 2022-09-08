using CiberWeb.Helper;
using CiberWeb.Models;
using Data.Context;
using Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CiberWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private LocalDbContext _LocalDb { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _LocalDb = new LocalDbContext(Data.ConnectionStrings.LocalDbConnectionString);
        }

        public IActionResult Index(OrderModel model)
        {
            int pageNumber = model.page > 0 ? model.page : 1;
            int size = model.pageSize > 0 ? model.pageSize : 5;
            try
            {
                var listOrder = _LocalDb.Orders
                    .Include(x => x.Customer)
                    .Include(z => z.Product.Category)
                    .ToList();
                if (!string.IsNullOrEmpty(model.Product?.Category?.Name))
                {
                    listOrder = listOrder.Where(x => x.Product.Category.Name.ToLower().Contains(model.Product.Category.Name.ToLower())).ToList();
                }
                model.PageList = listOrder?.ToPagedList(pageNumber, size);
            }
            catch (Exception ex)
            {
                WriteLog.LogToText("Home/Index Error:" + ex);
                return Error();
            }
            return View(model);
        }

        public IActionResult OpenModal()
        {
            return PartialView("pAddOrder");
        }

        public IActionResult Create(OrderModel model)
        {
            var Order = new Order
            {
                Name = model.Name,
                OrderDate = DateTime.Now
            };
            //_LocalDb.Orders.Add(Order);
            //_LocalDb.SaveChanges();
            return Ok();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
