using ManageCourseAPP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageCourseAPP.Entity;

namespace ManageCourseAPP.Service
{
    public class ClasseService
    {
        readonly ClasseDAL maClasse;
        public ClasseService() 
        {
            maClasse= new ClasseDAL();
        }

        public void CreateClasse(Classe classe)
        {
            maClasse.Create(classe);
        }
    }
}
