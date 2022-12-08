using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public class Parent
    {
        public int idPar;
        public string nomPar;
        public string prenomPar;
        public int phoneParent;

        public static int nb;

        public Parent(string nomPar, string prenomPar, int phonePar)
        {
            this.idPar = nb++;
            this.nomPar = nomPar;
            this.prenomPar = prenomPar;
            this.phoneParent = phonePar;
        }
    }
}
