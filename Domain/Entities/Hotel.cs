using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<HotelRoom> Rooms { get; set; }
    }
}
