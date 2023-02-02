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
using System.Net.Mail;
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
Personne p1 = new Personne("prenom","nom","confirmPassword","email","password",DateTime.Now);
Console.WriteLine(p1);
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
//Plane pl = new Plane();
//pl.Capacity = 200;
//pl.ManufactureDate = new DateTime(2023, 1, 1);
//pl.planeType = PlaneType.Boing;
//Console.WriteLine(pl);

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
    FirstName = "Hanen",
LastName = "hammouda",
TelNumber = 50066282,
PassportNumber = 123456
};

bool Result = pasn.CheckProfile("Hgganen","hammouda");
if (Result) { Console.WriteLine("nom est correct"); }
else Console.WriteLine("incorrect");

Console.WriteLine("************  Le Polymorphisme Q10  b ************* ");
Console.WriteLine(pasn.CheckProfile("Hanen", "hammouda", "hanen.hammouda@esprit.tn"));

Console.WriteLine("************  Le Polymorphisme Q10  c ************* ");

bool result = pasn.CheckProfile2("Hanen", "hammouda", "hanen.hammouda@esprit.tn");
Console.WriteLine(result); // True

result = pasn.CheckProfile2("Jg", "Dok", "hanen.hammouda@esprit.tn");
Console.WriteLine(result); // False

result = pasn.CheckProfile2("Hanen", "hammouda", "");
Console.WriteLine(result); // True


Console.WriteLine("************  Le Polymorphisme Q11 a b c ************* ");
 Passenger pas1 = new Passenger();
Console.WriteLine(pas1.PassengerType());
Passenger pas2 = new Staff();
Console.WriteLine(pas2.PassengerType());
Passenger pas3 = new Traveller();
Console.WriteLine(pas3.PassengerType());
