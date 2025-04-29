using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHotelManagement.Models
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }

        public int HotelID { get; set; }

        public string Type { get; set; }

        public float Price { get; set; }

        public bool Availability { get; set; }

        public string Features { get; set; }

        [ForeignKey("HotelID")]
        public Hotel Hotel { get; set; }

        public ICollection<Booking> Bookings { get; set; }

    }
}
