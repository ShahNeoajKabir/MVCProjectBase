using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalMVC.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Display(Name ="Course Code")]
        public string CourseCode { get; set; }
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }
        [Display(Name = "Course Creadit")]
        public short CourseCredit { get; set; }
        [Display(Name = "Course Fee")]
        public decimal CourseFee { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int Status { get; set; }
        public ICollection<CourseTeacherMapping> CourseTeacherMapping { get; set; }

        public ICollection<StudentRegistration> StudentRegistration { get; set; }
        public ICollection<Attendances> Attendances { get; set; }

    }
}
