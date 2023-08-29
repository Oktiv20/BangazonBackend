using System.ComponentModel.DataAnnotations;

namespace BangazonBackend.Models
{
    public class OrderedProduct
    {
        [Required]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
