using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class AppUser : IdentityUser<int>
    {
        public string AppUserName { get; set; }
        public string AppUserSurName { get; set; }

        public string Gender { get; set; }

    }
}
