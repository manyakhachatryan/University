using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entities
{
    public class Professor
    {
        public int? ProfessorID { get; set; }
        public string? ProfessorFirstName { get; set; }
        public string? ProfessorLastName { get; set; }
        public int? ProfessorUniversityID { get; set; }
        public int? ProfessorSubjectID { get; set; }
        public Professor() { }

        public Professor(int? id=null, string? firstName = null, string? lastName = null, int? uID = null, int? sID = null)
        {
            ProfessorID = id;
            ProfessorFirstName = firstName;
            ProfessorLastName = lastName;
            ProfessorUniversityID = uID;
            ProfessorSubjectID = sID;   
        }


    }
}
