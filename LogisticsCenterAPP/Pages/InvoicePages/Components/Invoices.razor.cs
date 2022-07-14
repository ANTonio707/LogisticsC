using BlazorInputFile;
using LogisticsCenterMODELS.Models;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LogisticsCenterAPP.Pages.InvoicePages.Components
{
    public partial class Invoices
    {
        //WebResponse 
        public Response<List<Invoice>> WebResponseInvoice;
        public Response<List<Invoice>> WebResponseInvoice2;
        public Response<InvoiceDTO> WebResponseInvoiceMo;

        public static InvoiceDTO invoice = new();
        public GlobalSearchDTO globalSearchDTO = new();
        public string Id;


        public List<Invoice> ListInvoices = new();
        protected override async Task OnInitializedAsync()
        {
            //var APIservices = config.GetSection("APIservices").Value;
            //ListInvoices = await http.GetFromJsonAsync<List<Invoice>>($"{APIservices}/api/Invoice");
            await this.GetListInvoice();
            ReturnPage();
        }


        private async Task GetListInvoice()
        {
            try
            {
                WebResponseInvoice = await WebServices.GetInvoices(globalSearchDTO);
                if (WebResponseInvoice != null)
                {
                    if (WebResponseInvoice.StatusCode == "OK")
                    {
                        ListInvoices = WebResponseInvoice.Body;
                        StateHasChanged();
                    }
                }
                else
                {
                    await OnInitializedAsync();
                    StateHasChanged();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task Search()
        {
            WebResponseInvoice = await WebServices.SearchByAllField(globalSearchDTO);
            ListInvoices = WebResponseInvoice.Body;
            StateHasChanged();
        }

        public async Task Clear()
        {
            WebResponseInvoice2 = await WebServices.GetInvoices(globalSearchDTO);
            ListInvoices = WebResponseInvoice2.Body;
            globalSearchDTO.No_Invoice = null;
            globalSearchDTO.Supplier = null;
            globalSearchDTO.Reference = null;
            globalSearchDTO.PaymentDescription = null;
            StateHasChanged();
        }
        //cheack
        public async Task DetailsInvoice(int Id)
        {
            WebResponseInvoiceMo = await WebServices.GetInvoiceByIdWithImgUrl(Id);
            HandleFileSelection(WebResponseInvoiceMo.Body.FileContent, WebResponseInvoiceMo.Body.InvoiceFileRute);
            invoice = WebResponseInvoiceMo.Body;
        }

        public void HandleFileSelection(byte[] file, string FileName)
        {
            string[] NameAndType = FileName.Split('.');
            //ImgSrc = string.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(picture));
            if (NameAndType[1] == "pdf")
            {
                FileBase64Src = $"data:application/pdf;base64,{Convert.ToBase64String(file)}";
            }
            else
            {
                FileBase64Src = $"data:image/png;base64,{Convert.ToBase64String(file)}";
            }
        }
       
        //public async Task DownloadFilePicture(int Id)
        //{
        //    WebResponseInvoiceMo = await WebServices.GetInvoiceByIdWithImgUrl(Id);
        //    ImgSrc = $"data:image/png;base64,{Convert.ToBase64String(WebResponseInvoiceMo.Body.FileContent)}";
        //    string[] base64string = ImgSrc.Split(',');
        //    await js.InvokeVoidAsync("downloadFile", "image/png", base64string[1], "test.png");
        //}

        public async Task Delete(int Id) 
        {
            idAndClass = $"#ident-{Id}.active";
            ActiveClass = "active";
            WebResponseInvoiceMo = await WebServices.Delete(Id);
            Thread.Sleep(2000);
            await OnInitializedAsync();
            StateHasChanged();

        }
        public void ReturnPage()
        {
            navigationManager.NavigateTo("/Invoices");
        }
    }
}
