using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MVC_Assignment1.Data;
using MVC_Assignment1.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MVC_Assignment1Context _context;
        public List<ProductTShirtViewModel> ProductList { get; set; } = new List<ProductTShirtViewModel>();

        public HomeController(ILogger<HomeController> logger, MVC_Assignment1Context context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index(int? id=1)
        {
            var productList = await _context.ProductTShirtViewModel.ToListAsync();
            var onePageProduct = productList.FindAll(p => (p.ID >= id * 9 - 8) && (p.ID <= id * 9));

            ViewBag.PageId = id;
            ViewBag.TotalPages = (productList.Count()+8)/9;
            return View(onePageProduct);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
