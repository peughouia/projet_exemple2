using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCourse.Model
{
    public class Enseignant
    {
        public int Id { get; set; }
        public string NomEnseigant { get; set; }
        public string PrenomEnseignant { get; set; }
        public string AdresseEnseignant { get; set; }
        public int IdPromoteur { get; set; }
        public int IdMatiere { get; set; }
        public Enseignant() { }
        public Enseignant(int id, string nomEnseigant, string prenomEnseignant, string adresseEnseignant, int idPromoteur, int idMatiere)
        {
            Id = id;
            NomEnseigant = nomEnseigant;
            PrenomEnseignant = prenomEnseignant;
            AdresseEnseignant = adresseEnseignant;
            IdPromoteur = idPromoteur;
            IdMatiere = idMatiere;
        }

        public Enseignant(Enseignant enseignant)
        {
            Id = enseignant.Id;
            NomEnseigant = enseignant.NomEnseigant;
            PrenomEnseignant = enseignant.PrenomEnseignant;
            AdresseEnseignant = enseignant.AdresseEnseignant;
            IdPromoteur = enseignant.IdPromoteur;
            IdMatiere = enseignant.IdMatiere;
        }
    }
}
