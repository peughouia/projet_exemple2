using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCourse.Model
{
    public class Classe
    {
        public int Id { get; set; }
        public string NomClasse { get; set; }
        public Classe() { }
        public Classe(int id, string nom) 
        {
            Id = id;
            NomClasse = nom;
        }
        public Classe( string nom)
        {
            NomClasse = nom;
        }

        public Classe(Classe classe) 
        { 
            Id = classe.Id;
            NomClasse= classe.NomClasse;
        }
    }
}
