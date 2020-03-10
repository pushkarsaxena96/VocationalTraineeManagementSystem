using System.Collections.Generic;

namespace VTMS.Models
{
    public class InstituteTypeModel
    {
        public int InstTypeId { get; set; }

        public string InstiType { get; set; }

        public List<InstituteTypeModel> ListInstituteTypes { get; set; }
        
    }
}