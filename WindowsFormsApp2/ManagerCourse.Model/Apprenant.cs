using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCourse.Model
{
    public class Apprenant
    {
        

        public int Id { get; set; }
        public string LastName { get; set; }

        public Apprenant() { }
        public Apprenant(int id, string lastName)
        {
            Id = id;
            LastName= lastName;
        }
        public Apprenant(Apprenant apprenant)
        {
            Id = apprenant.Id;
            LastName = apprenant.LastName;
        }
        
    }
}
