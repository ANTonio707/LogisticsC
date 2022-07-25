using BlazorInputFile;
using LogisticsCenterMODELS.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
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

        [CascadingParameter]
        private Task<AuthenticationState> authentication { get; set; }

        //WebResponse 
        public Response<List<Invoice>> WebResponseInvoice;
        public Response<List<Invoice>> WebResponseInvoice2;
        public Response<InvoiceDTO> WebResponseInvoiceMo;

        public static InvoiceDTO invoice = new();
        public GlobalSearchDTO globalSearchDTO = new();
        public string Id;

        public bool AdministrationrAccess { get; set; } = false;
        public bool BillersAccess { get; set; } = false;

        public bool SupplierAccess { get; set; } = false;

        public List<Invoice> ListInvoices = new();


        protected override async Task OnInitializedAsync()
        {
            //var APIservices = config.GetSection("APIservices").Value;
            //ListInvoices = await http.GetFromJsonAsync<List<Invoice>>($"{APIservices}/api/Invoice");
            await ValidTypeUser();
            //await this.GetListInvoice();
            ReturnPage();
        }


        //private async Task GetListInvoice()
        //{
        //    try
        //    {
        //        WebResponseInvoice = await WebServices.GetInvoices(globalSearchDTO);
        //        if (WebResponseInvoice != null)
        //        {
        //            if (WebResponseInvoice.StatusCode == "OK")
        //            {
        //                ListInvoices = WebResponseInvoice.Body;
        //                StateHasChanged();
        //            }
        //        }
        //        else
        //        {
        //            await OnInitializedAsync();
        //            StateHasChanged();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


        public async Task Search()
        {       
            globalSearchDTO.PageNumber = CurrentPage;
            WebResponseInvoice = await WebServices.SearchByAllField(globalSearchDTO);
            TotalPages = WebResponseInvoice.MetaData.TotalPages;
            ListInvoices = WebResponseInvoice.Body;
            StateHasChanged();
        }

        public void Clear()
        {
            //WebResponseInvoice2 = await WebServices.GetInvoices(globalSearchDTO);
            //ListInvoices = WebResponseInvoice2.Body;
            ListInvoices = new();
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
            invoice = WebResponseInvoiceMo.Body;
        }
        #region
        //public void HandleFileSelection(byte[] file, string FileName)
        //{
        //    string[] NameAndType = FileName.Split('.');
        //    //ImgSrc = string.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(picture));
        //    if (NameAndType[1] == "pdf")
        //    {
        //        FileBase64Src = $"data:application/pdf;base64,{Convert.ToBase64String(file)}";
        //    }
        //    else
        //    {
        //        FileBase64Src = $"data:image/png;base64,{Convert.ToBase64String(file)}";
        //    }
        //}
        #endregion
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


        public async Task ValidTypeUser()
        {
            string Administration = _configuration["GroupAdministrationAccess"];
            string  Billers = _configuration["GroupbillersAccess"];

            var obj = await authentication;
            var user = obj.User;

            if (Administration != null)
            {
                AdministrationrAccess = await Task.FromResult(user.Claims.Any(x => x.Type == "GroupAccess" && x.Value == Administration));

            }
            if (Billers != null )
            {
                BillersAccess = await Task.FromResult(user.Claims.Any(x => x.Type == "GroupAccess" && x.Value == Billers));
            }
            SupplierAccess = await Task.FromResult(user.Claims.Any(x => x.Type == "SupplierId"));
        }
    }
}
