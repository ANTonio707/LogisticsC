using LogisticsCenterAPP.Services;
using LogisticsCenterMODELS.Models;
using LogisticsCenterMODELS.Models.DTOModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LogisticsCenterAPP.Pages.InvoicePages.Components
{
    public partial class InvoiceForm
    {
        [CascadingParameter]
        private Task<AuthenticationState> authentication { get; set; }


        public Response<InvoiceValidDTO> WebResponseInvoice;
        [Parameter] public InvoiceDTO InvoiceModel { get; set; } = new InvoiceDTO();
        [Parameter] public InvoiceValidDTO ModelValid { get; set; } = new InvoiceValidDTO();

        [Parameter] public string TextBtn { get; set; } = "text";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Parameter] public EventCallback<InputFileChangeEventArgs> OnInputFileChange { get; set; }
        [Parameter] public bool DisableParameter { get; set; }
        [Parameter] public bool activeSppiner { get; set; } = false;
        [Parameter] public bool IsDisabled { get; set; } = true;

        public Response<List<SupplierDTO>> WebResponseSuplier { get; set; }

        public List<SupplierDTO> ListSupplier = new();

        public int Id = 0;

        
        //public string claimSupplier = " ";
        public bool ValidUserInternal = false;
        public bool ValidUserExternal = false;

        public async Task OutFocus()
        {
            activeSppiner = true;
            //InvoiceModel.SupplierId = Id;
            ModelValid.SupplierId = Id;
            try
            {
                if (ModelValid.No_Invoice.Length > 1)
                {
                    WebResponseInvoice = await WebServices.ValitedExistenceInvoice(ModelValid);
                    if (WebResponseInvoice.IsSuccess == true)
                    {
                        InvoiceModel.SupplierId = Id;
                        InvoiceModel.No_Invoice = ModelValid.No_Invoice;
                        IsDisabled = false;
                        toastService.ShowSuccess(WebResponseInvoice.Message);
                        activeSppiner = false;
                        this.StateHasChanged();
                    }
                    else
                    {
                        activeSppiner = false;
                        IsDisabled = true;
                        toastService.ShowWarning(WebResponseInvoice.Message);
                        activeSppiner = false;
                        this.StateHasChanged();
                    }
                }
                else
                {
                    IsDisabled = true;
                    toastService.ShowWarning("The 'Invoice' field cannot be empty");
                    this.StateHasChanged();
                }
            }
            catch (Exception ex)
            {
                activeSppiner = false;
                IsDisabled = true;
                toastService.ShowWarning("The 'Invoice' is not valid");
            }
        }
        protected override async Task OnInitializedAsync()
         {
            //ListSupplier = await webServices.GetSuppliers();
            await ValidTypeUser();
            await GetSuppliers();

        }
       
        public async Task GetSuppliers()
        {
            WebResponseSuplier = await WebServices.GetSuppliers();

            ListSupplier = WebResponseSuplier.Body;
        }


        public async Task ValidTypeUser()
        {
            var user = await authentication;
            ValidUserExternal = user.User.Claims.Any(x => x.Type == "SupplierId");
            if (ValidUserExternal)
            {
                var claim = user.User.Claims.FirstOrDefault(x => x.Type == "SupplierId" && x.Value == x.Value);
                Id = Convert.ToInt32(claim.Value);
                InvoiceModel.SupplierId = Id;
            }
            ValidUserInternal = user.User.Claims.Any(x => x.Type == "GroupAccess");
        }
    }
}
