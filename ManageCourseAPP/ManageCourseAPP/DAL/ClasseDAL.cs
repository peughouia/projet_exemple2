using ManageCourseAPP.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.DAL
{
    public class ClasseDAL
    {
        MySqlConnection maConn;
        string StrConn = "Database=managerCourse; Data source=localhost; User Id=root;";


        public ClasseDAL()
        {
            maConn = new MySqlConnection(StrConn);
        }

        public void Create(Classe data)
        {
            // string req = "";

            try
            {
                string query = $"insert into classe(NomClasse) values ('{data.NomClasses}')";
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
