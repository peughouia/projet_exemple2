using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCourse.Model
{
    public class Promoteur
    {
        public int Id { get; set; }
        public string NomPromoteur { get; set; }
        public string PrenomPromoteur { get; set; }
        public string PhonePromoteur { get; set; }
        public string NomGroupe { get; set; }
        public string Password { get; set; }

        public Promoteur() 
        {

        }
        public Promoteur(int id, string nomPromoteur, string prenomPromoteur, string phonePromoteur, string nomGroupe, string password)
        {
            Id = id;
            NomPromoteur = nomPromoteur;
            PrenomPromoteur = prenomPromoteur;
            PhonePromoteur = phonePromoteur;
            NomGroupe = nomGroupe;
            Password = password;
        }
        public Promoteur(string nomPromoteur, string prenomPromoteur, string phonePromoteur, string nomGroupe, string password)
        {
            NomPromoteur = nomPromoteur;
            PrenomPromoteur = prenomPromoteur;
            PhonePromoteur = phonePromoteur;
            NomGroupe = nomGroupe;
            Password = password;
        }
        public Promoteur(Promoteur promoteur)
        {
            Id = promoteur.Id;
            NomPromoteur= promoteur.NomPromoteur;
            NomPromoteur = promoteur.NomPromoteur;
            PhonePromoteur= promoteur.PhonePromoteur;
            NomGroupe= promoteur.NomGroupe;
        }
    }
}
