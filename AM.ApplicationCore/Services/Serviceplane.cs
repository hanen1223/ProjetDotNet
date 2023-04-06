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

        public IList<Passenger> GetPassenger(Plane plane)
        {
            return plane.Flights.SelectMany(p=>p.Tickets)
                .Select(t=>t.Passenger)
                .Distinct()
                .ToList();
        }
    }
}
