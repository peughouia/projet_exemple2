using ManageCourseAPP.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.DAL
{
    public class EmploiTempDAL
    {
        MySqlConnection maConn;
        string StrConn = "Database=managerCourse; Data source=localhost; User Id=root;";
        public EmploiTempDAL()
        {
            maConn = new MySqlConnection(StrConn);
        }
    }
}
