using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalMVC.Models
{
    public class Clearence
    {
        [Key]
        public int ClearenceId { get; set; }
        [Display(Name ="Payment Id")]
        public int StudentPaymentId { get; set; }
        [Display(Name = "Student Id")]
        public int StudentId { get; set; }
        [Display(Name = "Fee Type")]
        public short FeeType { get; set; }
        [Display(Name = "Clearence Status")]
        public bool ClearenceStatus { get; set; }
        [Display(Name = "Student Fee Transaction")]
        public int StudentFeeTransactionId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int Status { get; set; }
    }
}
