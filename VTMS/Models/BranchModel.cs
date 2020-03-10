using System.Collections.Generic;

namespace VTMS.Models
{
    public class BranchModel
    {
        public string BranchCode { get; set; }


        public string BranchName { get; set; }

        public string BranchShortDesc { get; set; }

        public string CourseId { get; set; }

        public string CourseName { get; set; }

        public string Created_By { get; set; }

        public List<BranchModel> ListBranch { get; set; }

    }
}