using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public class Matiere
    {
        public int idMat;
        public string nomMat;
        public Enseignant idensei;

        public static int nb;

        public Matiere(string nomMat, Enseignant idensei) 
        { 
            this.idMat= nb++;
            this.nomMat = nomMat;
            this.idensei = idensei;
        }    
    }
}
