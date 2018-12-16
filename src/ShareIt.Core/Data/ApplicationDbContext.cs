using Microsoft.EntityFrameworkCore;
using ShareIt.Auth;

namespace ShareIt.Core.Data
{
    public class ApplicationDbContext : AuthDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
