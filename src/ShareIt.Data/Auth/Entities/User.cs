﻿using Microsoft.AspNetCore.Identity;

namespace ShareIt.Data.Auth.Entities
{
    public sealed class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
