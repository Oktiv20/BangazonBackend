using System.ComponentModel.DataAnnotations;

namespace BangazonBackend.Models
{
    public class ProductType
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Type { get; set; }
    }
}
