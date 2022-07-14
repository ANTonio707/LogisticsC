using AutoMapper;
using LogisticsCenterAPI.Data;
using LogisticsCenterAPI.Models.Pagination;
using LogisticsCenterMODELS.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticsCenterAPI.Repository.InvoiceRository
{
    public class InvoiceRepository : RepositoryBase<Invoice>, I_InvoiceRepository
    {
        ApplicationDbContext _dbContext;
        private readonly ILogger<InvoiceRepository> _logger;
        private UTLS utls;
        IMapper mapper;
        public InvoiceRepository(ApplicationDbContext repositoryContext, ILogger<InvoiceRepository> logger, UTLS utls, IMapper mapper)
            : base(repositoryContext)
        {
            _logger = logger;
            _dbContext = repositoryContext;
            this.utls = utls;
            this.mapper = mapper;
        }


        public Task<LogisticsCenterAPI.Models.Pagination.PagedList<Invoice>> GetInvoices(PaginationParameters paginationParameters)
        {
            try
            {
                var data = Task.FromResult(LogisticsCenterAPI.Models.Pagination.PagedList<Invoice>.GetPageList(FindAll().OrderBy(t => t.InvoiceId), paginationParameters.PageNumber, paginationParameters.PageSize));
                return data;
            }
            catch (Exception ex)
            {
                _logger.LogError("function---> GetTaxpayers   :  class---->TaxpayerRepository", ex);
                return default;
            }
        }
        public async Task<InvoiceDTO> GetById(int Id)
        {
                var info = await Task.FromResult(_dbContext.Invoice.Where(x => x.InvoiceId == Id).FirstOrDefault());
                var obj =  mapper.Map<InvoiceDTO>(info);
            if (obj.InvoiceFileRute != null)
            {
                obj.FileName = GetFileName(obj.InvoiceFileRute);
                obj.FileContent = ConvertImageToByteStringFromImagePath(obj.InvoiceFileRute);  
            }
                
                  
                return obj;
        }
        public async Task<Invoice> Create(Invoice invoice)
        {
                var obj = await _dbContext.Invoice.AddAsync(invoice);
                _dbContext.SaveChanges();
                return obj.Entity;
        }
        public async Task<Invoice> Update (Invoice invoice) 
        {
            try
            {
               var oldInvice = _dbContext.Invoice.FirstOrDefault(i => i.InvoiceId == invoice.InvoiceId);
                _dbContext.Entry(oldInvice).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                var obj =  _dbContext.Entry(invoice).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return invoice;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Invoice GetByNoinvoiceAndSuppler(string No_Invoice, string Supplier)
        {
            try
            {    
              var obj =  _dbContext.Invoice.Where(f => f.No_Invoice == No_Invoice && f.Supplier == Supplier).FirstOrDefault();
                return obj;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex}");
                return default;
            }
        }

        public async Task<bool> ValitedExistenceInvoice(Invoice invoice)
        {
                var obj = await Task.FromResult(_dbContext.Invoice.FirstOrDefault(f => f.No_Invoice == invoice.No_Invoice && f.Supplier == invoice.Supplier));
                if (obj != null)
                {
                    return true;
                }
                return false;
        }
        public async Task<List<Invoice>> SearchByAllField(string invoiceField)
        {
            var obj = await Task.FromResult(_dbContext.Invoice.Where(s => s.No_Invoice == invoiceField || s.Supplier == invoiceField || s.PaymentDescription == invoiceField || s.Reference == invoiceField).ToList());
            return obj;
        }
        public async Task<List<Invoice>> SearchByAllField(GlobalSearchDTO globalSearchDTO)
        {
            List<Invoice> LstInvoices = new List<Invoice>();
            var SentList = new List<Invoice>();
            LstInvoices = _dbContext.Invoice.ToList();


            if (globalSearchDTO.No_Invoice != null )
            {
                var no_invoice = globalSearchDTO.No_Invoice.Trim().ToUpper();
                LstInvoices = await Task.FromResult(LstInvoices.Where(s => s.No_Invoice == no_invoice).ToList());
            }
            if (globalSearchDTO.Supplier != null)
            {
                var supplier = globalSearchDTO.Supplier.Trim().ToUpper();
                LstInvoices = await Task.FromResult(LstInvoices.Where(s => s.Supplier == supplier).ToList());
            }
            if (globalSearchDTO.Reference != null )
            {
                var reference = globalSearchDTO.Reference.Trim().ToUpper();
                LstInvoices = await Task.FromResult(LstInvoices.Where(s => s.Reference == reference).ToList());
            }
            if (globalSearchDTO.PaymentDescription != null)
            {
                var paymentDescription = globalSearchDTO.PaymentDescription.Trim().ToUpper();
                LstInvoices = await Task.FromResult(LstInvoices.Where(s => s.PaymentDescription == paymentDescription).ToList());
            }
            if (globalSearchDTO.DateFrom != null)
            {
                LstInvoices = await Task.FromResult(LstInvoices.Where(s => s.InvoiceSupplierDate >= globalSearchDTO.DateFrom).ToList());
            }
            if (globalSearchDTO.DateTo != null)
            {
                LstInvoices = await Task.FromResult(LstInvoices.Where(s => s.InvoiceSupplierDate <= globalSearchDTO.DateTo).ToList());
            }
            return LstInvoices;
        }

        public async Task<Invoice> Delete(int Id) {
            var obj = await Task.FromResult(_dbContext.Invoice.Find(Id));
            _dbContext.Invoice.Remove(obj);
            _dbContext.SaveChanges();
            return obj;
        }

        public async Task<Invoice> UpdateStatus(Invoice invoice)
        {
            var OldInvoice = _dbContext.Invoice.Where(s=> s.InvoiceId == invoice.InvoiceId).FirstOrDefault();
            _dbContext.Entry(OldInvoice).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            _dbContext.Entry(invoice).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return invoice;

        }
        public static byte[] ConvertImageToByteStringFromImagePath(string imagePath)
        {
           

                byte[] FileByte = System.IO.File.ReadAllBytes(imagePath);
                return FileByte;
        }
        public string GetFileName(string FilePath) 
        {
            string[] path = FilePath.Split('/');
            string name = path[path.Length - 1];
            string[]FileArr = name.Split('.');
            string FileName = FileArr[0];
            return FileName;
        }

       
    }
}
