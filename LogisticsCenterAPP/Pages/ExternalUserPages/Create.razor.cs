using LogisticsCenterAPP.Services;
using LogisticsCenterMODELS.Models;
using LogisticsCenterMODELS.Models.DTOModels;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogisticsCenterAPP.Pages.ExternalUserPages
{
    public partial class Create
    {

        [Parameter] public External_User_RegisterDTO External_User_Model { get; set; } = new External_User_RegisterDTO();
        public Response<List<SupplierDTO>> WebResponseSuplier { get; set; }
        public Response<External_UserDTO> WebResponseUser { get; set; }

        public List<SupplierDTO> ListSupplier = new();

        public int Id = 0;


        protected override async Task OnInitializedAsync()
        {
            //ListSupplier = await webServices.GetSuppliers();
            await GetSuppliers();
        }

        public async Task GetSuppliers()
        {
            WebResponseSuplier = await webServices.GetSuppliers();

            ListSupplier = WebResponseSuplier.Body;
        }
        public async Task Submit()
        {
            External_User_Model.SupplierId = Id;
            WebResponseUser = await webServices.RegisterExternalUser(External_User_Model);
        }
    } 
}
