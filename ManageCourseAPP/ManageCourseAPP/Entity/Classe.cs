using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public  class Classe
    {
        public int IdClasse { get; set; }

        public string NomClasses { get; set; }
        public Classe() { }

        public Classe(string nomClasse)
        {
            NomClasses = nomClasse;
        }
        public Classe(int idClasse, string nomClasses)
        {
            IdClasse= idClasse;
            NomClasses= nomClasses;
        }

        public Classe(Classe classe)
        {

        }

    }
}
