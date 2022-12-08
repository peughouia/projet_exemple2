using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public class EmploiDuTemps
    {
        public int idEmp;
        public Matiere idMat;
        public DateTime heureDEb;
        public DateTime heureFin;
        public DateTime dateEmp;
        public Promoteur idpro;
        public Classe idClasse;

        public static int nb;
        public EmploiDuTemps(Matiere idMat, DateTime heureDeb, DateTime heureFin,DateTime dateEmp,Promoteur idpro, Classe idClasse)
        {
            this.idEmp = nb++;
            this.idMat = idMat;
            this.heureDEb= heureDeb;
            this.heureFin = heureFin;
            this.dateEmp = dateEmp;
            this.idpro = idpro;
            this.idClasse= idClasse;
        }
    }
}
