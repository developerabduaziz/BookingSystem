using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } 
        public List<Booking> Bookings { get; set; }
    }
}
