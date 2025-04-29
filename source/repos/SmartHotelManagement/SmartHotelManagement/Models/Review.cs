using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHotelManagement.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int HotelID { get; set; }

        public float Rating { get; set; }
        public string Comment { get; set; }
        public DateTime Timestamp { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [ForeignKey("HotelID")]
        public Hotel Hotel { get; set; }
    }
}
