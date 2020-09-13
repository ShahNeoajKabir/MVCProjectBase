using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalMVC.Models
{
    public class Marks
    {
        [Key]
        public int MarksId { get; set; }
        [Display(Name ="Marks")]
        public decimal Mark { get; set; }
        [ForeignKey("CourseTeacherMapping")]
        [Display(Name ="Course Teacher Mapping")]
        public int CourseTeacherMappingId { get; set; }
        [ForeignKey("Student")]
        [Display(Name ="Student Id")]
        public int StudentId { get; set; }
        [Display(Name ="Marks Type")]
        public short MarksType { get; set; }
        [ForeignKey("Semester")]
        [Display(Name ="Semester Id")]
        public int SemesterId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int Status { get; set; }

        public virtual Student Student { get; set; }
        public virtual CourseTeacherMapping CourseTeacherMapping { get; set; }
        public virtual Semester Semester { get; set; }

    }
}
