using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ShopDbContext _context;

        public ProductController(ShopDbContext context)
        {
            _context = context;
        }
        //get products
        public async Task<IActionResult> Index()
        {
            List<Product> producten;

            producten = _context.Producten.ToList();

            return View(producten);
        }

        public IActionResult Create()
        {
            Product product = new Product();

            return View(product);
        }

        public IActionResult Create(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

            public IActionResult Crud()
        {
            return View();
        }
    }
}
