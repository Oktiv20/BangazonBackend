using System.ComponentModel.DataAnnotations;

namespace BangazonBackend.Models
{
    public class UserPaymentType
    {
        [Required]
        public int Id { get; set; }

        public int UserId { get; set; }

        public int PaymentId { get; set; }
    }
}
