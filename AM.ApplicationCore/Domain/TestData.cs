using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static List<Plane> Planes { get; set; } = new List<Plane>() {

        new Plane (){
        planeType=PlaneType.Boing,
        Capacity=150,
        ManufactureDate=new DateTime(2015,02,03)
        },
        new Plane (){
        planeType=PlaneType.Airbus,
        Capacity=250,ManufactureDate=new DateTime(2020,11,11)

        }
        };
        public static List<Staff> Staff { get; set; } = new List<Staff>() {
        new Staff()
        {
            FirstName="captain",
            LastName="capitain",
            EmailAddress="Captain.captain@gmail.com",
            BirthDate=new DateTime(1995,01,01),
            EmployementDate=new DateTime(1999,01,01),
            Salary=99999
        }
        };
        public static List<Traveller> Traveller { get; set; } = new List<Traveller>() {
        new Traveller()
        {
             FirstName="Traveller1",
            LastName="Traveller1",
            EmailAddress="Traveller1.Traveller1@gmail.com",
            BirthDate=new DateTime(1980,01,01),
            HealthInformation="No trouble",
            Nationality="Amercan"
        },
         new Traveller()
        {
             FirstName="Traveller2",
            LastName="Traveller2",
            EmailAddress="Traveller2.Traveller1@gmail.com",
            BirthDate=new DateTime(1970,01,01),
            HealthInformation="No trouble1",
            Nationality="Amercan1"
        },
          new Traveller()
        {
             FirstName="Traveller3",
            LastName="Traveller3",
            EmailAddress="Traveller3.Traveller1@gmail.com",
            BirthDate=new DateTime(1990,01,01),
            HealthInformation="No trouble2",
            Nationality="Amercan2"
        }

        };
        public static List<Flight> Flights { get; set; } = new List<Flight>()
        {
            new Flight()
            {
                FlightDate=new DateTime(2022,01,01,15,10,10),
                Destination="Paris",
                EffectiveArrival=new DateTime(2022, 01, 01, 17, 10, 10),
                plane= Planes[1],
                EstimationDuration=110,
                passengers= new List<Passenger>(Traveller),

            },
            new Flight()
            {
                FlightDate=new DateTime(2023,01,01,15,10,10),
                Destination="Paris",
                EffectiveArrival=new DateTime(2022, 01, 01, 17, 10, 10),
                plane= Planes[1],
                EstimationDuration=150,
                passengers= new List<Passenger>(Traveller),

            },

            new Flight()
            {
                FlightDate=new DateTime(2022,08,01,15,10,10),
                Destination="Madrid",
                EffectiveArrival=new DateTime(2022, 01, 01, 17, 10, 10),
                plane= Planes[1],
                EstimationDuration=150,

            }
        };
        public static Flight F1 = new Flight
        {
            FlightDate = new DateTime(2022, 01, 01),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 01, 01),
            plane = Planes[1],
            EstimationDuration = 110,
            passengers = new List<Passenger>(Traveller)


        };
    }
}
