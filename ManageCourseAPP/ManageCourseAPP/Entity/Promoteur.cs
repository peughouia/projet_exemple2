using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public class Promoteur
    {
        public int IdPro { get; set; }
        public string NomPro { get; set; }
        public string PrenomPro { get; set; }
        public string NomGroup { get; set; }
        public string PhonePro { get; set; }
        public string Password { get; set; }

        public static int nb;
        public Promoteur(string nomPro, string prenomPro, string nomGroup, string phonePro, string password)
        {
            IdPro = nb++;
            NomPro = nomPro;
            PrenomPro = prenomPro;
            NomGroup = nomGroup;
            PhonePro = phonePro;
            Password = password;
        }
    }
}
