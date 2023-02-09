using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType { 
    Boing,
    Airbus
    }
    public class Plane
    {
        public Plane() { }
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType planeType { get; set; }
        public ICollection<Flight> Flights { get; set; }
        //List<Passenger> Passenger { get; set; }
        public override string ToString()
        {
            return "Capacity: " + Capacity + ", ManufactureDate: " + ManufactureDate + ", PlaneType: " + planeType;
        }
        //public Plane(PlaneType pt, int capacity, DateTime date)
        //{
        //    this.Capacity = capacity;
        //    this.planeType = pt;
        //    this.ManufactureDate = date;
            
        //}
        

    }
}
