using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            TelNumber = telNumber;
            PassportNumber = passportNumber;
        }
        [Display(Name ="Date of Birth"),DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [EmailAddress] // ==[DataType(DataType.EmailAddress)]//
        public string EmailAddress { get; set; }
        [StringLength(maximumLength:25,MinimumLength =3,ErrorMessage ="regle pas respecter")]
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //[MaxLength(8),MinLength(8)]//kn string TelNumber twali t7ot
        [RegularExpression("[0-9]{8}")]//{,8}de 0 a 8 et {8,}de 8 a infini et {4,8}de 4 a 8 caractaire 
        public int TelNumber { get; set; }
        [MaxLength(7),Key]
        public int PassportNumber { get; set; }
        public int Id { get; set; }
        //public ICollection<Flight> Flights { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
        //public override string ToString()
        //{
        //    return base.ToString();
        //}
        public FillName fillName { get; set; }
        public override string ToString()
        {
            return "Passenger :BirthDate= " + BirthDate +
                " , TelNumber= " + TelNumber + " , EmailAddress= " + EmailAddress + " , Passeport Number= " + "\n";
        }
        //public bool checkProfil(string nom, string prenom) {

        //    return FirstName==nom && LastName==prenom;
        //}
        //public bool checkProfil(string nom, string prenom,string email)
        //{

        //    return FirstName == nom && LastName == prenom && EmailAddress==email;
        //}
        //public bool checkProfil(string nom, string prenom, string email = null)
        //{
        //    if (email == null)
        //    {
        //        return FirstName == nom && LastName == prenom;
        //    }
        //    return FirstName == nom && LastName == prenom && EmailAddress == email;
        //}

        public Passenger()
        {
                
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }
    }
}
