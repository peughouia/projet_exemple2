using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCourse.Model
{
    public class Note
    {
        public int Id { get; set; }
        public string CritereNotation { get; set; }
        public string Date_notation { get; set; }
        public int IdMatiere { get; set; }
        public int IdApprenant { get; set; }

        public Note() { }
        public Note(int id, string critereNotation, string date_notation, int idMatiere, int idApprenant)
        {
            Id = id;
            CritereNotation = critereNotation;
            Date_notation = date_notation;
            IdMatiere = idMatiere;
            IdApprenant = idApprenant;
        }

        public Note(Note note)
        {
            Id = note.Id;
            CritereNotation= note.CritereNotation;
            Date_notation = note.Date_notation;
            IdMatiere = note.IdMatiere;
            IdApprenant = note.IdApprenant;

        }

        
    }
}
