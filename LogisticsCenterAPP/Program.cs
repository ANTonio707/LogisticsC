
using Blazored.Toast;
using BlazorStrap;
using Caucedo.ActiveDirectoryServices.Service;
using LogisticsCenterAPP.Auth;
using LogisticsCenterAPP.Helpers;
using LogisticsCenterAPP.Services;
using LogisticsCenterMODELS.Models;
using LogisticsCenterMODELS.Models.DTOModels;
using LogisticsCenterMODELS.ViewModels;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsCenterAPP
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
           
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("#app");
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            //var url = builder.Configuration.GetValue<string>("ApiConfig:Url");
            //builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(url) });

            builder.Services.AddScoped(x =>
            {
                var apiUrl = new Uri(builder.Configuration["apiUrl"]);
                return new HttpClient() { BaseAddress = apiUrl };
            });

            //builder.Services.AddTransient(x =>
            //{
            //    var apiUrl = new Uri(builder.Configuration["apiUrl"]);
            //    return new HttpClient() { BaseAddress = apiUrl };
            //});

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<AccountViewModel>();
            builder.Services.AddScoped<InvoiceViewModel>();
            builder.Services.AddScoped<AddAccountViewModel>();
            builder.Services.AddBlazorStrap();
            builder.Services.AddBlazoredToast();
            builder.Services.AddScoped<IHttpService, HttpService>();
            builder.Services.AddScoped<ILocalStorageService, LocalStorageService>();
            builder.Services.AddScoped<ISessionStorageServices, SessionStorageServices>();
            builder.Services.AddScoped<IWebServices, WebServices>();
            builder.Services.AddScoped<GlobalSearchDTO>();
            builder.Services.AddScoped<InvoiceDTO>();
            builder.Services.AddScoped<AccountDTO>();
            builder.Services.AddScoped<UserLoginDTO>(); 
            builder.Services.AddScoped<AuthStateProvider>(); 
            builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>(provider => provider.GetRequiredService<AuthStateProvider>());
            builder.Services.AddScoped<ILoginServices, AuthStateProvider>(provider => provider.GetRequiredService<AuthStateProvider>());
            builder.Services.AddScoped<Utls>();



            await builder.Build().RunAsync();
        }
         
    }
}
