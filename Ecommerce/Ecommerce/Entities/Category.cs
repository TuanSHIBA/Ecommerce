using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Entities
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CateID { get; set; }
        [MaxLength(50)]
        [Required]
        [DisplayName("Danh Mục")]
        public string CateName { get; set; }
        [DisplayName("Mô Tả")]
        public string Description { get; set; }

        public int? Parent { get; set; }
        [Required]
        public int Levels { get; set; }
        [DisplayName("Sắp Xếp")]
        public int Ordering { get; set; }
        public bool Published { get; set; }
        public string Thumb { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string MetaDesc { get; set; }
        public string MetaKey { get; set; }
        public string Cover { get; set; }
        
        public ICollection<Product> Products { get; set; }
    }
}
