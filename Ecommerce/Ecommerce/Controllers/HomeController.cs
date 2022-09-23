using Ecommerce.Entities;
using Ecommerce.Models;
using Ecommerce.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        DataContext dataContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DataContext _dataContext)
        {
            dataContext = _dataContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomeVM model = new HomeVM();
            var lsProducts = dataContext.Products.
                             AsNoTracking()
                             .Where(Products => Products.Active == true && Products.HomeFlag == true).
                             OrderByDescending(Products => Products.DateCreated).ToList();

            List<ProductHomeVM> productHomeVMs = new List<ProductHomeVM>();
            var lsCats = dataContext.Categories.AsNoTracking()
                .Where(categories => categories.Published == true && categories.Parent == 0)
                .OrderByDescending(categories => categories.Ordering)
                .ToList();

            foreach( var item in lsCats)
            {
                ProductHomeVM productHome = new ProductHomeVM();
                productHome.category = item;
                productHome.lsProducts = lsProducts.Where(x => x.CateId == item.CateID).ToList();
                productHomeVMs.Add(productHome);
            }
            model.Products = productHomeVMs;
            ViewBag.AllProducts = lsProducts;
            return View(model);
        }

        public IActionResult Contact()
        {
            return View();
        }       
        public IActionResult About()
        {
            return View();
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
