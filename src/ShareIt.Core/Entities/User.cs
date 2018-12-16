using Microsoft.AspNetCore.Identity;

namespace ShareIt.Core.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
