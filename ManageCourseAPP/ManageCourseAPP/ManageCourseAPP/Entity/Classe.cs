using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public  class Classe
    {
        public int idClasse;

        public string nomClasses;

        public static int nb;


        public Classe(string nomClasse)
        {
            this.idClasse = nb++;
            this.nomClasses = nomClasse;
        }

    }
}
