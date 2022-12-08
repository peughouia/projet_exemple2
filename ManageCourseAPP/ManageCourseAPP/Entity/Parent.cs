using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public class Parent
    {
        public int idPar { get; set; }
        public string NomPar { get; set; }
        public string PrenomPar { get; set; }
        public string PhoneParent { get; set; }
        public string Password { get; set; }

        public static int nb;

        public Parent(string nomPar, string prenomPar, string phonePar,string password)
        {
            this.idPar = nb++;
           NomPar = nomPar;
           PrenomPar = prenomPar;
           PhoneParent = phonePar;
            Password = password;
        }
    }
}
