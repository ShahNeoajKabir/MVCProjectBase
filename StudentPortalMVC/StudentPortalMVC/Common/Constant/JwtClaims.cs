using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalMVC.Common.Constant
{
    public class JwtClaims
    {
        public const string UserId = "UserId";
        public const string UserName = "UserName";
        public const string Name = "Name";
        public const string Email = "Email";
        public const string ExpiresDate = "ExpiresDate";
        public const string AccessRight = "user_type";
        public const string UniqueName = "unique_name";
    }
}
