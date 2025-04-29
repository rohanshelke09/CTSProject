using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace SmartHotelManagement.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // e.g., "Admin", "User"
        public long ContactNumber { get; set; }

        public LoyaltyAccount LoyaltyAccount { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Review> Reviews { get; set; }

        public ICollection<Payment> Payments { get; set; }

        public ICollection<Redemption> Redemptions { get; set; }



    }
}