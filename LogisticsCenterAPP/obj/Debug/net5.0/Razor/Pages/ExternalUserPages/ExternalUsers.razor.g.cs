#pragma checksum "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\ExternalUserPages\ExternalUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e470901888eea2f76667c1c92830b7778cb4ee92"
// <auto-generated/>
#pragma warning disable 1591
namespace LogisticsCenterAPP.Pages.ExternalUserPages
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
#line 2 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\ExternalUserPages\ExternalUsers.razor"
using LogisticsCenterAPP.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ExternalUsers")]
    public partial class ExternalUsers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Users</h1>");
#nullable restore
#line 6 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\ExternalUserPages\ExternalUsers.razor"
 if (ListUsers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<label>No Found...</label>");
#nullable restore
#line 9 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\ExternalUserPages\ExternalUsers.razor"
}
else if(ListUsers.Capacity == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<label>Loadding...</label>");
#nullable restore
#line 13 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\ExternalUserPages\ExternalUsers.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-hover");
            __builder.AddMarkupContent(5, "<thead><tr><td>UserName</td>\r\n            <td>First Name</td>\r\n            <td>Last Name</td>\r\n            <td>Supplier</td></tr></thead>\r\n    ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 26 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\ExternalUserPages\ExternalUsers.razor"
        foreach (var user in ListUsers)
       {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
#nullable restore
#line 29 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\ExternalUserPages\ExternalUsers.razor"
__builder.AddContent(9, user.UserName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
#nullable restore
#line 30 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\ExternalUserPages\ExternalUsers.razor"
__builder.AddContent(12, user.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 31 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\ExternalUserPages\ExternalUsers.razor"
__builder.AddContent(15, user.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 32 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\ExternalUserPages\ExternalUsers.razor"
__builder.AddContent(18, user.SupplierId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\ExternalUserPages\ExternalUsers.razor"
       }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\ExternalUserPages\ExternalUsers.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebServices webServices { get; set; }
    }
}
#pragma warning restore 1591
