using ManagerCourse.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourse.DAL
{
    public class PromoteurDAL : IData<Promoteur>
    {
        MySqlConnection maConn;
        string StrConn = "Database=managerCourse; Data source=localhost; User Id=root;";


        public PromoteurDAL() 
        {
            maConn= new MySqlConnection(StrConn);
        }

        public void Create(Promoteur data)
        {
            try
            {
                string query = $"insert into promoteur(NomPrmoteur,PrenomPromoteur,PhonePromoteur,NomGroupe,password)" +
                    $"values('{data.NomPromoteur}','{data.PrenomPromoteur}','{data.PhonePromoteur}','{data.NomGroupe}','{data.Password}')";
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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Promoteur> GetAll()
        {
            throw new NotImplementedException();
        }

        public Promoteur GetAnyById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Promoteur data)
        {
            throw new NotImplementedException();
        }
    }
}
