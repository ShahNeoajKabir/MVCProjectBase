using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalMVC.Models
{
    public class Routine
    {
        [Key]
        public int RoutineId { get; set; }
        [Display(Name ="Course Code")]
        public string CourseCode { get; set; }
        [Display(Name ="Semester Name")]
        public int SemesterId { get; set; }
        public short Day { get; set; }
        public short Slot { get; set; }
        public string TeacherInitial { get; set; }
        public int TeacherId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int Status { get; set; }
    }
}
