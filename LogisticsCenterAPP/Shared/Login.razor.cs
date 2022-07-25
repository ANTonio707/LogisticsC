using Caucedo.ActiveDirectoryServices.Service;
using LogisticsCenterAPP.Auth;
using LogisticsCenterAPP.Services;
using LogisticsCenterMODELS.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using System.Net.Http;
using LogisticsCenterMODELS.Models.DTOModels;
using Microsoft.AspNetCore.Components.Authorization;

namespace LogisticsCenterAPP.Shared
{
    public partial class Login
    {
        [Inject]
        private ISessionStorageServices sessionStorageServices { get; set; }
        [Inject]
        private IWebServices webServices { get; set; }

        [Inject]
        private ILoginServices loginServices { get; set; }

        public Response<UserLoginDTO> ResponseLogin { get; set; }

        public Response<UserToken> ResponseUserToken { get; set; }
        public UserLoginDTO user;

        public bool activeLoadding = false;
        protected override async Task OnInitializedAsync()
        {
            await Task.FromResult(user = new UserLoginDTO());
        }

        public async Task GetUserActiveDirectory()
        {
            activeLoadding = true;
            ResponseUserToken = await webServices.LoginWithActiveDirectory(user);
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
