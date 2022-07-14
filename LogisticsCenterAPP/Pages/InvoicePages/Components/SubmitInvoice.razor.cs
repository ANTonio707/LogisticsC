using LogisticsCenterAPP.Services;
using LogisticsCenterMODELS.Models;
using LogisticsCenterMODELS.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace LogisticsCenterAPP.Pages.InvoicePages.Components
{
    public  partial class SubmitInvoice
    {
       // [Inject]
       // public IWebServices WebServices { get; set; }
        public List<InvoiceDTO> ListInvoices = new List<InvoiceDTO>();

        public Response<InvoiceDTO> WebResponseInvoice;
        //public GlobalSearchDTO globalSearchDTO = new();
        public InvoiceDTO invoiceDTO { get; set; } = new();

        protected bool IsDisabled { get; set; } = false;
        public bool activeSpplier { get; set; } = false;

         
        private void OnInputFileChange
       (InputFileChangeEventArgs et)
        {
            selectedFiles = et.GetMultipleFiles();
            Message = $"{selectedFiles.Count} file(s) selected";
            this.StateHasChanged();
        }

        public async Task Submit()
        {
            try
            {
                IsDisabled = true;
                activeSpplier = true;
                invoiceDTO.ReceptionDate = DateTime.Now;
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
                WebResponseInvoice = await WebServices.AddInvoice(invoiceDTO);
            }
            catch (Exception ex )
            {
                throw ex;
            }
            if (WebResponseInvoice.StatusCode == "OK")
            {
                toastService.ShowSuccess("Saved!!");
                this.StateHasChanged();
                NavigationManager.NavigateTo("/Invoices");
            }
            else if(WebResponseInvoice.StatusCode == "DATA_INVALID")
            {
                toastService.ShowWarning(WebResponseInvoice.Message);
                this.StateHasChanged();
            }
             
        }
    }
}
