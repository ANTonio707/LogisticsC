using LogisticsCenterAPI.Data;
using LogisticsCenterAPI.Models.Pagination;
using LogisticsCenterMODELS.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticsCenterAPI.Repository.AccountRepository
{
    public class AccountRepository :  RepositoryBase<Account>, IAccountRepository
    {
        ApplicationDbContext _dbContext;
        private readonly ILogger<AccountRepository> _logger;

        public AccountRepository(ApplicationDbContext repositoryContext, ILogger<AccountRepository> logger)
            : base(repositoryContext)
        {
            _logger = logger;
            _dbContext = repositoryContext;
        }
        public Task<LogisticsCenterAPI.Models.Pagination.PagedList<Account>> GetInvoices(PaginationParameters paginationParameters)
        {
            try
            {
                var data = Task.FromResult(LogisticsCenterAPI.Models.Pagination.PagedList<Account>.GetPageList(FindAll().OrderBy(t => t.Id), paginationParameters.PageNumber, paginationParameters.PageSize));
                return data;
            }
            catch (Exception ex)
            {
                _logger.LogError("function---> GetTaxpayers   :  class---->TaxpayerRepository", ex);
                return default;
            }
        }
        public async Task<Account> Create(Account account)
        {
            var obj = await _dbContext.Account.AddAsync(account);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

    }
}
