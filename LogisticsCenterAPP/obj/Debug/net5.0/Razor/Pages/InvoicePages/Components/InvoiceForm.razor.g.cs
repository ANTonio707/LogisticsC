#pragma checksum "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26f6e9e05f9f11682d6355793fc849e943016bc5"
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
#line 1 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
using LogisticsCenterAPP.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
using LogisticsCenterMODELS.Models;

#line default
#line hidden
#nullable disable
    public partial class InvoiceForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                  InvoiceModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                           OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row col-md-6");
                __builder2.AddAttribute(6, "style", "margin: 0 auto");
                __builder2.AddMarkupContent(7, "<div class=\" col-md-12\" style=\"text-align:center\"><h1 style=\"margin: 0 auto\">Invoice</h1></div>\r\n        <br>\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-md-12 form-group");
                __builder2.AddMarkupContent(10, "<label class=\"form-label\">Supplier</label>\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "name", "Supplier");
                __builder2.AddAttribute(17, "placeholder", "Supplier...");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                                                               InvoiceModel.Supplier

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InvoiceModel.Supplier = __value, InvoiceModel.Supplier));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __Blazor.LogisticsCenterAPP.Pages.InvoicePages.Components.InvoiceForm.TypeInference.CreateValidationMessage_0(__builder2, 21, 22, 
#nullable restore
#line 20 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                        (()=>InvoiceModel.Supplier)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-md-6 form-group");
                __builder2.AddMarkupContent(26, "<label class=\"form-label\">No Invoice</label>\r\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.OpenElement(28, "input");
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "type", "text");
                __builder2.AddAttribute(31, "name", "NoInvoice");
                __builder2.AddAttribute(32, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                                                                                                             OutFocus

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "placeholder", "No Invoice...");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                                                                       InvoiceModel.No_Invoice

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InvoiceModel.No_Invoice = __value, InvoiceModel.No_Invoice));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __Blazor.LogisticsCenterAPP.Pages.InvoicePages.Components.InvoiceForm.TypeInference.CreateValidationMessage_1(__builder2, 37, 38, 
#nullable restore
#line 27 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                            (()=>InvoiceModel.No_Invoice)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "col-md-6 form-group");
                __builder2.AddMarkupContent(42, "<label class=\"form-label\">Invoice Date</label>\r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.OpenElement(44, "input");
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "type", "date");
                __builder2.AddAttribute(47, "name", "InvoiceSupplierDate");
                __builder2.AddAttribute(48, "placeholder", "Invoice Date...");
                __builder2.AddAttribute(49, "disabled", 
#nullable restore
#line 33 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                                                                                                                                                             IsDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                                                                                 InvoiceModel.InvoiceSupplierDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InvoiceModel.InvoiceSupplierDate = __value, InvoiceModel.InvoiceSupplierDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                    ");
                __Blazor.LogisticsCenterAPP.Pages.InvoicePages.Components.InvoiceForm.TypeInference.CreateValidationMessage_2(__builder2, 53, 54, 
#nullable restore
#line 34 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                            (()=>InvoiceModel.InvoiceSupplierDate)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-md-12 form-group");
                __builder2.AddMarkupContent(58, "<label class=\"form-label\">Payment Description</label>\r\n            ");
                __builder2.OpenElement(59, "div");
                __builder2.OpenElement(60, "input");
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "type", "text");
                __builder2.AddAttribute(63, "name", "PaymentDescription");
                __builder2.AddAttribute(64, "placeholder", "Payment Description...");
                __builder2.AddAttribute(65, "disabled", 
#nullable restore
#line 40 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                                                                                                                                                                 IsDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                                                                                InvoiceModel.PaymentDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InvoiceModel.PaymentDescription = __value, InvoiceModel.PaymentDescription));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                ");
                __Blazor.LogisticsCenterAPP.Pages.InvoicePages.Components.InvoiceForm.TypeInference.CreateValidationMessage_3(__builder2, 69, 70, 
#nullable restore
#line 41 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                        (()=>InvoiceModel.PaymentDescription)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "col-md-12 form-group");
                __builder2.AddMarkupContent(74, "<label class=\"form-label\">Reference</label>\r\n            ");
                __builder2.OpenElement(75, "div");
                __builder2.OpenElement(76, "input");
                __builder2.AddAttribute(77, "class", "form-control");
                __builder2.AddAttribute(78, "type", "text");
                __builder2.AddAttribute(79, "name", "Reference");
                __builder2.AddAttribute(80, "placeholder", "Reference...");
                __builder2.AddAttribute(81, "disabled", 
#nullable restore
#line 47 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                                                                                                                                      IsDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                                                                       InvoiceModel.Reference

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InvoiceModel.Reference = __value, InvoiceModel.Reference));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                  ");
                __Blazor.LogisticsCenterAPP.Pages.InvoicePages.Components.InvoiceForm.TypeInference.CreateValidationMessage_4(__builder2, 85, 86, 
#nullable restore
#line 48 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                          (()=>InvoiceModel.Reference)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n        ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "col-md-12 form-group");
                __builder2.AddMarkupContent(90, "<label>Invoice Picture</label>\r\n            ");
                __builder2.OpenElement(91, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(92);
                __builder2.AddAttribute(93, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                     OnInputFileChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(94, "multiple", true);
                __builder2.AddAttribute(95, "disabled", 
#nullable restore
#line 54 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                                                            IsDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n         \r\n        ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "col-md-12 form-group");
                __builder2.OpenElement(99, "input");
                __builder2.AddAttribute(100, "type", "submit");
                __builder2.AddAttribute(101, "value", 
#nullable restore
#line 59 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                         TextBtn

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(102, "class", "btn btn-success");
                __builder2.AddAttribute(103, "disabled", 
#nullable restore
#line 59 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                                                                    IsDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 60 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
             if (activeSppiner == true)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<BlazorStrap.BSSpinner>(104);
                __builder2.AddAttribute(105, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Size>(
#nullable restore
#line 62 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
                                 Size.Small

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 63 "C:\Users\D5113\source\repos\LogisticsCenter\LogisticsCenterAPP\Pages\InvoicePages\Components\InvoiceForm.razor"
            }    

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n       ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(107);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebServices WebServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.LogisticsCenterAPP.Pages.InvoicePages.Components.InvoiceForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
