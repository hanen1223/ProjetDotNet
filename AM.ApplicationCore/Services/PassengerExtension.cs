using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public static class PassengerExtension
    {
        public static void UpperFullName(this Passenger passenger)
        {

            // passenger.FirstName = passenger.FirstName.ToUpper();
            passenger.FirstName = passenger.FirstName[0].ToString().ToUpper()+ passenger.FirstName.Substring(1);//substring indice de debut=0 ,exp hello indice de "e"=1
            passenger.LastName = passenger.LastName[0].ToString().ToUpper() + passenger.LastName.Substring(1);  
        }
        public static int add(this int a, int b ) {//this a: pour injection dans la class int
            return a + b;
        }
        //public static int add1(this int a,float b,int c)
        //{//this a: pour injection dans la class int
        //    return a + b+c ;
        //}
        //Une méthode d'extension est une méthode de classe (static) accessible et placée dans une classe à la fois qualifiée public et static 
    }
}