using Ecommerce.Extension;
using Ecommerce.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers.Components
{
    public class HeaderCartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang"); //lấy giỏ hàng ra và đếm sản phẩm xong lưu vào ss có tên là GioHang
            return View(cart); //view hết giỏ hàng ra
        }
    }
}
