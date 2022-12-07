using ManagerCourse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static ManageCourse.DAL.Connexion;

namespace ManageCourse.DAL
{
    public class ClasseDAL : IData<Classe>
    {
        MySqlConnection maConn;
        string StrConn = "Database=managerCourse; Data source=localhost; User Id=root;";


        public ClasseDAL() 
        {
           maConn= new MySqlConnection(StrConn);
        }

        public void Create(Classe data)
        {
           // string req = "";
            
            try
            {
                string query = $"insert into classe(NomClasse) values ('{data.NomClasse}')";
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

        public List<Classe> GetAll()
        {
            throw new NotImplementedException();
        }

        public Classe GetAnyById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Classe data)
        {
            throw new NotImplementedException();
        }

        
    }
}
