using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShareIt.Auth.Entities;

namespace ShareIt.Auth
{
    public class AuthDbContext : IdentityDbContext<User>
    {
        public AuthDbContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
