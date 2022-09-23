using AspNetCoreHero.ToastNotification.Abstractions;
using Ecommerce.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SearchController : Controller
    {
        private readonly DataContext _context;
        public INotyfService _notyfService { get; }
        public SearchController(DataContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult FindProduct(string keyword)
        {
            //  List<Product> ls = new List<Product>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {

                return PartialView("ListproductsSearchPartial", null);
            }
            var ls = _context.Products.AsNoTracking().
                         Include(a => a.Category).
                         Where(x => x.ProductName.Contains(keyword)).
                         OrderByDescending(x => x.ProductName).Take(10).ToList();
            var ls1 = _context.Products.Where(x => x.CateId == 1);
            var ls2 = from c in _context.Products
                      join st in _context.Categories on c.CateId equals st.CateID
                      select new
                      {
                          productid = c.ProductID,
                          name = c.ProductName
                      };
           
            if (ls == null)
            {
                return PartialView("ListproductsSearchPartial", null);
            }
            else
            {
               return PartialView("ListproductsSearchPartial", ls);
               //return new JsonResult(new { status = "Success" , model = ls2 }); 
            }

        }
    }
}
