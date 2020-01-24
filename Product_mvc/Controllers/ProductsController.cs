using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Product_mvc.Models;

namespace Product_mvc.Controllers
{
    public class ProductsController : Controller
    {
        readonly List<Product> products = new List<Product>()
        {
            new Product {Id=1, Name="Sko 1", Price=599.99, Photo="sko1.jpg"},
            new Product {Id=2, Name="Sko 2", Price=499.99, Photo="sko2.jpg"},
            new Product {Id=3, Name="Sko 3", Price=578.99, Photo="sko3.jpg"}
        };

        public PartialViewResult ProtoType()
        {
            return PartialView();
        }
        public IActionResult Index()
        {
            return View(products);
        }
    }
}