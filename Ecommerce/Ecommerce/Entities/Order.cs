using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Entities
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
       // public int TransactStatusID { get; set; }
        public bool Deleted { get; set; }
        public bool Paid { get; set; }
        public DateTime PaidPaymentDate { get; set; }
        public double TotalMoney { get; set; }
        public double PaymentID { get; set; }
        public string Note { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public  virtual TransactSatatus  TransactSatatus { get; set; }
        public virtual ICollection<OrderDetail>  OrderDetails { get; set; }
    }
}
