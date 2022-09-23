         using AspNetCoreHero.ToastNotification.Abstractions;
using Ecommerce.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataContext _context;
        public INotyfService _notyfService { get; }
        public ProductController(DataContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        //[Route("shop.html", Name = "Shopproduct")]
        public IActionResult Index(int pageNum = 1)
        {
            try
            {        
                int pageSize = 10;
                int next_page = pageNum + 1;
                int previous_page = pageNum - 1;

                var Products = _context.Products.AsNoTracking().OrderBy(x => x.DateCreated);
                int totlpage = Products.Count() / 5;
                ViewBag.NextPage = next_page;
                ViewBag.previous_page = previous_page;
                ViewData["TotalPage"] = totlpage;
                return View(Products.Skip(pageSize *(pageNum-1)).Take(pageSize).ToList());
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
         
        }
        [Route("{Alias}.html", Name = "Listproduct")]
        public IActionResult List(string alias, int pageNum = 1)
        {
            try
            {
                int pageSize = 10;
                int next_page = pageNum + 1;
                int previous_page = pageNum - 1;
                var danhmuc = _context.Categories.AsNoTracking().SingleOrDefault(x => x.Alias == alias);
                var sanpham = _context.Products.AsNoTracking().Where(x => x.CateId == danhmuc.CateID).OrderByDescending(x => x.DateCreated);
                int totlpage = sanpham.Count() / 5;
                ViewBag.NextPage = next_page;
                ViewBag.previous_page = previous_page;
                ViewData["DanhMuc"] = danhmuc;
                ViewData["TotalPage"] = totlpage;
                return View(sanpham.Skip(pageSize * (pageNum - 1)).Take(pageSize).ToList());
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }

        }
        [Route("{Alias}/{id}.html",Name= "ProductDetails")]
        public IActionResult Details(int id)
        {
            try
            {
                var rs = _context.Products.Include(x => x.Category).FirstOrDefault(x => x.ProductID == id);
                if (rs == null)
                {
                    return RedirectToAction("index");
                }
                var lsproduct = _context.Products.AsNoTracking().Where(x => x.CateId == 1 && x.ProductID != id && x.Active == true).OrderBy(x => x.DateCreated).Take(4).ToList();
                ViewBag.SanPham = lsproduct;
                return View(rs);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }

        }
    }
}
