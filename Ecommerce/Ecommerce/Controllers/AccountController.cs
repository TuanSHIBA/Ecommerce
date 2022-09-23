using AspNetCoreHero.ToastNotification.Abstractions;
using Ecommerce.Entities;
using Ecommerce.Extension;
using Ecommerce.Helper;
using Ecommerce.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class AccountController : Controller
    {
        DataContext dataContext;
        private readonly ILogger<HomeController> _logger;
        public INotyfService notyfService { get; }
        public AccountController(DataContext _dataContext, INotyfService _notyfService)
        {
            dataContext = _dataContext;
            notyfService = _notyfService;
        }
        public IActionResult ValidatePhone(string Phone)
        {
            try
            {
                var khachhang = dataContext.Customers.AsNoTracking().SingleOrDefault(x => x.Phone.ToLower() == Phone.ToLower());
                if (khachhang != null)
                {
                    return Json(data: "Số Điện Thoại : " + Phone + "Đã được sử dụng ");
                }
                return Json(data: true);
            }
            catch
            {
                return Json(data: true);
            }
        }
        public IActionResult ValidateEmail(string Email)
        {
            try
            {
                var khachhang = dataContext.Customers.AsNoTracking().SingleOrDefault(x => x.Email.ToLower() == Email.ToLower());
                if (khachhang != null)
                {
                    return Json(data: "Số Điện Thoại : " + Email + "Đã được sử dụng ");
                }
                return Json(data: true);
            }
            catch
            {
                return Json(data: true);
            }
        }
        [Authorize]
        [Route("Tai-khoan-cua-toi.html", Name = "Dashboard")]
        public IActionResult Dashboard()
        {
            var taikhoanId = HttpContext.Session.GetString("CustomerId");
            if (taikhoanId != null)
            {
                var khachhang = dataContext.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerID == Convert.ToInt32(taikhoanId));
                if (khachhang != null)
                {
                    var lsDonHang = dataContext.Orders.Include(x => x.TransactSatatus).AsNoTracking().Where(x => x.Customer.CustomerID == khachhang.CustomerID).OrderByDescending(x => x.OrderDate).ToList();
                    ViewBag.DonHang = lsDonHang;
                    return View(khachhang);
                }
            }

            return RedirectToAction("Login");
        }
        [Route("Dang-ky.html", Name = "DangKy")]
        public IActionResult DangKyTaiKhoan()
        {
            return View();
        }
        [HttpPost]
        [Route("Dang-ky.html", Name = "DangKy")]
        public async Task<IActionResult> DangKyTaiKhoan(RegisterViewModel register)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    string randomkey = Utilities.GetRandomKey();
                    Customer customer = new Customer
                    {
                        FullName = register.FullName,
                        Phone = register.Phone.Trim().ToLower(),
                        Email = register.Email.Trim().ToLower(),
                        PassWord = (register.Password + randomkey.Trim()).ToMD5(),
                        Active = true,
                        Salt = randomkey.Trim(),
                        //CreateDate = DateTime.Now
                    };
                    try
                    {
                        dataContext.Add(customer);
                        await dataContext.SaveChangesAsync();
                        HttpContext.Session.SetString("CustomerId", customer.CustomerID.ToString());
                        var taikhoanID = HttpContext.Session.GetString("CustomerID");
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, customer.FullName),
                            new Claim("CustomerID",customer.CustomerID.ToString()),

                        };
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Login");
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                        return RedirectToAction("Dashboard", "Account");
                    }
                    catch
                    {
                        return RedirectToAction("Register", "Account");
                    }
                }

            }
            catch
            {

            }
            return View();
        }

        [Route("dang-nhap.html", Name = "DangNhap")]
        public IActionResult Login(string returnUrl = null)
        {
            var taikhoanId = HttpContext.Session.GetString("CustomerId");
            if (taikhoanId != null)
            {
                return RedirectToAction("Dashboard", "Account");
            }
            return View();
        }
        [HttpPost]
        [Route("dang-nhap.html", Name = "DangNhap")]
        public async Task<IActionResult> Login(LoginViewModel login, string returnUrl = null)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isEmail = Utilities.IsValidEmail(login.UserName);
                    if (!isEmail) 
                        return View(login);
                    var khachhang = dataContext.Customers.
                                    AsNoTracking().SingleOrDefault(x => x.Email.Trim() == login.UserName);
                    if (khachhang == null)
                        return RedirectToAction("Register");
                    string pass = (login.Password + khachhang.Salt.Trim()).ToMD5();
                    if (khachhang.PassWord != pass)
                    {
                        notyfService.Error("Thông tin đăng nhập chưa chính xác");
                        return View(login);
                    }
                    if (khachhang.Active == false)
                    {
                        return RedirectToAction("ThongBao", "Account");
                    }
                    HttpContext.Session.SetString("CustomerId", khachhang.CustomerID.ToString());
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, khachhang.FullName),
                        new Claim("CustomerId",khachhang.CustomerID.ToString()),
                        new Claim(ClaimTypes.Role,"Admin")
                    };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    notyfService.Success("Đăng nhập thành công");
                    if (string.IsNullOrEmpty(returnUrl))
                    {
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                    else
                    {
                        return Redirect(returnUrl);
                    }
                }
            }
            catch
            {
                return View();
            }
            return View(login);
        }
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel model)
        {
            try
            {
                var taikhoanID = HttpContext.Session.GetString("CustomerId");
                if (taikhoanID == null)
                {
                    return RedirectToAction("Login", "Account");
                }
                var taikhoan = dataContext.Customers.Find(Convert.ToInt32(taikhoanID));
                if (taikhoan == null)
                {
                    return RedirectToAction("index", "home");
                }
                var pass = (model.PasswordNow.Trim() + taikhoan.Salt.Trim()).ToMD5();
                if (pass == taikhoan.PassWord)
                {
                    string passnew = (model.Password.Trim() + taikhoan.Salt.Trim()).ToMD5();
                    taikhoan.PassWord = passnew;
                    dataContext.Customers.Update(taikhoan);
                    dataContext.SaveChanges();
                    notyfService.Success("Đổi Mật Khẩu Thành Công");
                    return Json(new { status = "Success" });
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return RedirectToAction("Dashboard", "Account");
            }       
        }
    }

}
