using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public bool VIP { get; set; }
        public double Prix{ get; set; }
        public string Siege{ get; set; }
        [Key]
        public string passanFK{ get; set; }
        [Key]
        public int FlightFK{ get; set; }
        public Flight Flight { get; set; }
        public Passenger Passenger { get; set; }

    }
}
