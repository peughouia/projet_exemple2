using ManageCourse.DAL;
using ManagerCourse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCourse.BLL
{
    public class PromoteurManager
    {
        readonly PromoteurDAL monPromoteur;
        public PromoteurManager()
        {
            monPromoteur = new PromoteurDAL();
        }

        public void CreateParent(Promoteur promoteur)
        {
            monPromoteur.Create(promoteur);
        }
    }
}
