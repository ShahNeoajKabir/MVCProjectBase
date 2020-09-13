using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalMVC.Models
{
    public class UserMapping
    {
        [Key]
        public int UserMappingId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public int IdentityId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int Status { get; set; }

        public virtual User User { get; set; }
    }
}
