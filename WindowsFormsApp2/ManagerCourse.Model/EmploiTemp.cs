using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCourse.Model
{
    public class EmploiTemp
    {
        public int Id { get; set; }
        public string DateEmp { get; set; }
        public string HeureDeb { get; set; }
        public string HeureFin { get; set; }
        public int IdMatiere { get; set; }
        public int IdClasse { get; set; }

        public EmploiTemp() { }
        public EmploiTemp(int id, string dateEmp, string heureDeb, string heureFin, int idMatiere, int idClasse)
        {
            Id = id;
            DateEmp = dateEmp;
            HeureDeb = heureDeb;
            HeureFin = heureFin;
            IdMatiere = idMatiere;
            IdClasse = idClasse;
        }
        public EmploiTemp(EmploiTemp emploiTemp)
        {
            Id= emploiTemp.Id;
            DateEmp= emploiTemp.DateEmp;
            HeureDeb= emploiTemp.HeureDeb;
            HeureFin= emploiTemp.HeureFin;
            IdMatiere= emploiTemp.IdMatiere;
            IdClasse= emploiTemp.IdClasse;
        }
        
    }
}
