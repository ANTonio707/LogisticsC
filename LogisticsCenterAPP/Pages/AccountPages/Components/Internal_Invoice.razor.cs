using LogisticsCenterMODELS.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace LogisticsCenterAPP.Pages.AccountPages.Components
{
    public partial class Internal_Invoice
    {
        public Response<InvoiceDTO> WebResponseInvoice;
        public Response<AccountDTO> WebResponseAccount;

        public InvoiceDTO invoice { get; set; } = new();
        public AccountDTO accountDTO { get; set; } = new();
        [Parameter] public int Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            WebResponseInvoice = await WebServices.GetInvoiceByIdWithImgUrl(Id);
            invoice = WebResponseInvoice.Body;
        }
        public async Task Submit() 
        {
            try
            {
                accountDTO.No_Invoice = invoice.No_Invoice;
                accountDTO.Supplier = invoice.Supplier;
                accountDTO.InvoiceSupplierDate = invoice.InvoiceSupplierDate;
                accountDTO.ReceptionDate = invoice.ReceptionDate;
                accountDTO.Reference = invoice.Reference;
                accountDTO.PaymentDescription = invoice.PaymentDescription;
                accountDTO.InvoiceFileRute = invoice.InvoiceFileRute;


                WebResponseAccount = await WebServices.Create(accountDTO);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
