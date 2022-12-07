using ManagerCourse.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourse.DAL
{
    public class MatiereDAL : IData<Matiere>
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
                string query = $"insert into matiere(NomMatiere)values('{data.NomMatiere}')";
                maConn.Open();
                MySqlCommand command = new MySqlCommand(query, maConn);
                command.ExecuteNonQuery();
            } 
            catch(Exception ex)
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

        public List<Matiere> GetAll()
        {
            throw new NotImplementedException();
        }

        public Matiere GetAnyById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Matiere data)
        {
            throw new NotImplementedException();
        }
    }
}
