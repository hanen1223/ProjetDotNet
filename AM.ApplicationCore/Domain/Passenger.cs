using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public Passenger(DateTime birthDate, string emailAddress, string firstName, string lastName, int telNumber, int passportNumber)
        {
            BirthDate = birthDate;
            EmailAddress = emailAddress;
            FirstName = firstName;
            LastName = lastName;
            TelNumber = telNumber;
            PassportNumber = passportNumber;
        }

        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }
        public int PassportNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
        //public bool checkProfil(string nom, string prenom) {

        //    return FirstName==nom && LastName==prenom;
        //}
        //public bool checkProfil(string nom, string prenom,string email)
        //{

        //    return FirstName == nom && LastName == prenom && EmailAddress==email;
        //}
        public bool checkProfil(string nom, string prenom, string email = null)
        {
            if (email == null)
            {
                return FirstName == nom && LastName == prenom;
            }
            return FirstName == nom && LastName == prenom && EmailAddress == email;
        }

        public Passenger()
        {
                
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }
    }
}
