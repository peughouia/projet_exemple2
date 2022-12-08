using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public class Promoteur
    {
        public int idPro;
        public string nomPro;
        public string prenomPro;
        public string nomGroup;
        public int phonePro;

        public static int nb;
        
        public Promoteur(string nomPro,string prenomPro,string nomGroup,int phonePro) 
        {
            this.idPro = nb++;
            this.nomPro = nomPro;
            this.prenomPro= prenomPro;
            this.nomGroup = nomGroup;
            this.phonePro = phonePro;
        }
    }
}
