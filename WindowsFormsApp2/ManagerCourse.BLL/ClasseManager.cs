using ManageCourse.DAL;
using ManagerCourse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCourse.BLL
{
    public class ClasseManager
    {
        readonly ClasseDAL maClasse;
        public ClasseManager() 
        {
            maClasse = new ClasseDAL();
        }

        public void CreateClasse(Classe classe)
        {
            maClasse.Create(classe);
        }

        public List<Classe> GetClasseList()
        {
            List<Classe> classes = new List<Classe>();
            try
            {
                classes = maClasse.GetAll();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return classes;
        }

    }
}
