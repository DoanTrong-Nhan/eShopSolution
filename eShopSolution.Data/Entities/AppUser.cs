﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public DateTime Dob { get; set; }
    }
}
