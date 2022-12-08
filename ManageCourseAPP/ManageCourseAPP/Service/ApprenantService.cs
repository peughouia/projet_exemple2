using ManageCourseAPP.DAL;
using ManageCourseAPP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Service
{
    public class ApprenantService
    {
        readonly ApprenantDAL monApprenant;
        public ApprenantService() 
        {
            monApprenant = new ApprenantDAL();   
        }

        public void CreateApprenant(Apprenant apprenant)
        {
            monApprenant.Create(apprenant);
        }
    }
}
