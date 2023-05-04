using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string Pilote { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public int FlightId { get; set;}
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimationDuration { get; set; }
        [ForeignKey(nameof(Plane))]//==[ForeignKey(Plane)]
        public int ? PlaneFK { get; set; }//? nullable
        public virtual Plane ? plane { get; set; }//prop de navigation
        //public ICollection<Passenger> passengers { get; set; }
       // public IList<Passenger> Passes{ get; set; }
        public virtual IList<Ticket> Tickets{ get; set; }
        public override string ToString()
        {
            return FlightId + " " + Destination + " " + Departure + " " + FlightDate + " " + EffectiveArrival + " " + EstimationDuration;
        }
    }
}
