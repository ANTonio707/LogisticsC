#pragma checksum "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Shared\MyNavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16b216363b8eab0c5c9ec5ddf637a0b3721aee14"
// <auto-generated/>
#pragma warning disable 1591
namespace LogisticsCenterAPP.Shared
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
#line 1 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Shared\MyNavMenu.razor"
using LogisticsCenterAPP.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Shared\MyNavMenu.razor"
using LogisticsCenterAPP.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Shared\MyNavMenu.razor"
using LogisticsCenterMODELS.Models.DTOModels;

#line default
#line hidden
#nullable disable
    public partial class MyNavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style b-du6btumtv5>
.d-flex {
     width:150px
}
 .btnLogout {
 position: relative;
 font-size: 14px;
 letter-spacing: 3px;
 height: 3em;
 width:25em;
 padding: 0 3em;
 border: none;
 background-color: #c41b54;
 color: #fff;
 text-transform: uppercase;
 overflow: hidden;
 border-radius: 5px
}

.btnLogout::before {
 content: '';
 display: block;
 position: absolute;
 z-index: 0;
 bottom: 0;
 left: 0;
 height: 0px;
 width: 100%;
 background: rgb(196,27,84);
 background: -webkit-gradient(linear, left top, right top, color-stop(20%, rgba(196,27,84,1)), to(rgba(124,7,46,1)));
 background: linear-gradient(90deg, rgba(196,27,84,1) 20%, rgba(124,7,46,1) 100%);
 -webkit-transition: 0.2s;
 transition: 0.2s;
}

.btnLogout .label {
 position: relative;
}

.btnLogout .icon {
 display: -webkit-box;
 display: -ms-flexbox;
 display: flex;
 -webkit-box-align: center;
     -ms-flex-align: center;
         align-items: center;
 -webkit-box-pack: center;
     -ms-flex-pack: center;
         justify-content: center;
 height: 3em;
 width: 3em;
 position: absolute;
 top: 3em;
 right: 0;
 opacity: 0;
 -webkit-transition: 0.4s;
 transition: 0.4s;
}

.btnLogout:hover::before {
 height: 100%;
}

.btnLogout:hover .icon {
 top: 0;
 opacity: 1;
}
</style>
");
            __builder.OpenElement(1, "nav");
            __builder.AddAttribute(2, "class", "navbar navbar-expand-lg navbar-dark bg-dark");
            __builder.AddAttribute(3, "b-du6btumtv5");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.AddAttribute(6, "b-du6btumtv5");
            __builder.AddMarkupContent(7, "<a class=\"navbar-brand\" href=\"/Index\" b-du6btumtv5><b b-du6btumtv5>Logistics Center</b></a>\r\n    ");
            __builder.AddMarkupContent(8, @"<button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarNavDropdown"" aria-controls=""navbarNavDropdown"" aria-expanded=""false"" aria-label=""Toggle navigation"" b-du6btumtv5><span class=""navbar-toggler-icon"" b-du6btumtv5></span></button>
    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "collapse navbar-collapse");
            __builder.AddAttribute(11, "id", "navbarNavDropdown");
            __builder.AddAttribute(12, "b-du6btumtv5");
            __builder.OpenElement(13, "ul");
            __builder.AddAttribute(14, "class", "navbar-nav");
            __builder.AddAttribute(15, "b-du6btumtv5");
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "class", "nav-item dropdown");
            __builder.AddAttribute(18, "b-du6btumtv5");
            __builder.AddMarkupContent(19, "<a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"navbarDropdownMenuLink\" role=\"button\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\" b-du6btumtv5>\r\n            Administration\r\n          </a>\r\n          ");
            __builder.OpenElement(20, "ul");
            __builder.AddAttribute(21, "class", "dropdown-menu bg-dark");
            __builder.AddAttribute(22, "aria-labelledby", "navbarDropdownMenuLink");
            __builder.AddAttribute(23, "b-du6btumtv5");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "nav-link");
            __builder.AddAttribute(26, "href", "RegisterUser");
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "<span class=\"@*oi oi-list-rich*@\" aria-hidden=\"true\" b-du6btumtv5></span>Register User\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n     ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "d-flex");
            __builder.AddAttribute(32, "b-du6btumtv5");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(33);
            __builder.AddAttribute(34, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(35, "button");
                __builder2.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Shared\MyNavMenu.razor"
                                     LogOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "class", "btnLogout");
                __builder2.AddAttribute(38, "b-du6btumtv5");
                __builder2.AddMarkupContent(39, "<span class=\"label\" b-du6btumtv5>Log Out</span>\r\n                      ");
                __builder2.AddMarkupContent(40, @"<span class=""icon"" b-du6btumtv5><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24"" width=""24"" height=""24"" b-du6btumtv5><path fill=""none"" d=""M0 0h24v24H0z"" b-du6btumtv5></path><path fill=""currentColor"" d=""M16.172 11l-5.364-5.364 1.414-1.414L20 12l-7.778 7.778-1.414-1.414L16.172 13H4v-2z"" b-du6btumtv5></path></svg></span>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Shared\MyNavMenu.razor"
 


    [CascadingParameter]
    private Task<AuthenticationState> authentication { get; set; }


    string Username = "";
    private async Task LogOut()
    {
        await loginServices.Logout();
        _navigation.NavigateTo("/");
    }
    private void logIn()
    {
        _navigation.NavigateTo("/");
    }
    public async Task ShowUser() 
    {
        var data = await authentication;
        if (data.User.Identity.IsAuthenticated)
        {
            Username = data.User.Identity.Name;
        }
    } 
    protected override async Task OnInitializedAsync()
    { 
        await ShowUser();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginServices loginServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionStorageServices sessionStorageServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigation { get; set; }
    }
}
#pragma warning restore 1591
