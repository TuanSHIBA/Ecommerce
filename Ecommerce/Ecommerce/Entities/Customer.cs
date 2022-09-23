using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Entities
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }
        [Required]
        public string FullName { get; set; }
        public DateTime? Birthday { get; set; }
        [DisplayName("Số Điện Thoại")]
        public string Avatar { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(12)]
        [DisplayName("Số Điện Thoại")]
        public string Phone { get; set; }

        [DisplayName("Địa Chỉ")]
        public string Address { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Required]
        public string PassWord { get; set; }
        public string Salt { get; set; }
        public DateTime LastLogin { get; set; } = DateTime.Now;
        public bool Active { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
