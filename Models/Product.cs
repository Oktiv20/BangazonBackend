using System.ComponentModel.DataAnnotations;

namespace BangazonBackend.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        public int SellerId { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public string? ProductType { get; set; }
        [Required]
        public bool? InStock { get; set; }
        [Required]
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; }
        public ICollection<OrderedProduct> OrderedProducts { get; set; }
    }
}
