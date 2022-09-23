using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Entities
{
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetailID { get; set; }
        public int OrderNumber { get; set; }
        public int Amount { get; set; }
        public int Discount { get; set; }
        public int TotalMoney { get; set; }
        public DateTime CreateDate { get; set; }
        public int Price { get; set; }
        public Order Order { get; set; }
    }
}
