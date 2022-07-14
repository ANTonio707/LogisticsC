using LogisticsCenterAPP.Services;
using LogisticsCenterMODELS.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace LogisticsCenterAPP.Pages.InvoicePages.Components
{
    public partial class InvoiceForm
    {

        public Response<InvoiceDTO> WebResponseInvoice;
        [Parameter] public InvoiceDTO InvoiceModel { get; set; } = new InvoiceDTO();
        [Parameter] public string TextBtn { get; set; } = "text";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Parameter] public EventCallback<InputFileChangeEventArgs> OnInputFileChange { get; set; }
        [Parameter] public bool DisableParameter { get; set; }
        [Parameter] public bool activeSppiner { get; set; } = false;
        [Parameter] public bool IsDisabled { get; set; } = true;

        public async Task OutFocus()
        {
            activeSppiner = true;
            WebResponseInvoice = await WebServices.ValitedExistenceInvoice(InvoiceModel);
            if (WebResponseInvoice.IsSuccess == true)
            {
                IsDisabled = false;
                toastService.ShowSuccess(WebResponseInvoice.Message);
                activeSppiner = false;
                this.StateHasChanged();
            }
            else
            {
                IsDisabled = true;
                toastService.ShowWarning(WebResponseInvoice.Message);
                activeSppiner = false;
                this.StateHasChanged();
            }
        }
    }
}
