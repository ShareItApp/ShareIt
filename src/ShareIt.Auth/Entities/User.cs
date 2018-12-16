using Microsoft.AspNetCore.Identity;

namespace ShareIt.Auth.Entities
{
    public sealed class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
