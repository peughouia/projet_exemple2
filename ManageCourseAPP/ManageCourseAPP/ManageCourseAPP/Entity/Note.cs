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
        public Apprenant idApp;
        public Matiere idMat;
        public DateTime dateNotation;
        public string critereNotation;
        public string Mention;

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
