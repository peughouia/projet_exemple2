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
        public int IdEnsei { get; set; }
        public string NomEnsei { get; set; }
        public string PrenomEnsei { get; set; }
        public string PhoneEnsei { get; set; }
        public Promoteur Idpro { get; set; }
        public Matiere Idmat { get; set; }

        public static int nb;

        public Enseignant(string nomEnsei,string prenomEnsei,string phoneEnsei)
        {
            IdEnsei = nb++;
            NomEnsei = nomEnsei;
            PrenomEnsei = prenomEnsei;
            PhoneEnsei= phoneEnsei;
        }

        public Enseignant(string nomEnsei,string prenomEnsei,string phone,Promoteur idpro,Matiere idmat)
        {
            IdEnsei = nb++;
            PrenomEnsei = nomEnsei;
            PhoneEnsei = phone;
            Idpro = idpro;
            Idmat = idmat;
            
        }
    }
}
