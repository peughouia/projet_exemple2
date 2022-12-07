using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageCourse.DAL;
using ManagerCourse.Model;

namespace ManagerCourse.BLL
{
    public class MatiereManager
    {
        readonly MatiereDAL maMatiere;
        public MatiereManager()
        {
            maMatiere = new MatiereDAL();
        }

        public void CreateMatiere(Matiere matiere)
        {
            maMatiere.Create(matiere);
        }
    }
}
