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
        Task<Response<InvoiceValidDTO>> ValitedExistenceInvoice(InvoiceValidDTO invoiceDTO);
        Task<Response<List<Invoice>>> SearchByAllField(GlobalSearchDTO globalSearchDTO);
        Task<Response<InvoiceDTO>>Delete (int Id);
        Task<Response<InvoiceDTO>> UpdateStatus(InvoiceDTO invoiceDTO);
        
        //Account
        Task<Response<AccountDTO>> CreateAccount(AccountDTO accountDTO);
        Task<Response<List<Account>>> FilterAccount(GlobalSearchDTO GlobalSearchDTO);


        //SUPPLIER
        Task<Response<List<SupplierDTO>>> GetSuppliers();
        Task<Response<SupplierDTO>> CreateSupplier(SupplierDTO supplierDTO);
        Task<Response<SupplierDTO>> UpdateSupplier(SupplierDTO supplierDTO);

        //EXTERNAL_USER
        Task<Response<List<External_UserDTO>>> GetExternalUsers();

        //AUTHENTICATION ACTIVE DIRECTORY USERS 
        Task<Response<UserToken>> LoginWithActiveDirectory(UserLoginDTO user);
        Task<Response<UserLoginDTO>> GetCurrentUser();
        Task<Response<UserLoginDTO>> LogOut();


        //AUTHENTICATION EXTERNAL USERS 
        Task<Response<UserToken>> LoginUserExternal(External_User_LoginDTO external_User_LoginDTO);
        Task<Response<External_UserDTO>> RegisterExternalUser(External_User_RegisterDTO external_User_RegisterDTO);

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
        public async Task<Response<InvoiceValidDTO>> ValitedExistenceInvoice(InvoiceValidDTO invoiceDTO) 
        {
            return await _httpService.Post<Response<InvoiceValidDTO>>($"/api/Invoice/ValitedExistenceInvoice", invoiceDTO);
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
        public async Task<Response<AccountDTO>>CreateAccount(AccountDTO accountDTO)
        {
            return await _httpService.Post<Response<AccountDTO>>($"/api/Account/Create",accountDTO);
        }
        public async Task<Response<List<Account>>> FilterAccount(GlobalSearchDTO globalSearchDTO) 
        {
            return await _httpService.Post<Response<List<Account>>>($"/api/Account/Filter", globalSearchDTO);
        }


        //SUPPLIER
        public async Task<Response<List<SupplierDTO>>> GetSuppliers() 
        {
            return await _httpService.Get<Response<List<SupplierDTO>>>($"/api/Supplier/Get");
        }
        public async Task<Response<SupplierDTO>>CreateSupplier(SupplierDTO supplierDTO)
        {
            return await _httpService.Post<Response<SupplierDTO>>($"/api/Supplier/Create", supplierDTO);
        }
        public async Task<Response<SupplierDTO>> UpdateSupplier(SupplierDTO supplierDTO)
        {
            return await _httpService.Post<Response<SupplierDTO>>($"/api/Supplier/Update", supplierDTO);
        }

        //EXTERNAL_USER

        public async Task<Response<List<External_UserDTO>>> GetExternalUsers() 
        {
            return await _httpService.Get<Response<List<External_UserDTO>>>("/api/ExternalUser/Get");
        }


        //AUTHENTICATION ACTIVE DIRECTORY USERS 
        public async Task<Response<UserToken>> LoginWithActiveDirectory(UserLoginDTO user)
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

        //AUTHENTICATION EXTERNAL USERS 

        public async Task<Response<UserToken>> LoginUserExternal(External_User_LoginDTO external_User_LoginDTO) 
        {
            return await _httpService.Post<Response<UserToken>>($"/api/Auth/LoginUserExternal", external_User_LoginDTO);
        }
        public async Task<Response<External_UserDTO>> RegisterExternalUser(External_User_RegisterDTO external_User_RegisterDTO) 
        {
            return await _httpService.Post<Response<External_UserDTO>>($"/api/Auth/RegisterExternalUser", external_User_RegisterDTO);
        }

    }
}
