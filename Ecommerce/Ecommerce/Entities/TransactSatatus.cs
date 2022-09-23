using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Entities
{
    public class TransactSatatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactSatatusID { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public ICollection<Order>  Orders { get; set; }
    }
}
