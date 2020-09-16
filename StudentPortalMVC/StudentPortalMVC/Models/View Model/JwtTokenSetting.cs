using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalMVC.Models.View_Model
{
    public class JwtTokenSetting
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string ExpiresOn { get; set; }
    }
}
