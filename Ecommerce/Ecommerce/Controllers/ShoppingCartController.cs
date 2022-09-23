using AspNetCoreHero.ToastNotification.Abstractions;
using Ecommerce.Entities;
using Ecommerce.Extension;
using Ecommerce.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Controllers
{
    public class ShoppingCartController : Controller
    {
        DataContext dataContext;
        private readonly ILogger<HomeController> _logger;
        public INotyfService notyfService { get; }
        public ShoppingCartController(DataContext _dataContext, INotyfService _notyfService)
        {
            dataContext = _dataContext;
            notyfService = _notyfService;
        }
        public  List<CartItem> GioHang
        {
            get
            {
                var gh = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (gh ==default(List<CartItem>))
                {
                    gh = new List<CartItem>();
                }
                return gh;
            }
        }
        [HttpPost]
        [Route("api/cart/add")]
        public IActionResult AddToCart(int productID, int? amount)
        {
            List<CartItem> giohang = GioHang;
            try
            {
                CartItem item = GioHang.FirstOrDefault(p => p.product.ProductID == productID);
                var item2 = item;
                // XEM TRONG giỏ hàng có sản phẩm không có thì trả vè sản phẩm không thì trả về default là null
                if (item!=null)//nếu mà có thì update cái số lượng
                {
                    //item.amount += amount.Value;

                    foreach (var itemlist in giohang)
                    {
                        if (itemlist.product.ProductID == productID)
                        {
                            itemlist.amount += amount.Value;
                        }
                    }
                    HttpContext.Session.Set<List<CartItem>>("GioHang", giohang);

                }
                else
                {
                    Product sanPham = dataContext.Products.SingleOrDefault(p => p.ProductID == productID);
                    item = new CartItem
                    {
                        amount = amount.HasValue ? amount.Value : 1,
                        product = sanPham
                    };
                    HttpContext.Session.SetString("GioHang1", item.amount.ToString());
                    giohang.Add(item);
                }
                HttpContext.Session.Set<List<CartItem>>("GioHang", giohang);
              
                var gh = HttpContext.Session.Get<List<CartItem>>("GioHang");
                return Json(new { success = true});
            }
            catch
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        [Route("api/cart/remove")]
        public IActionResult Remove(int productID)
        {

            try
            {
                List<CartItem> giohang = GioHang;
                CartItem item = giohang.SingleOrDefault(p => p.product.ProductID == productID);
                if (item != null)
                {
                    giohang.Remove(item);
                }

                HttpContext.Session.Set<List<CartItem>>("GioHang", giohang);
                return Json(new { success = true });
            }

            catch
            {
                return Json(new { success = false });
            }
        }
       

        [HttpPost]
        [Route("api/cart/update")]
        public IActionResult UpdateCart(int productID, int? amount)
        {
            //lấy giỏ hàng ra để xử lý
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");

            try
            {
                if (cart != null)
                {
                    CartItem item = cart.SingleOrDefault(p => p.product.ProductID == productID);
                    if (item != null && amount.HasValue) // đã có thì sẽ cập nhật số lượng
                    {
                        item.amount = amount.Value;
                    }
                    //lưu lại ss vào GioHang
                    HttpContext.Session.Set<List<CartItem>>("GioHang", cart);
                }
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }


        [Route("/Cart.html", Name = "Cart")]
        public IActionResult Index()
        {
            List<CartItem> giohang = GioHang;
            return View(giohang);
        }
    }
}
