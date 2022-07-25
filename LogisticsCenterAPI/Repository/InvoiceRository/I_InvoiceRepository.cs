using LogisticsCenterAPI.Models.Pagination;
using LogisticsCenterMODELS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogisticsCenterAPI.Repository.InvoiceRository
{
    public interface I_InvoiceRepository : IRepositoryBase<Invoice>
    {
        Task<LogisticsCenterAPI.Models.Pagination.PagedList<Invoice>> GetInvoices(PaginationParameters paginationParameters);
        public Task<InvoiceDTO> GetById(int Id);
        public Task<Invoice> Create(Invoice invoice);
        public Task<Invoice> Update(Invoice invoice);
        public Invoice GetByNoinvoiceAndSuppler(string No_Invoice, int SupplierId);
        public Task<bool> ValitedExistenceInvoice(Invoice invoice);
        public Task<LogisticsCenterMODELS.Models.PagedList<Invoice>> SearchByAllField(GlobalSearchDTO globalSearchDTO);
        public Task<Invoice> Delete(int Id);
        public Task<Invoice> UpdateStatus(Invoice invoice);
    }
}
