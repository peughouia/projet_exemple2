using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public class Note
    {
        public Apprenant idApp { get; set; }
        public Matiere idMat { get; set; }
        public DateTime dateNotation { get; set; }
        public string critereNotation { get; set; }
        public string Mention { get; set; }

        public Note (Apprenant idApp, Matiere idMat, DateTime dateNotation, string critereNotation, string Mention)
        { 
            this.idApp = idApp;
            this.idMat = idMat;
            this.dateNotation = dateNotation;
            this.critereNotation = critereNotation;
            this.Mention= Mention;
        }
    }
}
