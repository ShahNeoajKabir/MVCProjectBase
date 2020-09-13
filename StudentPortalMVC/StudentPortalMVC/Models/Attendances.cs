using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalMVC.Models
{
    public class Attendances
    {
        [Key]
        public int AttendanceId { get; set; }
        [ForeignKey("Course")]
        [Display(Name ="Course Id")]
        public int CourseId { get; set; }
        [Display(Name ="Teacher Id")]
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        [Display(Name ="Student Id")]
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [Display(Name ="Attendace")]
        public bool Attendance { get; set; }
        public DateTime AttendanceDate { get; set; }
        public int SemesterId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int Status { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
