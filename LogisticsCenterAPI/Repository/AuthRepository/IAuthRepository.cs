using LogisticsCenterMODELS.Models;
using System.Threading.Tasks;

namespace LogisticsCenterAPI.Repository.AuthRepository
{
    public interface IAuthRepository
    {
        Task<External_User> RegisterExternalUser(External_User user, string password);
        Task<External_User> LoginExternalUser(string Username, string password);
        Task<bool> ValitedExitenceUser(string UserName);
        Task<User> LoginWithActDirect(string Username, string Password);
    }
}
