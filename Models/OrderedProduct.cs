using System.ComponentModel.DataAnnotations;

namespace BangazonBackend.Models
{
    public class OrderedProduct
    {
        [Required]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
    }
}
