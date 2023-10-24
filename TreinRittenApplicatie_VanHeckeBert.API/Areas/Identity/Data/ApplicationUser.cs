﻿using Microsoft.AspNetCore.Identity;

namespace TreinRittenApplicatie_VanHeckeBert.API.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }

        [PersonalData]
        public string LastName { get; set; }
    }
}
