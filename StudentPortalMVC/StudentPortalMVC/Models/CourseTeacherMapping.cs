using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalMVC.Models
{
    public class CourseTeacherMapping
    {
        [Key]
        public int CourseTeacherMappingId { get; set; }
        [ForeignKey("Course")]
        [Display(Name ="Course Id")]
        public int CourseId { get; set; }
        [ForeignKey("Teacher")]
        [Display(Name = "Teacher Id")]
        public int TeacherId { get; set; }
        [ForeignKey("Semester")]
        [Display(Name = "Semester Id")]
        public int SemesterId { get; set; }
        [Display(Name ="Section Id")]
        public int SectionId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int Status { get; set; }

        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Semester Semester { get; set; }

        public ICollection<Marks> Marks { get; set; }

    }
}
