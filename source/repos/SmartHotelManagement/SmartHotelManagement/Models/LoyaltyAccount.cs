using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHotelManagement.Models
{
    public class LoyaltyAccount
    {
        [Key]
        public int LoyaltyID { get; set; }

        [Required]
        public int UserID { get; set; }

        public int PointsBalance { get; set; }

        public DateTime LastUpdated { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }
    }
}
