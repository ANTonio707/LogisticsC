#pragma checksum "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\SubmitInvoice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69bf5c49756e2ae96eac447a230304c4411250c3"
// <auto-generated/>
#pragma warning disable 1591
namespace LogisticsCenterAPP.Pages.InvoicePages.Components
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
#line 3 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\SubmitInvoice.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\SubmitInvoice.razor"
using LogisticsCenterAPP.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\SubmitInvoice.razor"
using LogisticsCenterMODELS.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SubmitInvoice")]
    public partial class SubmitInvoice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<LogisticsCenterAPP.Pages.InvoicePages.Components.InvoiceForm>(3);
                __builder2.AddAttribute(4, "TextBtn", "Save");
                __builder2.AddAttribute(5, "InvoiceModel", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LogisticsCenterMODELS.Models.InvoiceDTO>(
#nullable restore
#line 18 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\SubmitInvoice.razor"
                                                       invoiceDTO

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 18 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\SubmitInvoice.razor"
                                                                                   Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(7, "OnInputFileChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\SubmitInvoice.razor"
                                                                                                              OnInputFileChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(8, "DisableParameter", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\SubmitInvoice.razor"
                                                                                                                                                   IsDisabled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "activeSppiner", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\SubmitInvoice.razor"
                                                                                                                                                                              activeSpplier

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(10, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "<h1>No esta autorizado</h1>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\SubmitInvoice.razor"
       

    string Message = "No file(s) selected";
    IReadOnlyList<IBrowserFile> selectedFiles;

    [CascadingParameter]
    private Task<AuthenticationState> authenticationState { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await test();
    }
    public async Task test()
    {

        var authState = await authenticationState;
        var usuario = authState.User;
        if (usuario.Identity.IsAuthenticated)
        {
            Console.WriteLine(usuario.Identity.Name);
            Console.WriteLine(usuario.Identity.Name);
        }
        else
        {
              Console.WriteLine("Not Authorize");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _AuthSataProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBlazorStrap blazorstrapp { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebServices WebServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
