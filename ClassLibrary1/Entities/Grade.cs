using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entities
{
    public  class Grade
    {
        public int? GradeID { get; set; }
        public int? GradeStudentID { get; set; }
        public int? GradeSubjectID { get; set; }
        public int? GradeGrade { get; set; }

        public Grade() { }

        public Grade(int? id = null, int? studentId = null, int? subjectId = null, int? grade = null)
        {
            GradeID = id;
            GradeStudentID = studentId; 
            GradeSubjectID = subjectId;     
            GradeGrade = grade;
        }

    }
}
