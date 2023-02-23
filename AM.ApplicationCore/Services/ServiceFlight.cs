using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
       
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
        {
            //List<DateTime> dates = new List<DateTime>();
            //for(int i = 0; i < Flights.Count; i++)
            //{
            //    if (Flights[i].Destination==destination)
            //        dates.Add(Flights[i].FlightDate);
            //}
            //return dates;
            //methode 2
            //  List<DateTime> dates = new List<DateTime>();

            //foreach (var flight in Flights)
            //{
            //    if (flight.Destination == destination)
            //    {
            //        dates.Add(flight.FlightDate);

            //    }

            //}
            // return dates;
            //methode3 :requete
            //var query = from f in Flights where f.Destination==destination select f.FlightDate;
            //return query.ToList();//Execution et convertion de type

            //methode3 :requete
            var query = Flights
                        .Where(f => f.Destination == destination)
                        .Select(f => f.FlightDate).ToList();
            return query;
        }
        // question 8 
        public void GetFlights(string filterValue, Func<Flight, String, Boolean> condition)
        {
            List<Flight> flights = new List<Flight>();
            // Func<Flight,String,Boolean> condition=null;
            foreach (var flight in Flights)
            {
                if (condition(flight, filterValue))
                {
                    flights.Add(flight);
                    Console.WriteLine(flight);

                }
            }

            //    if (filterType.Equals("Destination"))
            //    {

            //        foreach (var flight in Flights)
            //        {
            //            if (flight.Destination.Equals(filterValue))
            //            {
            //                flights.Add(flight);
            //                Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.planeType, flight.EstimationDuration, flight.passengers);

            //            }
            //        }

            //    }
            //    if (filterType.Equals("PlaneType"))
            //    {

            //        foreach (var flight in Flights)
            //        {
            //            if (flight.plane.planeType.Equals(filterValue))
            //            {
            //                flights.Add(flight);
            //                Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.planeType, flight.EstimationDuration, flight.passengers);

            //            }
            //        }

            //    }
            //    if (filterType.Equals("PlaneType"))
            //    {

            //        foreach (var flight in Flights)
            //        {
            //            if (flight.plane.planeType.Equals(filterValue))
            //            {
            //                flights.Add(flight);
            //                Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.planeType, flight.EstimationDuration, flight.passengers);

            //            }
            //        }

            //    }
            //    if (filterType.Equals("FlightDate"))
            //    {

            //        foreach (var flight in Flights)
            //        {
            //            if (flight.FlightDate.Equals(filterValue))
            //            {
            //                flights.Add(flight);
            //                Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.planeType, flight.EstimationDuration, flight.passengers);
            //            }
            //        }

            //    }
            //    if (filterType.Equals("EffectiveArrival"))
            //    {

            //        foreach (var flight in Flights)
            //        {
            //            if (flight.EffectiveArrival.Equals(filterValue))
            //            {
            //                flights.Add(flight);
            //                Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.planeType, flight.EstimationDuration, flight.passengers);

            //            }
            //        }

            //    }
            //********************************************************//
            //switch (filterType)
            //{
            //    case "Destination":
            //        foreach (var flight in Flights)
            //        {
            //            if (flight.Destination.Equals(filterValue))
            //            {
            //                flights.Add(flight);
            //                Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.planeType, flight.EstimationDuration, flight.passengers);

            //            }
            //        }
            //        break;
            //    case "EffectiveArrival":
            //        foreach (var flight in Flights)
            //        {
            //            if (flight.EffectiveArrival.Equals(filterValue))
            //            {
            //                flights.Add(flight);
            //                Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.planeType, flight.EstimationDuration, flight.passengers);

            //            }
            //        }
            //        break;
            //    case "FlightDate":
            //        foreach (var flight in Flights)
            //        {
            //            if (flight.FlightDate.Equals(filterValue))
            //            {
            //                flights.Add(flight);
            //                Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.planeType, flight.EstimationDuration, flight.passengers);
            //            }
            //        }
            //        break;
            //    case "PlaneType":
            //        foreach (var flight in Flights)
            //        {
            //            if (flight.plane.planeType.Equals(filterValue))
            //            {
            //                flights.Add(flight);
            //                Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.planeType, flight.EstimationDuration, flight.passengers);

            //            }
            //        }
            //        break;

            //}
        }

        public void GetFlights(string filterType, string filterValue)
        {
            throw new NotImplementedException();
        }
        public void ShowFlightDetails(Plane plane)
        {
            var query = Flights
                .Where(f => f.plane.PlaneId == plane.PlaneId)
                .Select(f => new { f.Destination, f.FlightDate });
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var query = Flights
               .Count(f => f.FlightDate > startDate && (f.FlightDate - startDate).TotalDays < 7);
            // .Where(f => f.FlightDate > startDate && (f.FlightDate - startDate).TotalDays < 7)
            // .Count();
            return query;
        }
        public double DurationAverage(string destination)
        {
            var query = Flights
                .Where(f => f.Destination.Equals(destination))
                .Average(f => f.EstimationDuration);
            return query;
        }
       public List<Flight> OrderedDurationFlights()
        {
            var query = from f in Flights orderby(f.EstimationDuration) descending select (f);
            //var query = Flights
                //.OrderByDescending(f => f.EstimationDuration).ToList();   
            return query.ToList();
        }
        //List<Passenger> SensiorTravellers(Flight flight)
        public List<Traveller> SeniorTravellers(Flight flight)
        {
            var query = flight.passengers.OfType<Traveller>()
               // .Where(p => p is Traveller)
                .OrderBy(p => p.BirthDate).Take(3).ToList();
            List<Passenger> p = new List<Passenger>(query); //cas implicite w9t n5alou return passenger
            //return query.ToList();
            return query;
        }
        public void DestinationGroupedFlights()
        {
            var query = Flights
                .GroupBy(f => f.Destination).ToList();
            foreach(var f in query)
            {
                Console.WriteLine("Destination:"+f.Key);
                foreach(var g in f )
                {
                    Console.WriteLine("Decollage: "+g.FlightDate);
                }
            }

        }
        int IServiceFlight.ProgrammedFlightNumber(DateTime startDate)
        {
            throw new NotImplementedException();
        }

        double IServiceFlight.DurationAverage(string destination)
        {
            throw new NotImplementedException();
        }

        List<Flight> IServiceFlight.OrderedDurationFlights()
        {
            throw new NotImplementedException();
        }

        List<Passenger> IServiceFlight.SeniorTravellers(Flight flight)
        {
            throw new NotImplementedException();
        }

        void IServiceFlight.ShowFlightDetails(Plane plane)
        {
            throw new NotImplementedException();
        }

        void IServiceFlight.DestinationGroupedFlights()
        {
            throw new NotImplementedException();
        }
        /************* Partie IV*****************/
        public Action<Plane> FlightDetailsDel { get; set; }//prop +double tabulation
        public Func<string, double> DurationAverageDel { get; set; }
        public ServiceFlight()//ctor +double tabulation
        {
            /*FlightDetailsDel = ShowFlightDetails;
             DurationAverageDel = DurationAverage; */
            FlightDetailsDel = (Plane plane) =>
            {
                var query = Flights
               .Where(f => f.plane.PlaneId == plane.PlaneId)
               .Select(f => new { f.Destination, f.FlightDate });
                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
            };
            DurationAverageDel = dAv =>
            {
                var query = Flights
                .Where(f => f.Destination.Equals(dAv))
                .Average(f => f.EstimationDuration);
                return query;
            };
        }
    }
    
}

