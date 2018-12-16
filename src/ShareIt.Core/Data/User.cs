using Microsoft.AspNetCore.Identity;

namespace ShareIt.Core.Data
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
