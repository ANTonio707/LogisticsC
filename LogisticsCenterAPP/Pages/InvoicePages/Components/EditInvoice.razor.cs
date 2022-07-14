using LogisticsCenterMODELS.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace LogisticsCenterAPP.Pages.InvoicePages.Components
{
    public partial class EditInvoice
    {
 

        public Response<InvoiceDTO> WebResponseInvoice;
        //public GlobalSearchDTO globalSearchDTO = new();
        
        public InvoiceDTO invoiceDTO { get; set; } = new();
        public bool IsDisabled { get; set; } = false;
        [Parameter] public int Id { get; set; }

        public bool activeFields = false;
        IReadOnlyList<IBrowserFile> selectedFiles;

        protected override async Task OnParametersSetAsync()
        {
            WebResponseInvoice = await WebServices.GetInvoiceById(Id);
            invoiceDTO = WebResponseInvoice.Body;
        }
        private void OnInputFileChange
            (InputFileChangeEventArgs e)
        {
            selectedFiles = e.GetMultipleFiles();
            this.StateHasChanged();
        }
        public async Task Submit()
        {
            try
            {
                if (selectedFiles != null)
                {

                    foreach (var file in selectedFiles)
                    {
                        Stream stream = file.OpenReadStream();
                        MemoryStream ms = new MemoryStream();
                        await stream.CopyToAsync(ms);
                        stream.Close();

                        invoiceDTO.FileName = file.Name;
                        invoiceDTO.FileContent = ms.ToArray();
                        ms.Close();
                    }
                }
                WebResponseInvoice = await WebServices.Update(invoiceDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (WebResponseInvoice.StatusCode == "OK")
            {
                toastService.ShowSuccess(WebResponseInvoice.Message);
                //Message = $"{selectedFiles.Count} file(s) uploaded on server";
                this.StateHasChanged();
                NavigationManager.NavigateTo("/Invoices");
            }
            else if (WebResponseInvoice.StatusCode == "DATA_INVALID")
            {
                toastService.ShowWarning(WebResponseInvoice.Message);
                this.StateHasChanged();
            }
        }

    }
}
