using LogisticsCenterAPI.Data;
using LogisticsCenterAPI.Models.Pagination;
using LogisticsCenterMODELS.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<LogisticsCenterMODELS.Models.PagedList<Account>> Filter(GlobalSearchDTO globalSearchDTO)
        {

            try
            {
                var ValidFilter = new PaginationFilter(globalSearchDTO.PageNumber, globalSearchDTO.PageSize);

                var supp = await _dbContext.Supplier.ToListAsync();
                var FilteredData = _dbContext.Account.Where(x => (globalSearchDTO.No_Invoice == null || x.No_Invoice.Contains(globalSearchDTO.No_Invoice))
                && (globalSearchDTO.Supplier == null || x.Supplier.Name.Contains(globalSearchDTO.Supplier))
                && (globalSearchDTO.PaymentDescription == null || x.PaymentDescription.Contains(globalSearchDTO.PaymentDescription))
                && (globalSearchDTO.Reference == null || x.Reference.Contains(globalSearchDTO.Reference))
                && (globalSearchDTO.No_FRP == null || x.No_FRP.Contains(globalSearchDTO.No_FRP))
                && (globalSearchDTO.No_Internal_Invoice == null || x.No_Internal_Invoice.Contains(globalSearchDTO.No_Internal_Invoice))
                && (globalSearchDTO.CustomerPayment == 0 || x.CustomerPayment == globalSearchDTO.CustomerPayment)
                && (globalSearchDTO.CustomerName == null || x.CustomerName.Contains(globalSearchDTO.CustomerName))
                && (globalSearchDTO.EntranceFee == 0 || x.EntranceFee == globalSearchDTO.EntranceFee)
                && (globalSearchDTO.SupplierPayment == 0 || x.SupplierPayment == globalSearchDTO.SupplierPayment)
                && (globalSearchDTO.CostRate == 0 || x.CostRate == globalSearchDTO.CostRate)
                && (globalSearchDTO.ReceptionDateFrom == null || (x.ReceptionDate > globalSearchDTO.ReceptionDateFrom && x.ReceptionDate < globalSearchDTO.ReceptionDateTo))
                && (globalSearchDTO.SupplierInvoiceDateFrom == null || (x.InvoiceSupplierDate > globalSearchDTO.SupplierInvoiceDateFrom && x.InvoiceSupplierDate < globalSearchDTO.SupplierInvoiceDateTo))
                ).ToList();

                 var pagedData = FilteredData
               .Skip((globalSearchDTO.PageNumber - 1) * globalSearchDTO.PageSize)
                  .Take(globalSearchDTO.PageSize)
                  .ToList();
                var totalRecords = FilteredData.Count();
                var dataa = new LogisticsCenterMODELS.Models.PagedList<Account>(pagedData, totalRecords, globalSearchDTO.PageNumber, globalSearchDTO.PageSize);
                var test = dataa.MetaData;
                return dataa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<Account> GetById(int id) 
        {
            var data = await Task.FromResult(_dbContext.Account.Find(id));
            return data;

        }

    }
}
