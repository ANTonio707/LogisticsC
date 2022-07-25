using Caucedo.ActiveDirectoryServices.Service;
using LogisticsCenterAPP.Services;
using LogisticsCenterMODELS.Models;
using LogisticsCenterMODELS.Models.DTOModels;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace LogisticsCenterAPP.Auth
{
    public class AuthStateProvider : AuthenticationStateProvider, ILoginServices
    {

        private readonly HttpClient _httpClient;
        private readonly ISessionStorageServices _sessionStorageServices;
     
        public static readonly string TOKENKEY = "TOKENKEY";
        private AuthenticationState anonymous => new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));

        public AuthStateProvider(HttpClient httpClient, ISessionStorageServices session)
        {
            _httpClient = httpClient;
            _sessionStorageServices = session;

        }
        //public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        //{
          
        //    //UserLoginDTO currentUser = await _httpClient.GetFromJsonAsync<UserLoginDTO>("/api/Auth/GetCurrentUser");
        //    var data = await _sessionStorageServices.GetItem<string>("Username");
            
        //    if (data != null)
        //    {
        //        var claim = new Claim(ClaimTypes.Name, data);
        //        var claimsIdentity = new ClaimsIdentity(new[] { claim }, "ServerAuth");
        //        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

        //        return new AuthenticationState(claimsPrincipal);
        //    }
        //    else
        //    {
        //        return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        //    }
        //}
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await _sessionStorageServices.GetFromSessionStorage(TOKENKEY);

            if (string.IsNullOrEmpty(token))
            {
                return anonymous;
            }

            return BuildAuthenticationState(token);
        }
        public async Task Login(string token)
        {
            await _sessionStorageServices.RemoveItem(TOKENKEY);
            await _sessionStorageServices.SetItem(TOKENKEY, token);
             
            var authState = BuildAuthenticationState(token);
            NotifyAuthenticationStateChanged(Task.FromResult(authState));

        }

        public async Task Logout()
        {
                _httpClient.DefaultRequestHeaders.Authorization = null;
                await _sessionStorageServices.RemoveItem(TOKENKEY);
                NotifyAuthenticationStateChanged(Task.FromResult(anonymous));
        }

        private AuthenticationState BuildAuthenticationState(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(ParseClaimsFromJwt(token), "jwt")));
        }

        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            keyValuePairs.TryGetValue(ClaimTypes.Role, out object roles);

            if (roles != null)
            {
                if (roles.ToString().Trim().StartsWith("["))
                {
                    var parsedRoles = JsonSerializer.Deserialize<string[]>(roles.ToString());

                    foreach (var parsedRole in parsedRoles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, parsedRole));
                    }
                }
                else
                {
                    claims.Add(new Claim(ClaimTypes.Role, roles.ToString()));
                }

                keyValuePairs.Remove(ClaimTypes.Role);
            }

            claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));
            return claims;
        }


        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }
        //public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        //{
        //    await Task.Delay(7000);
        //    var claims = new List<Claim>
        //    {
        //        new Claim(ClaimTypes.Name, "John Doe"),
        //        new Claim(ClaimTypes.Role, "Administrator")
        //    };
        //    var anonymous = new ClaimsIdentity(claims, "testAuthType");
        //    return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
        //}


    }
}