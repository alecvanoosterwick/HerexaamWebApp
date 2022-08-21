using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Controllers
{
    public class KlantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
