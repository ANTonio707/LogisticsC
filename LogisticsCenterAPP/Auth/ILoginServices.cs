using System.Threading.Tasks;

namespace LogisticsCenterAPP.Auth
{
    public interface ILoginServices
    {
        Task Login(string token);
        Task Logout();
    }
}
