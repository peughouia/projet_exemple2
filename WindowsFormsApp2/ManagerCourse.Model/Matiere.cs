using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCourse.Model
{
    public class Matiere
    {
        public int Id { get; set; }
        public string NomMatiere { get; set; }

        public Matiere() { }

        public Matiere(int id, string nomMatiere)
        {
            Id = id;
            NomMatiere = nomMatiere;
        }

        public Matiere(string nomMatiere)
        {
            NomMatiere = nomMatiere;
        }

        public Matiere(Matiere matiere)
        {
            Id= matiere.Id;
            NomMatiere= matiere.NomMatiere;
        }
    }
}
