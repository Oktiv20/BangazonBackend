using System.ComponentModel.DataAnnotations;

namespace BangazonBackend.Models
{
    public class Order
    {
        [Required]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public bool? Completed { get; set; }
        public string? PaymentType { get; set; }
        public decimal? TotalPrice { get; set; }

        // Relationships
        public ICollection<OrderedProduct> OrderedProducts { get; set; }
    }
}
