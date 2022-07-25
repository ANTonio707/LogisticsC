using Blazored.Toast.Services;
using LogisticsCenterAPP.Auth;
using LogisticsCenterAPP.Services;
using LogisticsCenterMODELS.Models;
using LogisticsCenterMODELS.Models.DTOModels;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace LogisticsCenterAPP.Pages.AuthExternalUserPages
{
    public partial class ExternalLogin 
    {


        [Inject]
        private ISessionStorageServices sessionStorageServices { get; set; }
        [Inject]
        private IWebServices webServices { get; set; }

        [Inject]
        private ILoginServices loginServices { get; set; }

        public Response<External_UserDTO> ResponseLogin { get; set; }

        public Response<UserToken> ResponseUserToken { get; set; }
        public External_User_LoginDTO external_User_LoginDTO;

        protected override async Task OnInitializedAsync()
        {
            await Task.FromResult(external_User_LoginDTO = new External_User_LoginDTO());
        }

        public async Task GetUser()
        {
            ResponseUserToken = await webServices.LoginUserExternal(external_User_LoginDTO);
            //await sessionStorageServices.SetItem<string>("Username", ResponseLogin.Body.UserName);


            if (ResponseUserToken.Body.Token != null)
            {
                await loginServices.Login(ResponseUserToken.Body.Token);
                navigartion.NavigateTo("/index");
            }
            else
            {
                toastService.ShowError(ResponseUserToken.Message);
                this.StateHasChanged();
            }
            //if (ResponseLogin != null)
            //{
            //    var claim = new Claim(ClaimTypes.Name, ResponseLogin.Body.UserName);
            //    var claimsIdentity = new ClaimsIdentity(new[] { claim }, "ServerAuth");
            //    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            //    new AuthenticationState(claimsPrincipal);
            //    navigartion.NavigateTo("/index"); 
            //}
        }
    }
}
