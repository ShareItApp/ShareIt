using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShareIt.Data.Auth.Entities;
using System.Threading.Tasks;

namespace ShareIt.Data.Auth
{
    public class AuthManager : IAuthManager
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<User> userManager;

        public AuthManager(ApplicationDbContext context, UserManager<User> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async Task<bool> CreateUserAsync(User user, string password)
        {
            var result = await this.userManager.CreateAsync(user, password);

            return result.Succeeded;
        }

        public async void SaveChangesAsync()
        {
            await this.context.SaveChangesAsync();
        }
    }
}
