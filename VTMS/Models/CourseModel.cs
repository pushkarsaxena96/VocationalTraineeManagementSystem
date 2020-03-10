using System.Collections.Generic;
using System.ComponentModel;

namespace VTMS.Models
{
    public class CourseModel
    {

        public string CourseId { get; set; }

        public string CourseName { get; set; }

        [DisplayName("Course Description")]
        public string CourseDesc { get; set; }

        public List<CourseModel> ListCourse { get; set; }
    }
}