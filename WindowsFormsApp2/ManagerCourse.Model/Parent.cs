using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCourse.Model
{
    public class Parent
    {
        public int Id { get; set; }
        public string NomParent { get; set; }
        public string PrenomParent { get; set; }
        public string PhoneParent { get; set; }
        public string Password { get; set; }

        public Parent() { }
        public Parent(int id, string nomParent, string prenomParent, string phoneParent, string password)
        {
            Id = id;
            NomParent = nomParent;
            PrenomParent = prenomParent;
            PhoneParent = phoneParent;
            Password = password;
        }
        public Parent(string nomParent, string prenomParent, string phoneParent, string password)
        {
            NomParent = nomParent;
            PrenomParent = prenomParent;
            PhoneParent = phoneParent;
            Password = password;
        }
        public Parent(Parent parent) 
        { 
            Id= parent.Id;
            NomParent = parent.NomParent;
            PrenomParent= parent.PrenomParent;
            PhoneParent= parent.PhoneParent;
        }
    }
}
