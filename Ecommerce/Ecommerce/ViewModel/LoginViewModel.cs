using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.ViewModel
{
    public class LoginViewModel
    {
        [Key]
        [MaxLength(100)]
        [Required(ErrorMessage="Vui lòng nhập  Email ")]
        [Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }

   
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu ")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
