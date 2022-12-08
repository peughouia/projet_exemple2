using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public class Enseignant
    {
        public int idEnsei;
        public string nomEnsei;
        public string prenomEnsei;
        public string matiereProbable;
        public string adresseEnsei;
        public Promoteur idpro;
        public Matiere idmat;

        public static int nb;

        public Enseignant(string nomEnsei,string prenomEnsei,string matiereProbable,string adresseEnsei)
        {
            this.idEnsei = nb++;
            this.nomEnsei = nomEnsei;
            this.prenomEnsei = prenomEnsei;
            this.matiereProbable = matiereProbable;
            this.adresseEnsei= adresseEnsei;
        }
    }
}
