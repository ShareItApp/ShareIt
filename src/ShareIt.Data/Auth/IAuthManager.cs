using ShareIt.Data.Auth.Entities;
using System.Threading.Tasks;

namespace ShareIt.Data.Auth
{
    public interface IAuthManager
    {
        Task<bool> CreateUserAsync(User user, string password);

        void SaveChangesAsync();
    }
}
