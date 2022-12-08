using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public class Apprenant
    {
        public int IdApp { get; set; }
        public string NomApp { get; set; }
        public string PrenomApp { get; set; }
        public Classe Classe { get; set; }
        public Parent Parent { get; set; }
        public static int nb { get; set; }

        public Apprenant()
        {

        }
        public Apprenant(string nomApp,string prenomApp,Classe classe, Parent parent) 
        {
            IdApp = nb++;
            NomApp = nomApp;
            PrenomApp= prenomApp;
            Classe= classe;
            Parent= parent;
        }          
    }
}
