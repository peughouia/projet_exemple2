using ManagerCourse.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourse.DAL
{
    public class ParentDAL : IData<Parent>
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
                    $"values('{data.NomParent}','{data.PrenomParent}','{data.PhoneParent}','{data.Password}')";
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

        public List<Parent> GetAll()
        {
            throw new NotImplementedException();
        }

        public Parent GetAnyById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Parent data)
        {
            throw new NotImplementedException();
        }
    }
}
