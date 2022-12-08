using ManageCourseAPP.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.DAL
{
    public class PromoteurDAL
    {
        MySqlConnection maConn;
        string StrConn = "Database=managerCourse; Data source=localhost; User Id=root;";


        public PromoteurDAL()
        {
            maConn = new MySqlConnection(StrConn);
        }

        public void Create(Promoteur data)
        {
            try
            {
                string query = $"insert into promoteur(NomPrmoteur,PrenomPromoteur,PhonePromoteur,NomGroupe,password)" +
                    $"values('{data.NomPro}','{data.PrenomPro}','{data.PhonePro}','{data.NomGroup}','{data.Password}')";
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
