using System.Collections.Generic;

namespace VTMS.Models
{
    public class UniversityModel
    {
        public string UniversityCode { get; set; }

        public string UniversityName { get; set; }

        public string UniversityArea { get; set; }

        public List<UniversityModel> ListUniversity { get; set; }
    }
}