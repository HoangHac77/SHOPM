using System.ComponentModel.DataAnnotations;

namespace SHOP.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime CreatedDate { get; set; }
        [MaxLength(256)]
        public string? CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        [MaxLength(256)]
        public string? UpdatedBy { get; set; }
        public string? MetaKeyWord { get; set; }
        public string? MetaDescription { get; set; }
        public bool? Status { get; set; }
    }
}
