//// See https://aka.ms/new-console-template for more information
////declaration variable 
//string ch;
////type: string, int, char, double, float, bool,DateTime, long, ....

//for (int i = 0; i < 2; i++)
//{
//    ch = Console.ReadLine();

//    Console.WriteLine("Bonjour " + ch);



//    int chiffreValue = 0;

//   // do
//    //
//        try
//        {
//            string chiffre = Console.ReadLine();
//            chiffreValue = int.Parse(chiffre);
//        if (chiffreValue > 15 && chiffreValue <= 18)
//        { Console.WriteLine("Ados"); }
//        else if (chiffreValue > 18)
//        { Console.WriteLine("Adulte"); }

//    }
//        catch
//        {
//            Console.WriteLine("Erreur au niveau de conversion du chiffre");
//        }
//    //} while (chiffreValue == 0);

//    Console.WriteLine("Votre nombre est " + (chiffreValue + 1));

//}
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using System.Collections;
using System.Net.Mail;
//using System.Numerics;
using System.Security.Cryptography;

Personne p = new Personne();// constructeur par defaut
p.Id = 11;
p.Nom = "hammouda";
p.Prenom = "hanen";
p.Email = "hanen.hammouda@esprit.tn";
p.DateNaissance = new DateTime(2000, 12, 25);//DateTime.Now;
p.Password= "0000";
p.ConfirmPassword = "0000";
Console.WriteLine(p);

//constructeur parametrer
//Personne p1 = new Personne("prenom","nom","confirmPassword","email","password",DateTime.Now);
//Console.WriteLine(p1);
//iniyialisateur d'objet
Personne p2 = new Personne()
{
    Email = "hanen.hammouda@esprit.tn",
    Nom = "hanen",
    Prenom = "hammouda",
    DateNaissance = DateTime.Now,
    Password = "0000",
    ConfirmPassword = "0000"
};
//Conducteur c = new Conducteur();
//p.GetMyType();
//c.GetMyType();

//// classe fils:Conducteur , class mere:Personne

Personne c = new Conducteur();
p.GetMyType();
c.GetMyType();

//Console.WriteLine("************  Instanciation des objets Q7  ************* ");
Plane pl = new Plane();
pl.Capacity = 200;
pl.ManufactureDate = new DateTime(2023, 1, 1);
pl.planeType = PlaneType.Boing;
Console.WriteLine(pl);

//Console.WriteLine("************  Instanciation des objets Q8  ************* ");
//Plane avion = new Plane(PlaneType.Airbus,100, DateTime.Now);
//Console.WriteLine(avion);

Console.WriteLine("************  Instanciation des objets Q9  ************* ");
Plane avion2 = new Plane()
{
    Capacity = 20555,
    ManufactureDate = new DateTime(2023, 1, 1),
    planeType = PlaneType.Boing
};
Console.WriteLine(avion2);

Console.WriteLine("************  Le Polymorphisme Q10 a  ************* ");
Passenger pasn = new Passenger() {
    BirthDate = new DateTime(2023, 1, 1),
EmailAddress = "hanen.hammouda@esprit.tn",
    FirstName = "hanen",
LastName = "hammouda",
TelNumber = 50066282,
PassportNumber = 123456
};

bool Result = pasn.checkProfil("hanen", "hammouda");
if (Result) { Console.WriteLine("nom est correct"); }
else Console.WriteLine("incorrect");

Console.WriteLine("************  Le Polymorphisme Q10  b ************* ");
Console.WriteLine(pasn.checkProfil("hanen", "hammouda", "hanen.hammouda@esprit.tn"));

Console.WriteLine("************  Le Polymorphisme Q11 a b c ************* ");
Passenger traveller = new Traveller();
Passenger staff = new Staff();
Passenger Passenger = new Passenger();
traveller.PassengerType();
staff.PassengerType();
Passenger.PassengerType();
//collection des objets non génériques
ArrayList list = new ArrayList();
list.Add(pl);
list.Add(1);
list.Add("Bonjour");

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}
foreach (var item in list)
{
    Console.WriteLine(item);
}
//collection des objets génériques
IList<Plane> planes = new List<Plane>();
//IList:Ienumerable,Icollection
//ICollection:IEnumerable
//IEnumerable: assure le parcour des listes uniquement
//ICollection: les méthode des parcours et l'insertion(add, remove, recherche ...)
planes.Add(pl);
planes.Add(avion2);
IList<Plane> planes1 = new List<Plane>()
{
    pl,avion2,new Plane(){Capacity=12,PlaneId=4, ManufactureDate=new DateTime(2022,11,11)}
};
Personne p11 = new Personne();
Console.WriteLine(Personne.nb);
Personne p22 = new Personne();
Console.WriteLine(Personne.nb);
Personne p33 = new Personne();
Console.WriteLine(Personne.nb);

Console.WriteLine("************ TP2 5- ************* ");
ServiceFlight serviceFlight = new ServiceFlight();
serviceFlight.Flights = TestData.Flights;
serviceFlight.GetFlights("Paris",delegate(Flight f,String c)
{
    return f.Destination == c;
}
);
serviceFlight.GetFlights("2023/01/01", delegate (Flight f, String c)
{
    return f.FlightDate.Equals(c);
}
);
foreach (var flight in serviceFlight.GetFlightDates("Paris"))
{
    Console.WriteLine("le date est: " + flight);
};
serviceFlight.ShowFlightDetails(pl);
Console.WriteLine("la moyenne de durée estimées des vols:");
Console.WriteLine(serviceFlight.DurationAverage("Paris"));
Console.WriteLine("le nombre de vols programmés pour une semaine (7jours):");
Console.WriteLine(serviceFlight.ProgrammedFlightNumber(new DateTime(2022, 01, 01)));

foreach (var flight in serviceFlight.OrderedDurationFlights()) 
{
    Console.WriteLine("l'ordere est: " + flight);
};
foreach (var f in serviceFlight.SeniorTravellers(TestData.F1))
{
    Console.WriteLine("les senior travellers: "+f.FirstName);
};
Console.WriteLine("les vols groupés par destination: ");
serviceFlight.DestinationGroupedFlights();
Console.WriteLine("IV- Expressions Lambda / Les méthodes LINQ prédéfinies: ");
Console.WriteLine(serviceFlight.DurationAverageDel("Paris"));
serviceFlight.FlightDetailsDel(avion2);
Passenger pasn1 = new Passenger()
{
    FirstName = "stormi",
    LastName = "store"
};
Console.WriteLine(" ******** Résultat de la méthode d’ extension UpperFullName **************");
pasn1.UpperFullName();
Console.WriteLine(pasn1);
//Console.WriteLine(pasn1.ToString());
// test des methode extension
int a = 11;
Console.WriteLine(a.add(20));

