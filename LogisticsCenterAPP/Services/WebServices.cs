using LogisticsCenterMODELS.Models;
using LogisticsCenterMODELS.Models.DTOModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogisticsCenterAPP.Services
{
    public interface IWebServices
    {
        Task<Response<List<Invoice>>> GetInvoices(GlobalSearchDTO globalSearchDTO);
        Task<Response<InvoiceDTO>>AddInvoice(InvoiceDTO invoiceDTO);
        Task<Response<InvoiceDTO>> GetInvoiceById(int id);
        Task<Response<InvoiceDTO>> GetInvoiceByIdWithImgUrl(int id);
        Task<Response<InvoiceDTO>> Update(InvoiceDTO invoiceDTO);
        Task<Response<InvoiceDTO>> ValitedExistenceInvoice(InvoiceDTO invoiceDTO);
        Task<Response<List<Invoice>>> SearchByAllField(GlobalSearchDTO globalSearchDTO);
        Task<Response<InvoiceDTO>>Delete (int Id);
        Task<Response<InvoiceDTO>> UpdateStatus(InvoiceDTO invoiceDTO);
        

        //Account
        Task<Response<AccountDTO>> Create(AccountDTO accountDTO);

        //Login

        Task<Response<UserToken>>LoginWithActiveDirectory(UserLoginDTO user);

        Task<Response<UserLoginDTO>> GetCurrentUser();
        Task<Response<UserLoginDTO>> LogOut();

        
    }
    public class WebServices : IWebServices
    {
        private IHttpService _httpService;
        private ILocalStorageService _localStorageService;

        public WebServices(
            IHttpService httpService,
            ILocalStorageService localStorageService
        )
        {
            _httpService = httpService;
            _localStorageService = localStorageService;
        }
        public async Task<Response<List<Invoice>>> GetInvoices(GlobalSearchDTO globalSearchDTO) 
        {
            return await _httpService.Post<Response<List<Invoice>>>($"/api/Invoice/GetAllInvoices", globalSearchDTO);
        }
        public async Task<Response<InvoiceDTO>> AddInvoice(InvoiceDTO invoiceDTO)
        {
            return await _httpService.Post<Response<InvoiceDTO>>($"/api/Invoice/AddInvoice", invoiceDTO);
        }
        public async Task<Response<InvoiceDTO>> GetInvoiceById(int id)
        {
            return await _httpService.Post<Response<InvoiceDTO>>($"/api/Invoice/GetInvoiceById", id);
        }
        public async Task<Response<InvoiceDTO>> GetInvoiceByIdWithImgUrl(int id) 
        {
            return await _httpService.Post<Response<InvoiceDTO>>($"/api/Invoice/GetInvoiceById", id);
        }
        public async Task<Response<InvoiceDTO>> Update(InvoiceDTO invoiceDTO)
        {
            return await _httpService.Put<Response<InvoiceDTO>>($"/api/Invoice/Update", invoiceDTO);
        }
        public async Task<Response<InvoiceDTO>> ValitedExistenceInvoice(InvoiceDTO invoiceDTO) 
        {
            return await _httpService.Post<Response<InvoiceDTO>>($"/api/Invoice/ValitedExistenceInvoice", invoiceDTO);
        }
        public async Task<Response<List<Invoice>>> SearchByAllField(GlobalSearchDTO globalSearchDTO)
        {
            return await _httpService.Post<Response<List<Invoice>>>($"/api/Invoice/Filter", globalSearchDTO);
        }
        public async Task<Response<InvoiceDTO>> Delete(int Id)
        {
            return await _httpService.Post<Response<InvoiceDTO>>($"/api/Invoice/Delete", Id);
        }
        public async Task<Response<InvoiceDTO>> UpdateStatus(InvoiceDTO invoiceDTO)
        {
            return await _httpService.Put<Response<InvoiceDTO>>($"/api/Invoice/UpdateStatus",invoiceDTO);
        } 

        //Account
        public async Task<Response<AccountDTO>>Create(AccountDTO accountDTO)
        {
            return await _httpService.Post<Response<AccountDTO>>($"/api/Account/Create",accountDTO);
        }

        //Login
        public async Task<Response<UserToken>>LoginWithActiveDirectory(UserLoginDTO user)
        {
            return await _httpService.Post<Response<UserToken>>($"/api/Auth/Login", user);
        }

        public async Task<Response<UserLoginDTO>> GetCurrentUser() 
        {
            return await _httpService.Get<Response<UserLoginDTO>>($"/api/Auth/GetCurrentUser");
        }   
        public async Task<Response<UserLoginDTO>> LogOut() 
        {
            return await _httpService.Get<Response<UserLoginDTO>>($"/api/Auth/Logout");
        }
    }
}
