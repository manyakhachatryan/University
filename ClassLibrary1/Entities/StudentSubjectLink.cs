using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entities
{
    public class StudentSubjectLink
    {
        public int? sslID { get; set; }
        public int? sslStudentID { get; set; }
        public int? sslSubjectID { get; set; }
        public StudentSubjectLink() { }
        public StudentSubjectLink(int? id=null, int? studentID = null, int? subjectID = null)
        {
            sslID = id;
            sslStudentID = studentID;
            sslSubjectID = subjectID;
        }


    }
}
