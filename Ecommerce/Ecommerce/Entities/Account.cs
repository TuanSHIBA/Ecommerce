using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entities
{
    public class Account
    {
        [Key]
        public int AcccountID { get; set; }
        [StringLength(12)]
        [DisplayName("Số Điện Thoại")]
        public string Phone { get; set; }
        [MaxLength(50)]
        [DisplayName("Email")]
        public string Email { get; set; }
        [MaxLength(50)]
        [DisplayName("Mật Khẩu")]
        public string PassWord { get; set; }     
        public string salt { get; set; }        
        public bool Active { get; set; }
        [MaxLength(50)]
        [DisplayName("Họ Tên")]
        public string FullName { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual Role Role { get; set; }
    }
}
