using LogisticsCenterMODELS.Models;
using System.Threading.Tasks;

namespace LogisticsCenterAPI.Repository.AccountRepository
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        public Task<Account> Create(Account account);

    }
}
