using System.ComponentModel.DataAnnotations;

namespace VTMS.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage = "Enter Personal Number")]
        public string PERSONAL_NO { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        public string PASSWORD { get; set; }

        public string NAME { get; set; }

        public string DESIGNATION { get; set; }

        public string SECTION { get; set; }

        public string GRADE_CODE { get; set; }

        public string UNIT_NAME { get; set; }

        public string UNIT_CODE { get; set; }

    }
}