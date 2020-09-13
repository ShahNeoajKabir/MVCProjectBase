using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalMVC.Models
{
    public class Parents
    {
        [Key]
        public int ParentsId { get; set; }
        [ForeignKey("Student")]
        [Display(Name ="Student Id")]
        public int StudentId { get; set; }
        [Display(Name ="Parents Name")]
        public string ParentsName { get; set; }
        [EmailAddress(ErrorMessage ="Email Id Required")]
        [Display(Name ="Email")]
        public string Email { get; set; }
        [Phone]
        [Display(Name ="Mobile No")]
        public string MobileNo { get; set; }
        [Display(Name = "Blood Group")]

        public string BloodGroup { get; set; }
        [Display(Name = "Address")]

        public string Address { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int Status { get; set; }
        public string Image { get; set; }
        public Student Student { get; set; }
    }
}
