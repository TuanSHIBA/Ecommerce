using AspNetCoreHero.ToastNotification.Abstractions;
using Ecommerce.Entities;
using Ecommerce.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminProductsController : Controller
    {
        private readonly DataContext _context;
        public INotyfService _notyfService { get; }
        public AdminProductsController(DataContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/AdminProducts
     
        public async Task<IActionResult> Index(int pageNum = 1, int CateId = 0)       
        {         
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CateID", "CateName", CateId);// ( value, display, giữ giá trị value)
            int pageSize = 5;
            int next_page = pageNum + 1;
            int previous_page = pageNum - 1;
            if (previous_page < 1)
            {
                previous_page = 1;
            }
            //List<Product> ProductContext = new List<Product>();
            var ProductContext = _context.Products.Include(p => p.Category).Where(x => x.ProductID > 0);
            if (CateId != 0)
            {
                ProductContext = _context.Products.Include(p => p.Category).Where(x => x.CateId == CateId);
            }
            
                 //ProductContext = _context.Products.Include(p => p.Category);
            
            int totlpage = ProductContext.Count() / 5;
            ViewBag.NextPage = next_page;
            ViewBag.previous_page = previous_page;
            ViewBag.cateid = CateId;
            ViewData["TotalPage"] = totlpage;
            return View( await ProductContext.Skip(pageSize * (pageNum - 1)).Take(pageSize).ToListAsync());
        }


        // GET: Admin/AdminProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/AdminProducts/Create
        public IActionResult Create()
        {
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CateID", "CateName");
            return View();
        }

        // POST: Admin/AdminProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductID,ProductName,ShortDescription,Description,Price,Discount,Thumb,Video,DateCreated,DateModified,BestSellers,HomeFlag,Active,Tags,Title,Alias,MetaDesc,MetaKey,UnitsInStock,CateId")] Product product, IFormFile fthumb)
        {
            if (ModelState.IsValid)
            {
                product.ProductName = Utilities.ToTitleCase(product.ProductName);
                if (fthumb != null)
                {
                    string extension = Path.GetExtension(fthumb.FileName);
                    string image = Utilities.SEOUrl(product.ProductName) + extension;
                    product.Thumb = await Utilities.UploadFile(fthumb, @"products", image.ToLower());
                }
                if (string.IsNullOrEmpty(product.Thumb))
                {
                    product.Thumb = "default.jpg";
                }
                product.Alias = Utilities.SEOUrl(product.ProductName);
                product.DateModified = System.DateTime.Now;
                product.DateCreated = System.DateTime.Now;
                _context.Add(product);
                await _context.SaveChangesAsync();
                _notyfService.Success("Thêm mới thành công");
                return RedirectToAction(nameof(Index));
            }
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CateID", "CateName", product.ProductID);
            return View(product);
        }

        // GET: Admin/AdminProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CateID", "CateName", product.ProductID);
            return View(product);
        }

        // POST: Admin/AdminProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductID,ProductName,ShortDescription,Description,Price,Discount,Thumb,Video,DateCreated,DateModified,BestSellers,HomeFlag,Active,Tags,Title,Alias,MetaDesc,MetaKey,UnitsInStock,CateId")] Product product, IFormFile fthumb)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    product.ProductName = Utilities.ToTitleCase(product.ProductName);
                    if (fthumb != null)
                    {
                        string extension = Path.GetExtension(fthumb.FileName);
                        string image = Utilities.SEOUrl(product.ProductName) + extension;
                        product.Thumb = await Utilities.UploadFile(fthumb, @"products", image.ToLower());
                    }
                    if (string.IsNullOrEmpty(product.Thumb))
                    {
                        product.Thumb = "default.jpg";
                    }
                    product.Alias = Utilities.SEOUrl(product.ProductName);
                    product.DateModified = System.DateTime.Now;
                    product.DateCreated = System.DateTime.Now;
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Cập Nhật Thành Công");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CateID", "CateName", product.ProductID);
            return View(product);
        }

        // GET: Admin/AdminProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/AdminProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            _notyfService.Success("Xóa Thành Công ");
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductID == id);
        }

        public IActionResult Filter(int CateId)
        {
            var list = _context.Products;
            var url = $"/admin/adminproducts?cateid={CateId}";
            if (CateId == 0)
            {
                url = $"/admin/adminproducts";
            }
            return Json(new { status = "Success", redirectUrl = url, list = list });
        }
   
        
    }
}
