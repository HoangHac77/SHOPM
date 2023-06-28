using SHOP.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace SHOP.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(256)]
        public string? Alas { get; set; }
        [Required]
        public int? CategoryID { get; set; }
        [MaxLength(256)]
        public string? Image { get; set; }
        [Column(TypeName = "xml")]
        public XElement? MoreImages { get; set; }
        public decimal? Price { get; set; }
        public decimal? Promotion { get; set; } // GIAM GIA
        public int? Warranty { get; set; } // BAO HANH
        [MaxLength(500)]
        public string? Description { get; set; }
        public string? Content { get; set; }

        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory? ProductCategory { set; get; }
    }
}
