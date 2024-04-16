using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class HotelRoom
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerNight { get; set; }
        public Hotel Hotel { get; set; }
    }
}
