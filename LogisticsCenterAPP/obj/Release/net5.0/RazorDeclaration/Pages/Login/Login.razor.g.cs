// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LogisticsCenterAPP.Pages.Login
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\_Imports.razor"
using LogisticsCenterAPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\_Imports.razor"
using LogisticsCenterAPP.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\_Imports.razor"
using LogisticsCenterMODELS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\Login\Login.razor"
using LogisticsCenterAPP.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\Login\Login.razor"
using LogisticsCenterAPP.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\Login\Login.razor"
using LogisticsCenterMODELS.Models.DTOModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LayoutEmpty))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\Login\Login.razor"
       
    //private UserLoginDTO user; 
     
    //private async Task LoginUser()
    //{

    //    ResponseLogin = await webServices.LoginWithActiveDirectory(user);
    //    //await ((AuthStateProvider)_authProvider).LoginWithActiveDirectory(user); 
    //    navigartion.NavigateTo("/index");
    //    //return await Task.FromResult(true);

    //}

 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigartion { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authProvider { get; set; }
    }
}
#pragma warning restore 1591
