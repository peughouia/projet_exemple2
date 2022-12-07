using ManageCourse.DAL;
using ManagerCourse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCourse.BLL
{
    public class ParentManager
    {
        readonly ParentDAL monParent;
        public ParentManager() 
        {
                monParent= new ParentDAL();
        }

        public void CreateParent(Parent parent)
        {
            monParent.Create(parent);
        }
    }
}
