using ManageCourseAPP.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.DAL
{
    public class ParentDAL
    {
        MySqlConnection maConn;
        string StrConn = "Database=managerCourse; Data source=localhost; User Id=root;";

        public ParentDAL()
        {
            maConn = new MySqlConnection(StrConn);
        }
        public void Create(Parent data)
        {

            try
            {
                string query = $"insert into matiere(NomParent,PrenomParent,PhoneParent,password)" +
                    $"values('{data.NomPar}','{data.PrenomPar}','{data.PhoneParent}','{data.Password}')";
                maConn.Open();
                MySqlCommand command = new MySqlCommand(query, maConn);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                maConn.Close();
            }

        }

    }
}
