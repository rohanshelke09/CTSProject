using System.ComponentModel.DataAnnotations;

namespace SmartHotelManagement.Models
{
    public class Hotel
    {
        [Key]
        public int HotelID { get; set; }    

        public string Name { get; set; }

        public string Location { get; set; }

        public int ManagerId { get; set; }

        public string Amenities { get; set; }
        
        public float Rating { get; set; }

        public ICollection<Room> Rooms { get; set; }
        public ICollection<Review> Reviews { get; set; }

    }
}
