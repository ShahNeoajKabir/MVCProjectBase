using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalMVC.Models
{
    public class StudentPayment
    {
        [Key]
        public int StudentPaymentId { get; set; }
        [ForeignKey("Student")]
        [Display(Name ="Student Id")]
        public int StudentId { get; set; }
        public int StudentFeeTransactionId { get; set; }
        public decimal Amount { get; set; }
        public int SemesterId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int Status { get; set; }

        public virtual Student Student { get; set; }
    }
}
