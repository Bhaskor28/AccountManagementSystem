﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem.Infrastructure.Identity
{
    public class AppIdentityUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Designation { get; set; }
    }
}
