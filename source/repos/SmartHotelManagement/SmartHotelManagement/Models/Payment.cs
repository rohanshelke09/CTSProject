using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHotelManagement.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int BookingID { get; set; }

        public float Amount { get; set; }
        public string Status { get; set; } 
        public string PaymentMethod { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [ForeignKey("BookingID")]

        public Booking Booking { get; set; }
    }
}
