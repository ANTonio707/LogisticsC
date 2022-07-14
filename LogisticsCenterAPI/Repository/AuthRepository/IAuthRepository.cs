using LogisticsCenterMODELS.Models;
using System.Threading.Tasks;

namespace LogisticsCenterAPI.Repository.AuthRepository
{
    public interface IAuthRepository
    {
        //Task<User> Register(User user, string password);
        //Task<User> Login(string Username, string password);
        //Task<bool> ValitedExitenceUser(string UserName);
        Task<User> LoginWithActDirect(string Username, string Password);
    }
}
