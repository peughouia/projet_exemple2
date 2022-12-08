using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public class Apprenant
    {
        public int idApp;
        public string nomApp;
        public string prenomApp;
        public Classe idClasse;
        public Parent idPar;
        public Enseignant idEnsei;

        public static int nb;

        public Apprenant(string nomApp,string prenomApp,Classe idClasse, Parent idPar, Enseignant idEnsei) 
        {
            this.idApp = nb++;
            this.nomApp = nomApp;
            this.prenomApp= prenomApp;
            this.idClasse= idClasse;
            this.idPar= idPar;
            this.idEnsei= idEnsei;
        }          
    }
}
