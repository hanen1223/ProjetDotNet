using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public bool VIP { get; set; }
        public double Prix { get; set; }
        public string Siege { get; set; }
        [ForeignKey("passanFK")]
        public string passanFK { get; set; }
        [ForeignKey("FlightFK")]
        public int FlightFK { get; set; }
        public Flight Flight { get; set; }
        public Passenger Passenger { get; set; }
    }
}