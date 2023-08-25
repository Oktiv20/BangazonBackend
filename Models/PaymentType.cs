using System.ComponentModel.DataAnnotations;

namespace BangazonBackend.Models
{
    public class PaymentType
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Type { get; set; }
    }
}
