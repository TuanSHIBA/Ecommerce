using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.ViewModel
{
    public class RegisterViewModel
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name = "Họ Và Tên")]
        [Required(ErrorMessage = "Vui Lòng Nhập Họ Và Tên")]
        public string FullName { get; set; }
        [Required(ErrorMessage = " Vui Lòng Nhập Email ")]
        [MaxLength(150)]
        [DataType(DataType.EmailAddress)]
        [Remote(action: "ValidateEmail", controller: "Account")]
        public string Email { get; set; }
        [Required(ErrorMessage = " Vui Lòng Nhập SDT ")]
        [MaxLength(150)]
        [DataType(DataType.PhoneNumber)]
        [Remote(action: "ValidatePhone", controller: "Account")]
        public string Phone { get; set; }


        [Display(Name = "Mật Khẩu")]
        [Required(ErrorMessage = "Vui Lòng Nhập Mật Khẩu ")]
        [MinLength(5, ErrorMessage = "Bạn cần đặt mật khẩu tối thiểu 5 ký tự")]
        public string Password { get; set; }
        [Display(Name = "Nhập Mật Khẩu")]
        [Required(ErrorMessage = "Vui Lòng Nhập Mật Khẩu ")]
        [MinLength(5, ErrorMessage = "Bạn cần đặt mật khẩu tối thiểu 5 ký tự")]
        public string ConfirmPassWord { get; set; }
    }
}
