using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
