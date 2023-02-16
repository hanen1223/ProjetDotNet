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
            List<DateTime> dates = new List<DateTime>();
            foreach (var flight in Flights)
            {
                if (flight.Destination == destination)
                {
                    dates.Add(flight.FlightDate);
                   
                }

            }
            return dates;
        }
        // question 8 
        public void GetFlights( string filterValue, Func<Flight, String, Boolean> condition)
        {
            List<Flight> flights = new List<Flight>();
           // Func<Flight,String,Boolean> condition=null;
            foreach (var flight in Flights)
            {
                if (condition(flight,filterValue))
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

        
    }
}
