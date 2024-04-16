using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ransportTicket
    {
        public int Id { get; set; }
        public string TransportType { get; set; }
        public string DepartureLocation { get; set; }
        public string ArrivalLocation { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }
    }
}
