using System;
using System.Collections.Generic;
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
        public Flight Flight { get; set; }
        public Passenger Passenger { get; set; }

    }
}
