using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entities
{
    public class University
    {
        public int? UniversityID { get; set; }
        public string? UniversityName { get; set; }
        public string? UniversityCountry { get; set; }
        public string? UniversityCity { get; set; }
        public University() { }
        public University(int? id=null, string? name = null, string? country = null, string? city = null)
        {
            UniversityID = id;
            UniversityName = name;
            UniversityCountry = country;
            UniversityCity = city;  
        }

    }
}
