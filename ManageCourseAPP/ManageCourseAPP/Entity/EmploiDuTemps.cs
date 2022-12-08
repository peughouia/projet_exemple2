using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public class EmploiDuTemps
    {
        public int IdEmp { get; set; }
        public Matiere Matiere { get; set; }
        public DateTime HeureDeb { get; set; }
        public DateTime HeureFin { get; set; }
        public DateTime DateEmp { get; set; }
        public Classe Classe { get; set; }
        public Enseignant Enseignant { get; set; }

        public static int nb;
        public EmploiDuTemps(Matiere matiere, DateTime heureDeb, DateTime heureFin,DateTime dateEmp, Classe classe, Enseignant enseignant)
        {
            IdEmp = nb++;
            Matiere = matiere;
            HeureDeb = heureDeb;
            HeureFin = heureFin;
            DateEmp = dateEmp;
            Classe = classe;
            Enseignant = enseignant;
        }
    }
}
