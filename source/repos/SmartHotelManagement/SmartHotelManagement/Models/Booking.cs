using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHotelManagement.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [Required]
        public int UserID { get; set; }

        public int RoomID { get; set; }

        public DateOnly CheckInDate { get; set; }

        public DateOnly CheckOutDate { get; set; }
        public string Status { get; set; } 

        public int? PaymentID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [ForeignKey("RoomID")]
        public Room Room { get; set; }

        [ForeignKey("PaymentID")]

        public Payment Payment { get; set; }

        public ICollection<Redemption> Redemptions { get; set; }
    }
}
