using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Models.Identity
{
    public class ApplicationUser:IdentityUser
    {
        public string DisplayName { get; set; }
        public string Country { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public DateTime CreateDate { get; set; }


    }
}
