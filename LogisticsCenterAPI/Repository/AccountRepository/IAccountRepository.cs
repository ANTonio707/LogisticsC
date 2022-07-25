using LogisticsCenterAPI.Models.Pagination;
using LogisticsCenterMODELS.Models;
using System.Threading.Tasks;

namespace LogisticsCenterAPI.Repository.AccountRepository
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        public Task<Account> Create(Account account);
        public Task<LogisticsCenterMODELS.Models.PagedList<Account>> Filter(GlobalSearchDTO globalSearchDTO);
        public Task<Account> GetById(int Id);

    }
}
