using System.Collections.Generic;

namespace VTMS.Models
{
    public class InstituteModel
    {
        public string InstituteCode { get; set; }

        public string InstituteName { get; set; }

        public int InstituteTypeId { get; set; }

        public string InstituteType { get; set; }

        public string UniversityId { get; set; }

        public string UniversityName { get; set; }

        public string InstituteState { get; set; }

        public string InstituteDistrict { get; set; }

        public List<InstituteModel> ListInstitute { get; set; }

    }
}