using LogisticsCenterMODELS.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticsCenterAPP.Pages.AccountPages
{
    public partial class LstAccounts
    {
        [CascadingParameter]
        private Task<AuthenticationState> authentication { get; set; }

        //WebResponse 
        public Response<List<Account>> WebResponseInvoice;
        public Response<List<Account>> WebResponseInvoice2;
        public Response<InvoiceDTO> WebResponseInvoiceMo;

        public static InvoiceDTO account = new();
        public GlobalSearchDTO globalSearchDTO = new();
        public string Id;

        public bool AdministrationrAccess { get; set; } = false;
        public bool BillersAccess { get; set; } = false;

        public bool SupplierAccess { get; set; } = false;

        public List<Account> ListAccounts = new();
        /*-------------------------------------------------------*/
        public Response<InvoiceDTO> WebResponseInvoices;
        public Response<AccountDTO> WebResponseAccount;
        public InvoiceDTO invoice { get; set; } = new();
        public AccountDTO accountDTO { get; set; } = new();

     
        /*-------------------------------------------------------*/
        //protected override async Task OnInitializedAsync()
        //{
        //    //var APIservices = config.GetSection("APIservices").Value;
        //    //ListInvoices = await http.GetFromJsonAsync<List<Invoice>>($"{APIservices}/api/Invoice");
        //    //await this.GetListInvoice();
        //    //ReturnPage();
        //    //WebResponseInvoice = await WebServices.GetInvoiceByIdWithImgUrl(Id);
        //    //invoice = WebResponseInvoices.Body;
        //}

        private async Task Filter() 
        {
            CurrentPage = 1;
            await LoadData();
        }

        public async Task LoadData()
        {

            globalSearchDTO.PageNumber = CurrentPage;
            WebResponseInvoice = await WebServices.FilterAccount(globalSearchDTO);
            TotalPages = WebResponseInvoice.MetaData.TotalPages;
            ListAccounts = WebResponseInvoice.Body;
            StateHasChanged();
        }

        public void Clear()
        {
            //WebResponseInvoice2 = await WebServices.GetInvoices(globalSearchDTO);
            //ListInvoices = WebResponseInvoice2.Body;
            ListAccounts = new();
            CurrentPage = 1;
            globalSearchDTO.No_Invoice = string.Empty;
            globalSearchDTO.Supplier = string.Empty;
            globalSearchDTO.Reference = string.Empty;
            globalSearchDTO.PaymentDescription = string.Empty;
            StateHasChanged();
        }
        //cheack
        public async Task DetailsInvoice(int Id)
        {
            WebResponseInvoiceMo = await WebServices.GetInvoiceByIdWithImgUrl(Id);
            //HandleFileSelection(WebResponseInvoiceMo.Body.FileContent, WebResponseInvoiceMo.Body.InvoiceFileRute);
            account = WebResponseInvoiceMo.Body;
        }



        public void ReturnPage()
        {
            navigationManager.NavigateTo("/Accounts");
        }
    }
}
