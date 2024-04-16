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
        public User User { get; set; } // Пользователь, сделавший бронирование
        public Event Event { get; set; } // Мероприятие, на которое сделано бронирование
        public HotelRoom Room { get; set; } // Номер отеля, забронированный пользователем
        public TransportTicket Ticket { get; set; }
    }
}
