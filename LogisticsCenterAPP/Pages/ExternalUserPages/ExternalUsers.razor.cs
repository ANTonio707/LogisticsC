using LogisticsCenterMODELS.Models;
using LogisticsCenterMODELS.Models.DTOModels;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogisticsCenterAPP.Pages.ExternalUserPages
{
    public partial class ExternalUsers
    { 

        public Response<List<External_UserDTO>> WebResponseUser { get; set; }

        public List<External_UserDTO> ListUsers = new();

        protected override async Task OnInitializedAsync()
        {
            await GetUser();
        }

        public async Task GetUser() 
        {
            WebResponseUser = await webServices.GetExternalUsers();
            ListUsers = WebResponseUser.Body;
        }
    }
}
