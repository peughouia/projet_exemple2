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
    public class MatiereDAL
    {
        MySqlConnection maConn;
        string StrConn = "Database=managerCourse; Data source=localhost; User Id=root;";

        public MatiereDAL()
        {
            maConn = new MySqlConnection(StrConn);
        }
        public void Create(Matiere data)
        {
            try
            {
                string query = $"insert into matiere(NomMatiere)values('{data.nomMat }')";
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
