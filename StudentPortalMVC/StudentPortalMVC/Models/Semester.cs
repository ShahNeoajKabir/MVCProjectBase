using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalMVC.Models
{
    public class Semester
    {
        [Key]
        public int SemesterId { get; set; }
        [Display(Name ="Semester Name")]
        public string SemesterName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int Status { get; set; }

        public ICollection<CourseTeacherMapping> CourseTeacherMapping { get; set; }
        public ICollection<Marks> Marks { get; set; }
    }
}
