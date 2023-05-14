using System.ComponentModel.DataAnnotations;

namespace Hotelmanagement.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int RoomId { get; set; }

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string GuestName { get; set; }

        [Required]
        [MaxLength(50)]
        public string GuestEmail { get; set; }

        [Required]
        [MaxLength(20)]
        public string GuestPhone { get; set; }

        public Room Room { get; set; }
    }
}
