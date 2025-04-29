using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHotelManagement.Models
{
    public class Redemption
    {
        [Key]
        public int RedemptionID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]

        public int BookingID { get; set; }

        public int PointsUsed { get; set; }
        public float DiscountAmount { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [ForeignKey("BookingID")]
        public Booking Booking { get; set; }
    }
}
