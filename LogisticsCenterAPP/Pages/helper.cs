using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticsCenterAPP.Pages
{
    public partial class helper
    {

        [CascadingParameter]
        private Task<AuthenticationState> authentication { get; set; }
        public async Task GetGroup()
        {
            try
            {

                var obj = await authentication;
                var user = obj.User;
                var d = user.Claims.FirstOrDefault(x => x.Type == "GroupAccess");
                //string groupAccess = d.Value;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
    }
}
