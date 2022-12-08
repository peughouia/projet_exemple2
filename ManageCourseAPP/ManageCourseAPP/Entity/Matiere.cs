using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public class Matiere
    {
        public int idMat { get; set; }
        public string nomMat { get; set; }

        public static int nb;

        public Matiere(string nomMat)
        { 
            this.idMat= nb++;
            this.nomMat = nomMat;
        }    
    }
}
