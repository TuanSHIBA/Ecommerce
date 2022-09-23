using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.ViewModel
{
    public class ChangePasswordViewModel
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name ="Mật Khẩu Hiện Tại")]
        public string PasswordNow { get; set; }
        [Display(Name ="Mật Khẩu Mới")]
        [Required(ErrorMessage ="Vui Lòng Nhập Mật Khẩu")]
        [MinLength(5,ErrorMessage =" Bạn Cần Đặt Mật Khẩu Tối Thiểu 5 Ký Tự")]
        public string Password { get; set; }
        [MinLength(5, ErrorMessage = " Bạn Cần Đặt Mật Khẩu Tối Thiểu 5 Ký Tự")]
        [Display(Name = "Nhập Lại Mật Khẩu Mới")]
        public string ConfirmPassword { get; set; }
    }
}
