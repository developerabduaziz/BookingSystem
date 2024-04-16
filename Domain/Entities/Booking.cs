using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        public decimal TotalPrice { get; set; }
        public User User { get; set; } 
        public Event Event { get; set; } 
        public HotelRoom Room { get; set; } 
        public TransportTicket Ticket { get; set; }
    }
}
