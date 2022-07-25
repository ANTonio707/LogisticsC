using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticsCenterAPP.Pages
{
    public partial class Index
    {
        
        [CascadingParameter]
        private Task<AuthenticationState> authentication { get; set; }

        //public string groupAccess { get; set; } = " ";
        //public bool GroupbillerAccess { get; set; } 
        public bool AdministrationrAccess { get; set; } = false;
        public bool SupplierAccess { get; set; } = false;
        protected override async Task OnInitializedAsync()
        {
            await ValidTypeUser();
        }
        public async Task ValidTypeUser()
        { 
            string Administration = _configuration["GroupAdministrationAccess"];
            
            var obj = await authentication;
            var user = obj.User;

            if (Administration != null)
            {
                AdministrationrAccess = await Task.FromResult(user.Claims.Any(x => x.Type == "GroupAccess" && x.Value == Administration));
           
            }
            SupplierAccess = await Task.FromResult(user.Claims.Any(x => x.Type == "SupplierId"));
        }
       
    }
}
