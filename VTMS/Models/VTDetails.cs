using System;
using System.Collections.Generic;

namespace VTMS.Models
{
    public class VTDetails
    {
        //Basic Information
        
        public string VTCode { get; set; }

        public string VTName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string FatherName { get; set; }

        public int ContactNo { get; set; }

        public int AltContactNo { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Pincode { get; set; }

        public string Email { get; set; }

        public string VTStartDate { get; set; }

        public string VTEndDate { get; set; }

        //Academic Qualification

        public string CourseId { get; set; }

        public string Batch { get; set; }

        public int SemesterId { get; set; }

        public string BranchId { get; set; }

        public string InstituteId { get; set; }

        public string UniversityId { get; set; }

        //Medical Ftness

        public string DoctorName { get; set; }

        public int RegistrationNo { get; set; }

        public string FitnessRemarks { get; set; }

        //Recommendation

        public int RecommendationTypeId { get; set; }

        public int RecomIFFCOPNo { get; set; }

        public string RecomOthersId { get; set; }



        //Lists
        public List<VTDetails> ListActive { get; set; }

        public List<VTDetails> ListEnrolled { get; set; }

        public List<BranchModel> Branch { get; set; }

        public List<CourseModel> Course { get; set; }

        public List<InstituteModel> Institute { get; set; }

        public List<UniversityModel> Universiy { get; set; }

        public string InstituteName { get; set; }

        public string CourseName { get; set; }

        public string BranchName { get; set; }

        public string UniversityName { get; set; }



    }
}