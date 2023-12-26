using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entities
{
    public class Subject
    {
        public int? SubjectID { get; set; }
        public string? SubjectName { get; set; }
        public Subject() { }
        public Subject(int? id=null, string? name=null)
        {
            SubjectID = id;
            SubjectName = name;
        }


    }
}
