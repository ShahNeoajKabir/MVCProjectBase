using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalMVC.Models.View_Model
{
    public class TempMessage
    {
        public string UserId { get; set; }
        public long? SessionId { get; set; }
        public string Content { get; set; }
        public int? UserTypeId { get; set; }
    }
}
