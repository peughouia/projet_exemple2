using ManageCourseAPP.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.DAL
{
    public class ApprenantDAL
    {
        MySqlConnection maConn;
        string StrConn = "Database=managerCourse; Data source=localhost; User Id=root;";
        public ApprenantDAL()
        {
            maConn= new MySqlConnection(StrConn);
        }

        public void Create(Apprenant data)
        {
            

            try
            {
                string query = $"insert into classe(NomApprenant,PrenomApprenant,classe,Parent)values('{data.NomApp}','{data.PrenomApp}','{data.Classe}','{data.Parent}')";
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
