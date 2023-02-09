using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Personne
    {
        // int id;
        //string prenom;
        //string nom;
        //DateTime dateNaissance;
        //string email;
        //string password;
        //string confirPassword;
        //public int Id { 
        //    get { return id; }
        //    set { id = value; } 
        //}
        public Personne()
        {
            nb++;
        }//ctor + double tabulation 
        public Personne(string prenom, string nom, string confirmPassword, string email, string password, DateTime dateNaissance)
        {
            Prenom = prenom;
            Nom = nom;
            ConfirmPassword = confirmPassword;
            Email = email;
            Password = password;
            DateNaissance = dateNaissance;
        }
        // surcharge 2 methode de meme nom mais parametre differente
        public bool Login(String nom, string password)
        {
            //var result= nom == Nom && password == Password?true : false;
            //if (nom == Nom && password == Password)
            //    return true;
            //else
            //return false;
            //return result;
            return nom == Nom && password == Password;
        }
        public bool Login(String nom, string password, string email)
        {

            return nom == Nom && password == Password && email==Email;
        }
        public virtual void GetMyType()// virtual f mere w override f fils ==> redefinition de methode heritage 
        {
            Console.WriteLine("je suis un Personne");
        }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateNaissance { get; set; }
        public static int nb { get; set; }
        public int Id { get; set; }

        public override string ToString()// tektb override tatl3 
        {
            //return base.ToString();// base kif super f java 
            return Id + " " + Nom + " " + Prenom +" " + Email + " " + Password + " " + ConfirmPassword;
        }
    }
}
