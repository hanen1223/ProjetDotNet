using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class Serviceplane : Service<Plane>, IServiceplane
    {
        public Serviceplane(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IList<Flight> GetFlights(int n)
        {
            //return GetAll().OrderBy(p=>p.PlaneId)
            //      .TakeLast(n).SelectMany(p=>p.Flights)
            //      .OrderBy(p=>p.FlightDate)
            //      .ToList();
            return GetAll().OrderByDescending(p => p.PlaneId)
                  .Take(n).SelectMany(p => p.Flights)
                  .OrderBy(p => p.FlightDate)
                  .ToList();
        }

        public IList<Passenger> GetPassenger(Plane plane)
        {

            return plane.Flights.SelectMany(p => p.Tickets)
               .Select(t => t.Passenger)
             .Distinct()
              .ToList();
        }
        public bool IsAvailablePlane(Flight f, int n)
        {   //methode 1:
            //var capacity = f.plane.Capacity;
            //var tickets = f.Tickets.Count();
            //return capacity-tickets > n;
            //methode 2: where trj3 liste feha k3ba w7da donc lazm ba3ed'ha fisrt bech matrj3ch liste
            //var plane =GetAll().Where(p=>p.Flights.Contains(f)==true).First(); kif ligne 44
            //var plane = GetAll().Where(p => p.Flights.Contains(f) == true).FirstOrDefault();
            var plane = Get(p => p.Flights.Contains(f) == true);//meme 44 et 43
            var capacity =plane.Capacity;
            var flight = plane.Flights.Single(j=>j.FlightId== f.FlightId);
            //                         .where ((j=>j.FlightId== f.FlightId).single();
            // difference entre single et first :fisrt lel liste eli traj3 barcha w single leli tbda mt2kd mnha feha k3ba w7da
            var ticket = flight.Tickets.Count();
            return capacity - ticket> n ;
        }
        public void DeletePlanes()
        {

        }
    }
}
